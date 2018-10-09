namespace ApplicationResponsables
{
    partial class TauxOccuPeriodeService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TauxOccuPeriodeService));
            this.chartTauxOccuPeriodeService = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTauxOccuPeriodeService)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTauxOccuPeriodeService
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTauxOccuPeriodeService.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTauxOccuPeriodeService.Legends.Add(legend1);
            this.chartTauxOccuPeriodeService.Location = new System.Drawing.Point(62, 26);
            this.chartTauxOccuPeriodeService.Name = "chartTauxOccuPeriodeService";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chartTauxOccuPeriodeService.Series.Add(series1);
            this.chartTauxOccuPeriodeService.Size = new System.Drawing.Size(629, 464);
            this.chartTauxOccuPeriodeService.TabIndex = 0;
            this.chartTauxOccuPeriodeService.Text = "chart1";
            this.chartTauxOccuPeriodeService.Click += new System.EventHandler(this.chart1_Click);
            // 
            // TauxOccuPeriodeService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 520);
            this.Controls.Add(this.chartTauxOccuPeriodeService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TauxOccuPeriodeService";
            this.Text = "TauxOccuPeriodeService";
            ((System.ComponentModel.ISupportInitialize)(this.chartTauxOccuPeriodeService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTauxOccuPeriodeService;
    }
}