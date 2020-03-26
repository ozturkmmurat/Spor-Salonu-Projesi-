namespace YönCalismaProje
{
    partial class Olcumİstatistik
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_Olcumistatistik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Olcumistatistik)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Olcumistatistik
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Olcumistatistik.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Olcumistatistik.Legends.Add(legend1);
            this.chart_Olcumistatistik.Location = new System.Drawing.Point(140, 32);
            this.chart_Olcumistatistik.Name = "chart_Olcumistatistik";
            this.chart_Olcumistatistik.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Kilo";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Su Oranı";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Kas Oranı";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Yağ Oranı";
            this.chart_Olcumistatistik.Series.Add(series1);
            this.chart_Olcumistatistik.Series.Add(series2);
            this.chart_Olcumistatistik.Series.Add(series3);
            this.chart_Olcumistatistik.Series.Add(series4);
            this.chart_Olcumistatistik.Size = new System.Drawing.Size(710, 290);
            this.chart_Olcumistatistik.TabIndex = 0;
            this.chart_Olcumistatistik.Text = "Olcumistatistik";
            this.chart_Olcumistatistik.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Olcumİstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 637);
            this.Controls.Add(this.chart_Olcumistatistik);
            this.Name = "Olcumİstatistik";
            this.Text = "Olcumİstatistik";
            ((System.ComponentModel.ISupportInitialize)(this.chart_Olcumistatistik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Olcumistatistik;
    }
}