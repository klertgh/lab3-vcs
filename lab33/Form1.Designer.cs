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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.numGdpMovingAverageWindow = new System.Windows.Forms.NumericUpDown();
            this.numGdpForecastYears = new System.Windows.Forms.NumericUpDown();
            this.chartGdp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rtbGdpAnalysis = new System.Windows.Forms.RichTextBox();
            this.gridGdpData = new System.Windows.Forms.DataGridView();
            this.btnExportGdpChart = new System.Windows.Forms.Button();
            this.btnForecastGdp = new System.Windows.Forms.Button();
            this.btnBuildGdpChart = new System.Windows.Forms.Button();
            this.btnOpenGdpFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGasMovingAverageWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGasForecastYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGasData)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGdpMovingAverageWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGdpForecastYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGdp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGdpData)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(29, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1673, 922);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1665, 893);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Парниковые газы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(701, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "n для скользящей средней:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Кол-во лет прогноза:";
            // 
            // numGasMovingAverageWindow
            // 
            this.numGasMovingAverageWindow.Location = new System.Drawing.Point(701, 86);
            this.numGasMovingAverageWindow.Margin = new System.Windows.Forms.Padding(4);
            this.numGasMovingAverageWindow.Name = "numGasMovingAverageWindow";
            this.numGasMovingAverageWindow.Size = new System.Drawing.Size(160, 22);
            this.numGasMovingAverageWindow.TabIndex = 9;
            // 
            // rtbGasAnalysis
            // 
            this.rtbGasAnalysis.Location = new System.Drawing.Point(33, 687);
            this.rtbGasAnalysis.Margin = new System.Windows.Forms.Padding(4);
            this.rtbGasAnalysis.Name = "rtbGasAnalysis";
            this.rtbGasAnalysis.ReadOnly = true;
            this.rtbGasAnalysis.Size = new System.Drawing.Size(1055, 88);
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
            this.chartGas.Location = new System.Drawing.Point(600, 129);
            this.chartGas.Margin = new System.Windows.Forms.Padding(4);
            this.chartGas.Name = "chartGas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGas.Series.Add(series1);
            this.chartGas.Size = new System.Drawing.Size(901, 529);
            this.chartGas.TabIndex = 7;
            this.chartGas.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 667);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Результат анализа";
            // 
            // numGasForecastYears
            // 
            this.numGasForecastYears.Location = new System.Drawing.Point(701, 43);
            this.numGasForecastYears.Margin = new System.Windows.Forms.Padding(4);
            this.numGasForecastYears.Name = "numGasForecastYears";
            this.numGasForecastYears.Size = new System.Drawing.Size(160, 22);
            this.numGasForecastYears.TabIndex = 5;
            // 
            // gridGasData
            // 
            this.gridGasData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGasData.Location = new System.Drawing.Point(33, 129);
            this.gridGasData.Margin = new System.Windows.Forms.Padding(4);
            this.gridGasData.Name = "gridGasData";
            this.gridGasData.RowHeadersWidth = 51;
            this.gridGasData.Size = new System.Drawing.Size(539, 514);
            this.gridGasData.TabIndex = 4;
            // 
            // btnExportGasChart
            // 
            this.btnExportGasChart.Enabled = false;
            this.btnExportGasChart.Location = new System.Drawing.Point(904, 43);
            this.btnExportGasChart.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportGasChart.Name = "btnExportGasChart";
            this.btnExportGasChart.Size = new System.Drawing.Size(207, 68);
            this.btnExportGasChart.TabIndex = 3;
            this.btnExportGasChart.Text = "Экспорт графика";
            this.btnExportGasChart.UseVisualStyleBackColor = true;
            this.btnExportGasChart.Click += new System.EventHandler(this.btnExportGasChart_Click);
            // 
            // btnForecastGas
            // 
            this.btnForecastGas.Enabled = false;
            this.btnForecastGas.Location = new System.Drawing.Point(487, 43);
            this.btnForecastGas.Margin = new System.Windows.Forms.Padding(4);
            this.btnForecastGas.Name = "btnForecastGas";
            this.btnForecastGas.Size = new System.Drawing.Size(207, 68);
            this.btnForecastGas.TabIndex = 2;
            this.btnForecastGas.Text = "Сделать прогноз";
            this.btnForecastGas.UseVisualStyleBackColor = true;
            this.btnForecastGas.Click += new System.EventHandler(this.btnForecastGas_Click);
            // 
            // btnBuildGasChart
            // 
            this.btnBuildGasChart.Enabled = false;
            this.btnBuildGasChart.Location = new System.Drawing.Point(259, 43);
            this.btnBuildGasChart.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuildGasChart.Name = "btnBuildGasChart";
            this.btnBuildGasChart.Size = new System.Drawing.Size(208, 68);
            this.btnBuildGasChart.TabIndex = 1;
            this.btnBuildGasChart.Text = "Построить график";
            this.btnBuildGasChart.UseVisualStyleBackColor = true;
            this.btnBuildGasChart.Click += new System.EventHandler(this.btnBuildGasChart_Click);
            // 
            // btnOpenGasFile
            // 
            this.btnOpenGasFile.Location = new System.Drawing.Point(33, 43);
            this.btnOpenGasFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenGasFile.Name = "btnOpenGasFile";
            this.btnOpenGasFile.Size = new System.Drawing.Size(207, 68);
            this.btnOpenGasFile.TabIndex = 0;
            this.btnOpenGasFile.Text = "Открыть файл";
            this.btnOpenGasFile.UseVisualStyleBackColor = true;
            this.btnOpenGasFile.Click += new System.EventHandler(this.btnOpenGasFile_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.numGdpMovingAverageWindow);
            this.tabPage2.Controls.Add(this.numGdpForecastYears);
            this.tabPage2.Controls.Add(this.chartGdp);
            this.tabPage2.Controls.Add(this.rtbGdpAnalysis);
            this.tabPage2.Controls.Add(this.gridGdpData);
            this.tabPage2.Controls.Add(this.btnExportGdpChart);
            this.tabPage2.Controls.Add(this.btnForecastGdp);
            this.tabPage2.Controls.Add(this.btnBuildGdpChart);
            this.tabPage2.Controls.Add(this.btnOpenGdpFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1665, 893);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ВВП и ВНП";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numGdpMovingAverageWindow
            // 
            this.numGdpMovingAverageWindow.Location = new System.Drawing.Point(1012, 98);
            this.numGdpMovingAverageWindow.Name = "numGdpMovingAverageWindow";
            this.numGdpMovingAverageWindow.Size = new System.Drawing.Size(172, 22);
            this.numGdpMovingAverageWindow.TabIndex = 8;
            // 
            // numGdpForecastYears
            // 
            this.numGdpForecastYears.Location = new System.Drawing.Point(1012, 54);
            this.numGdpForecastYears.Name = "numGdpForecastYears";
            this.numGdpForecastYears.Size = new System.Drawing.Size(172, 22);
            this.numGdpForecastYears.TabIndex = 7;
            // 
            // chartGdp
            // 
            chartArea2.AxisX.Title = "Год";
            chartArea2.AxisY.Title = "Значение";
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.Name = "ChartArea1";
            this.chartGdp.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGdp.Legends.Add(legend2);
            this.chartGdp.Location = new System.Drawing.Point(509, 142);
            this.chartGdp.Name = "chartGdp";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartGdp.Series.Add(series2);
            this.chartGdp.Size = new System.Drawing.Size(479, 445);
            this.chartGdp.TabIndex = 6;
            this.chartGdp.Text = "chart1";
            // 
            // rtbGdpAnalysis
            // 
            this.rtbGdpAnalysis.Location = new System.Drawing.Point(1012, 142);
            this.rtbGdpAnalysis.Name = "rtbGdpAnalysis";
            this.rtbGdpAnalysis.Size = new System.Drawing.Size(172, 445);
            this.rtbGdpAnalysis.TabIndex = 5;
            this.rtbGdpAnalysis.Text = "";
            // 
            // gridGdpData
            // 
            this.gridGdpData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGdpData.Location = new System.Drawing.Point(30, 142);
            this.gridGdpData.Name = "gridGdpData";
            this.gridGdpData.RowHeadersWidth = 51;
            this.gridGdpData.RowTemplate.Height = 24;
            this.gridGdpData.Size = new System.Drawing.Size(471, 445);
            this.gridGdpData.TabIndex = 4;
            // 
            // btnExportGdpChart
            // 
            this.btnExportGdpChart.Enabled = false;
            this.btnExportGdpChart.Location = new System.Drawing.Point(737, 35);
            this.btnExportGdpChart.Name = "btnExportGdpChart";
            this.btnExportGdpChart.Size = new System.Drawing.Size(251, 85);
            this.btnExportGdpChart.TabIndex = 3;
            this.btnExportGdpChart.Text = "Экспорт графика";
            this.btnExportGdpChart.UseVisualStyleBackColor = true;
            // 
            // btnForecastGdp
            // 
            this.btnForecastGdp.Enabled = false;
            this.btnForecastGdp.Location = new System.Drawing.Point(509, 35);
            this.btnForecastGdp.Name = "btnForecastGdp";
            this.btnForecastGdp.Size = new System.Drawing.Size(222, 85);
            this.btnForecastGdp.TabIndex = 2;
            this.btnForecastGdp.Text = "Сделать прогноз";
            this.btnForecastGdp.UseVisualStyleBackColor = true;
            // 
            // btnBuildGdpChart
            // 
            this.btnBuildGdpChart.Enabled = false;
            this.btnBuildGdpChart.Location = new System.Drawing.Point(274, 35);
            this.btnBuildGdpChart.Name = "btnBuildGdpChart";
            this.btnBuildGdpChart.Size = new System.Drawing.Size(227, 85);
            this.btnBuildGdpChart.TabIndex = 1;
            this.btnBuildGdpChart.Text = "Построить график";
            this.btnBuildGdpChart.UseVisualStyleBackColor = true;
            this.btnBuildGdpChart.Click += new System.EventHandler(this.btnBuildGdpChart_Click);
            // 
            // btnOpenGdpFile
            // 
            this.btnOpenGdpFile.Location = new System.Drawing.Point(30, 35);
            this.btnOpenGdpFile.Name = "btnOpenGdpFile";
            this.btnOpenGdpFile.Size = new System.Drawing.Size(238, 85);
            this.btnOpenGdpFile.TabIndex = 0;
            this.btnOpenGdpFile.Text = "Открыть файл";
            this.btnOpenGdpFile.UseVisualStyleBackColor = true;
            this.btnOpenGdpFile.Click += new System.EventHandler(this.btnOpenGdpFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1009, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "n скользящей средней";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1009, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "количество лет прогноза";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 983);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGasMovingAverageWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGasForecastYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGasData)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGdpMovingAverageWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGdpForecastYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGdp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGdpData)).EndInit();
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
        private System.Windows.Forms.Button btnExportGdpChart;
        private System.Windows.Forms.Button btnForecastGdp;
        private System.Windows.Forms.Button btnBuildGdpChart;
        private System.Windows.Forms.Button btnOpenGdpFile;
        private System.Windows.Forms.DataGridView gridGdpData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGdp;
        private System.Windows.Forms.RichTextBox rtbGdpAnalysis;
        private System.Windows.Forms.NumericUpDown numGdpMovingAverageWindow;
        private System.Windows.Forms.NumericUpDown numGdpForecastYears;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

