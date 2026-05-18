using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace lab33
{
    public class GreenhouseGasService
    {
        public List<GreenhouseGasRecord> LoadFromCsv(string filePath)
        {
            var records = new List<GreenhouseGasRecord>();
            var lines = File.ReadAllLines(filePath);

            if (lines.Length < 2)
                throw new Exception("Файл пустой или не содержит данных.");

            var headers = lines[0].Split(';');

            if (headers.Length < 2 || headers[0].ToLower() != "year")
                throw new Exception("Первая колонка должна быть year.");

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                    continue;

                var parts = lines[i].Split(';');

                var record = new GreenhouseGasRecord
                {
                    Year = int.Parse(parts[0])
                };

                for (int j = 1; j < headers.Length; j++)
                {
                    double value = double.Parse(
                        parts[j].Replace(',', '.'),
                        CultureInfo.InvariantCulture
                    );

                    record.GasValues[headers[j]] = value;
                }

                records.Add(record);
            }

            return records;
        }

        public string AnalyzeDecrease(List<GreenhouseGasRecord> records)
        {
            return "";
        }
    }
}
