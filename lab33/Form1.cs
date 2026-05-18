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
    }
}
