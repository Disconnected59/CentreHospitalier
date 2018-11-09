namespace ApplicationResponsables
{
    partial class TauxOccuGlobalParAn
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartTauxOccuGlobalParAn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTauxOccuGlobalParAn)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTauxOccuGlobalParAn
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTauxOccuGlobalParAn.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTauxOccuGlobalParAn.Legends.Add(legend1);
            this.chartTauxOccuGlobalParAn.Location = new System.Drawing.Point(155, 48);
            this.chartTauxOccuGlobalParAn.Name = "chartTauxOccuGlobalParAn";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Taux";
            this.chartTauxOccuGlobalParAn.Series.Add(series1);
            this.chartTauxOccuGlobalParAn.Size = new System.Drawing.Size(593, 473);
            this.chartTauxOccuGlobalParAn.TabIndex = 0;
            this.chartTauxOccuGlobalParAn.Text = "chart1";
            title1.Name = "Title1";
            this.chartTauxOccuGlobalParAn.Titles.Add(title1);
            // 
            // TauxOccuGlobalParAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ApplicationResponsables.Properties.Resources.hopital;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 607);
            this.Controls.Add(this.chartTauxOccuGlobalParAn);
            this.Name = "TauxOccuGlobalParAn";
            this.Text = "TauxOccuGlobalParAn";
            ((System.ComponentModel.ISupportInitialize)(this.chartTauxOccuGlobalParAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTauxOccuGlobalParAn;
    }
}