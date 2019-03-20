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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dureeMoyDiagramme));
            this.chartdureemoy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartdureemoy)).BeginInit();
            this.SuspendLayout();
            // 
            // chartdureemoy
            // 
            chartArea1.Name = "ChartArea1";
            this.chartdureemoy.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartdureemoy.Legends.Add(legend1);
            this.chartdureemoy.Location = new System.Drawing.Point(99, 51);
            this.chartdureemoy.Name = "chartdureemoy";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Durée Moyenne";
            this.chartdureemoy.Series.Add(series1);
            this.chartdureemoy.Size = new System.Drawing.Size(618, 383);
            this.chartdureemoy.TabIndex = 0;
            this.chartdureemoy.Text = "chart1";
            title1.Name = "Title1";
            this.chartdureemoy.Titles.Add(title1);
            // 
            // dureeMoyDiagramme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ApplicationResponsables.Properties.Resources.hopital;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 508);
            this.Controls.Add(this.chartdureemoy);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dureeMoyDiagramme";
            this.Text = "dureeMoyDiagramme";
            ((System.ComponentModel.ISupportInitialize)(this.chartdureemoy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartdureemoy;
    }
}