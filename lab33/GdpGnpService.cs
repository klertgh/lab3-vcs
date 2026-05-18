using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace lab33
{
    public class GdpGnpService
    {
        public List<GdpGnpRecord> LoadFromCsv(string filePath)
        {
            var records = new List<GdpGnpRecord>();
            var lines = File.ReadAllLines(filePath);

            if (lines.Length < 2)
                throw new Exception("Файл пустой или не содержит данных.");

            var headers = lines[0].Split(';');

            if (headers.Length < 3 ||
                headers[0].ToLower() != "year" ||
                headers[1].ToLower() != "gdp" ||
                headers[2].ToLower() != "gnp")
            {
                throw new Exception("Файл должен содержать колонки: year;GDP;GNP");
            }

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                    continue;

                var parts = lines[i].Split(';');

                if (parts.Length < 3)
                    throw new Exception($"Ошибка в строке {i + 1}: недостаточно данных.");

                var record = new GdpGnpRecord
                {
                    Year = int.Parse(parts[0]),
                    Gdp = double.Parse(parts[1].Replace(',', '.'), CultureInfo.InvariantCulture),
                    Gnp = double.Parse(parts[2].Replace(',', '.'), CultureInfo.InvariantCulture)
                };

                records.Add(record);
            }

            return records.OrderBy(r => r.Year).ToList();
        }

        public string AnalyzeGrowthAndDecline(List<GdpGnpRecord> records)
        {
            if (records == null || records.Count < 2)
                return "Недостаточно данных для анализа.";

            string result = "Анализ изменения ВВП и ВНП за год:\n\n";

            result += AnalyzeIndicator(records, "ВВП", r => r.Gdp);
            result += "\n";
            result += AnalyzeIndicator(records, "ВНП", r => r.Gnp);

            return result;
        }

        private string AnalyzeIndicator(
            List<GdpGnpRecord> records,
            string indicatorName,
            Func<GdpGnpRecord, double> selector)
        {
            double maxGrowthPercent = double.MinValue;
            double maxDeclinePercent = double.MaxValue;

            double maxGrowthAbsolute = 0;
            double maxDeclineAbsolute = 0;

            int maxGrowthYear = 0;
            int maxDeclineYear = 0;

            for (int i = 1; i < records.Count; i++)
            {
                double previous = selector(records[i - 1]);
                double current = selector(records[i]);

                if (previous == 0)
                    continue;

                double absoluteChange = current - previous;
                double percentChange = absoluteChange / previous * 100;

                if (percentChange > maxGrowthPercent)
                {
                    maxGrowthPercent = percentChange;
                    maxGrowthAbsolute = absoluteChange;
                    maxGrowthYear = records[i].Year;
                }

                if (percentChange < maxDeclinePercent)
                {
                    maxDeclinePercent = percentChange;
                    maxDeclineAbsolute = absoluteChange;
                    maxDeclineYear = records[i].Year;
                }
            }

            return
                $"{indicatorName}:\n" +
                $"Максимальный рост: {maxGrowthPercent:F2}% в {maxGrowthYear} году\n" +
                $"Абсолютное изменение при росте: {maxGrowthAbsolute:N2}\n" +
                $"Максимальное падение: {maxDeclinePercent:F2}% в {maxDeclineYear} году\n" +
                $"Абсолютное изменение при падении: {maxDeclineAbsolute:N2}\n";
        }
    }
}
