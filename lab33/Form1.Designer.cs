namespace lab33
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numGasMovingAverageWindow = new System.Windows.Forms.NumericUpDown();
            this.rtbGasAnalysis = new System.Windows.Forms.RichTextBox();
            this.chartGas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.numGasForecastYears = new System.Windows.Forms.NumericUpDown();
            this.gridGasData = new System.Windows.Forms.DataGridView();
            this.btnExportGasChart = new System.Windows.Forms.Button();
            this.btnForecastGas = new System.Windows.Forms.Button();
            this.btnBuildGasChart = new System.Windows.Forms.Button();
            this.btnOpenGasFile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGasMovingAverageWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGasForecastYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGasData)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1255, 749);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numGasMovingAverageWindow);
            this.tabPage1.Controls.Add(this.rtbGasAnalysis);
            this.tabPage1.Controls.Add(this.chartGas);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numGasForecastYears);
            this.tabPage1.Controls.Add(this.gridGasData);
            this.tabPage1.Controls.Add(this.btnExportGasChart);
            this.tabPage1.Controls.Add(this.btnForecastGas);
            this.tabPage1.Controls.Add(this.btnBuildGasChart);
            this.tabPage1.Controls.Add(this.btnOpenGasFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1247, 723);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Парниковые газы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "n для скользящей средней:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Кол-во лет прогноза:";
            // 
            // numGasMovingAverageWindow
            // 
            this.numGasMovingAverageWindow.Location = new System.Drawing.Point(526, 70);
            this.numGasMovingAverageWindow.Name = "numGasMovingAverageWindow";
            this.numGasMovingAverageWindow.Size = new System.Drawing.Size(120, 20);
            this.numGasMovingAverageWindow.TabIndex = 9;
            // 
            // rtbGasAnalysis
            // 
            this.rtbGasAnalysis.Location = new System.Drawing.Point(25, 558);
            this.rtbGasAnalysis.Name = "rtbGasAnalysis";
            this.rtbGasAnalysis.ReadOnly = true;
            this.rtbGasAnalysis.Size = new System.Drawing.Size(792, 72);
            this.rtbGasAnalysis.TabIndex = 8;
            this.rtbGasAnalysis.Text = "";
            // 
            // chartGas
            // 
            chartArea1.AxisX.Title = "Год";
            chartArea1.AxisY.Title = "Выбросы";
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chartGas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGas.Legends.Add(legend1);
            this.chartGas.Location = new System.Drawing.Point(450, 105);
            this.chartGas.Name = "chartGas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGas.Series.Add(series1);
            this.chartGas.Size = new System.Drawing.Size(676, 430);
            this.chartGas.TabIndex = 7;
            this.chartGas.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Результат анализа";
            // 
            // numGasForecastYears
            // 
            this.numGasForecastYears.Location = new System.Drawing.Point(526, 35);
            this.numGasForecastYears.Name = "numGasForecastYears";
            this.numGasForecastYears.Size = new System.Drawing.Size(120, 20);
            this.numGasForecastYears.TabIndex = 5;
            // 
            // gridGasData
            // 
            this.gridGasData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGasData.Location = new System.Drawing.Point(25, 105);
            this.gridGasData.Name = "gridGasData";
            this.gridGasData.Size = new System.Drawing.Size(404, 418);
            this.gridGasData.TabIndex = 4;
            // 
            // btnExportGasChart
            // 
            this.btnExportGasChart.Enabled = false;
            this.btnExportGasChart.Location = new System.Drawing.Point(678, 35);
            this.btnExportGasChart.Name = "btnExportGasChart";
            this.btnExportGasChart.Size = new System.Drawing.Size(155, 55);
            this.btnExportGasChart.TabIndex = 3;
            this.btnExportGasChart.Text = "Экспорт графика";
            this.btnExportGasChart.UseVisualStyleBackColor = true;
            this.btnExportGasChart.Click += new System.EventHandler(this.btnExportGasChart_Click);
            // 
            // btnForecastGas
            // 
            this.btnForecastGas.Enabled = false;
            this.btnForecastGas.Location = new System.Drawing.Point(365, 35);
            this.btnForecastGas.Name = "btnForecastGas";
            this.btnForecastGas.Size = new System.Drawing.Size(155, 55);
            this.btnForecastGas.TabIndex = 2;
            this.btnForecastGas.Text = "Сделать прогноз";
            this.btnForecastGas.UseVisualStyleBackColor = true;
            this.btnForecastGas.Click += new System.EventHandler(this.btnForecastGas_Click);
            // 
            // btnBuildGasChart
            // 
            this.btnBuildGasChart.Enabled = false;
            this.btnBuildGasChart.Location = new System.Drawing.Point(194, 35);
            this.btnBuildGasChart.Name = "btnBuildGasChart";
            this.btnBuildGasChart.Size = new System.Drawing.Size(156, 55);
            this.btnBuildGasChart.TabIndex = 1;
            this.btnBuildGasChart.Text = "Построить график";
            this.btnBuildGasChart.UseVisualStyleBackColor = true;
            this.btnBuildGasChart.Click += new System.EventHandler(this.btnBuildGasChart_Click);
            // 
            // btnOpenGasFile
            // 
            this.btnOpenGasFile.Location = new System.Drawing.Point(25, 35);
            this.btnOpenGasFile.Name = "btnOpenGasFile";
            this.btnOpenGasFile.Size = new System.Drawing.Size(155, 55);
            this.btnOpenGasFile.TabIndex = 0;
            this.btnOpenGasFile.Text = "Открыть файл";
            this.btnOpenGasFile.UseVisualStyleBackColor = true;
            this.btnOpenGasFile.Click += new System.EventHandler(this.btnOpenGasFile_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1247, 723);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ВВП и ВНП";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 799);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGasMovingAverageWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGasForecastYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGasData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numGasForecastYears;
        private System.Windows.Forms.DataGridView gridGasData;
        private System.Windows.Forms.Button btnExportGasChart;
        private System.Windows.Forms.Button btnForecastGas;
        private System.Windows.Forms.Button btnBuildGasChart;
        private System.Windows.Forms.Button btnOpenGasFile;
        private System.Windows.Forms.RichTextBox rtbGasAnalysis;
        private System.Windows.Forms.NumericUpDown numGasMovingAverageWindow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

