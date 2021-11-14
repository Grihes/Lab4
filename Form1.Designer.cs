
namespace Task4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 0.1D;
            chartArea1.AxisX.Maximum = 1D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "x, м";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.Interval = 0.05D;
            chartArea1.AxisY.Maximum = 0.5D;
            chartArea1.AxisY.Minimum = -0.1D;
            chartArea1.AxisY.Title = "Φ, В";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.Name = "ChartArea1";
            chartArea1.Visible = false;
            chartArea2.AxisX.Interval = 0.1D;
            chartArea2.AxisX.Maximum = 1D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.Title = "x, м";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.AxisY.Interval = 0.05D;
            chartArea2.AxisY.Maximum = 0.5D;
            chartArea2.AxisY.Minimum = -0.05D;
            chartArea2.AxisY.Title = "Ф, В";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.Name = "ChartArea2";
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.Title = "x, м";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.AxisY.Title = "ΔФ, В";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.BorderWidth = 2;
            chartArea3.Name = "ChartArea3";
            chartArea3.Visible = false;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ChartAreas.Add(chartArea3);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            legendItem1.Color = System.Drawing.Color.Blue;
            legendItem1.Name = "Φ(x)";
            legend2.CustomItems.Add(legendItem1);
            legend2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend2";
            this.chart1.Legends.Add(legend1);
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(146, 34);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea2";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea3";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1023, 692);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 802);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

