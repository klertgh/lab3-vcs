using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly GreenhouseGasService _gasService = new GreenhouseGasService();
        private List<GreenhouseGasRecord> _gasRecords = new List<GreenhouseGasRecord>();
        private readonly MovingAverageForecaster _forecaster = new MovingAverageForecaster();
        private readonly GdpGnpService _gdpService = new GdpGnpService();
        

        private List<GdpGnpRecord> _gdpRecords = new List<GdpGnpRecord>();
        

        private void btnOpenGasFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _gasRecords = _gasService.LoadFromCsv(dialog.FileName);
                        gridGasData.DataSource = ConvertGasRecordsToTable(_gasRecords);
                        rtbGasAnalysis.Text = _gasService.AnalyzeDecrease(_gasRecords);

                        btnBuildGasChart.Enabled = true;
                        btnForecastGas.Enabled = true;
                        btnExportGasChart.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка загрузки файла");
                    }
                }
            }
        }
        private DataTable ConvertGasRecordsToTable(List<GreenhouseGasRecord> records)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Year");

            foreach (var gasName in records.First().GasValues.Keys)
            {
                table.Columns.Add(gasName);
            }

            foreach (var record in records)
            {
                var row = table.NewRow();
                row["Year"] = record.Year;

                foreach (var gas in record.GasValues)
                {
                    row[gas.Key] = gas.Value;
                }

                table.Rows.Add(row);
            }

            return table;
        }

        private void btnBuildGasChart_Click(object sender, EventArgs e)
        {
            if (_gasRecords.Count == 0)
            {
                MessageBox.Show("Сначала загрузите файл.");
                return;
            }

            chartGas.Series.Clear();

            foreach (var gasName in _gasRecords.First().GasValues.Keys)
            {
                var series = new System.Windows.Forms.DataVisualization.Charting.Series(gasName);

                series.ChartType =
                    System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                foreach (var record in _gasRecords)
                {
                    series.Points.AddXY(
                        record.Year,
                        record.GasValues[gasName]
                    );
                }

                chartGas.Series.Add(series);
            }
        }

        private void btnForecastGas_Click(object sender, EventArgs e)
        {
            if (_gasRecords.Count == 0)
            {
                MessageBox.Show("Сначала загрузите файл.");
                return;
            }

            int forecastYears = (int)numGasForecastYears.Value;

            int movingAverageWindow =
                (int)numGasMovingAverageWindow.Value;

            if (movingAverageWindow <= 0 ||
                movingAverageWindow > _gasRecords.Count)
            {
                MessageBox.Show(
                    "n должно быть больше 0 и не больше количества лет в данных.");

                return;
            }

            for (int i = chartGas.Series.Count - 1; i >= 0; i--)
            {
                if (chartGas.Series[i].Name.Contains("Forecast"))
                {
                    chartGas.Series.RemoveAt(i);
                }
            }

            foreach (var gasName in _gasRecords.First().GasValues.Keys)
            {
                List<double> values =
                    _gasRecords
                    .Select(r => r.GasValues[gasName])
                    .ToList();

                List<double> forecast =
                    _forecaster.Forecast(
                        values,
                        movingAverageWindow,
                        forecastYears);

                var forecastSeries =
                    new System.Windows.Forms.DataVisualization.Charting.Series(
                        gasName + " Forecast");

                forecastSeries.ChartType =
                    System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                forecastSeries.BorderDashStyle =
                    System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;

                forecastSeries.BorderWidth = 3;

                int startYear = _gasRecords.First().Year;

                for (int i = 0; i < forecast.Count; i++)
                {
                    forecastSeries.Points.AddXY(
                        startYear + i,
                        forecast[i]);
                }

                chartGas.Series.Add(forecastSeries);
            }

            rtbGasAnalysis.AppendText(
                "\n\nПрогнозирование выполнено методом скользящей средней.");
        }

        private void btnExportGasChart_Click(object sender, EventArgs e)
        {
            if (chartGas.Series.Count == 0)
            {
                MessageBox.Show("Сначала постройте график.");
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "PNG Image (*.png)|*.png";
                dialog.FileName = "GreenhouseGasChart.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    chartGas.SaveImage(
                        dialog.FileName,
                        System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

                    MessageBox.Show("График успешно сохранен.");
                }
            }
        }

        private void btnOpenGdpFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _gdpRecords = _gdpService.LoadFromCsv(dialog.FileName);

                        gridGdpData.DataSource =
                            ConvertGdpRecordsToTable(_gdpRecords);

                        rtbGdpAnalysis.Text =
                            _gdpService.AnalyzeGrowthAndDecline(_gdpRecords);

                        btnBuildGdpChart.Enabled = true;
                        btnForecastGdp.Enabled = true;
                        btnExportGdpChart.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка загрузки файла");
                    }
                }
            }
        }
        private DataTable ConvertGdpRecordsToTable( List<GdpGnpRecord> records)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Year");
            table.Columns.Add("GDP");
            table.Columns.Add("GNP");

            foreach (var record in records)
            {
                var row = table.NewRow();

                row["Year"] = record.Year;
                row["GDP"] = record.Gdp.ToString("N2");
                row["GNP"] = record.Gnp.ToString("N2");

                table.Rows.Add(row);
            }

            return table;
        }

        private void btnBuildGdpChart_Click(object sender, EventArgs e)
        {
            if (_gdpRecords.Count == 0)
            {
                MessageBox.Show("Сначала загрузите файл.");
                return;
            }

            chartGdp.Series.Clear();

            var gdpSeries = new System.Windows.Forms.DataVisualization.Charting.Series("GDP");
            gdpSeries.ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            var gnpSeries = new System.Windows.Forms.DataVisualization.Charting.Series("GNP");
            gnpSeries.ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            foreach (var record in _gdpRecords)
            {
                gdpSeries.Points.AddXY(record.Year, record.Gdp);
                gnpSeries.Points.AddXY(record.Year, record.Gnp);
            }

            chartGdp.Series.Add(gdpSeries);
            chartGdp.Series.Add(gnpSeries);
        }

        private void btnForecastGdp_Click(object sender, EventArgs e)
        {
            if (_gdpRecords.Count == 0)
            {
                MessageBox.Show("Сначала загрузите файл.");
                return;
            }

            int forecastYears =
                (int)numGdpForecastYears.Value;

            int movingAverageWindow =
                (int)numGdpMovingAverageWindow.Value;

            if (movingAverageWindow <= 0 ||
                movingAverageWindow > _gdpRecords.Count)
            {
                MessageBox.Show(
                    "n должно быть больше 0 и не больше количества лет в данных.");

                return;
            }

            chartGdp.Series.Remove(
                chartGdp.Series.FindByName("GDP Forecast"));

            chartGdp.Series.Remove(
                chartGdp.Series.FindByName("GNP Forecast"));

            var gdpValues =
                _gdpRecords.Select(r => r.Gdp).ToList();

            var gnpValues =
                _gdpRecords.Select(r => r.Gnp).ToList();

            var gdpForecast =
                _forecaster.Forecast(
                    gdpValues,
                    movingAverageWindow,
                    forecastYears);

            var gnpForecast =
                _forecaster.Forecast(
                    gnpValues,
                    movingAverageWindow,
                    forecastYears);

            int lastYear =
                _gdpRecords.Last().Year;

            var gdpForecastSeries =
                new System.Windows.Forms.DataVisualization.Charting.Series(
                    "GDP Forecast");

            gdpForecastSeries.ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            gdpForecastSeries.BorderDashStyle =
                System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;

            var gnpForecastSeries =
                new System.Windows.Forms.DataVisualization.Charting.Series(
                    "GNP Forecast");

            gnpForecastSeries.ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            gnpForecastSeries.BorderDashStyle =
                System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;

            for (int i = 0; i < forecastYears; i++)
            {
                int year = lastYear + i + 1;

                gdpForecastSeries.Points.AddXY(
                    year,
                    gdpForecast[i]);

                gnpForecastSeries.Points.AddXY(
                    year,
                    gnpForecast[i]);
            }

            chartGdp.Series.Add(gdpForecastSeries);
            chartGdp.Series.Add(gnpForecastSeries);
        }
    }
}
