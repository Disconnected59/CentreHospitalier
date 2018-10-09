namespace ApplicationResponsables
{
    partial class dureeMoyDiagramme
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dureeMoyDiagramme));
            this.chartdureemoy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartdureemoy)).BeginInit();
            this.SuspendLayout();
            // 
            // chartdureemoy
            // 
            chartArea2.Name = "ChartArea1";
            this.chartdureemoy.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartdureemoy.Legends.Add(legend2);
            this.chartdureemoy.Location = new System.Drawing.Point(99, 51);
            this.chartdureemoy.Name = "chartdureemoy";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartdureemoy.Series.Add(series2);
            this.chartdureemoy.Size = new System.Drawing.Size(618, 383);
            this.chartdureemoy.TabIndex = 0;
            this.chartdureemoy.Text = "chart1";
            // 
            // dureeMoyDiagramme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 508);
            this.Controls.Add(this.chartdureemoy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dureeMoyDiagramme";
            this.Text = "dureeMoyDiagramme";
            ((System.ComponentModel.ISupportInitialize)(this.chartdureemoy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartdureemoy;
    }
}