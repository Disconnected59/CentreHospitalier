namespace ApplicationResponsables
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dureemoy = new System.Windows.Forms.GroupBox();
            this.cbbfinperiode = new System.Windows.Forms.ComboBox();
            this.cbbdebutperiode = new System.Windows.Forms.ComboBox();
            this.btnBascule2 = new System.Windows.Forms.Button();
            this.lblau = new System.Windows.Forms.Label();
            this.btnvalider = new System.Windows.Forms.Button();
            this.cbboxService = new System.Windows.Forms.ComboBox();
            this.lblPeriode = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.dureemoy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dureemoy
            // 
            this.dureemoy.BackColor = System.Drawing.Color.White;
            this.dureemoy.Controls.Add(this.cbbfinperiode);
            this.dureemoy.Controls.Add(this.cbbdebutperiode);
            this.dureemoy.Controls.Add(this.btnBascule2);
            this.dureemoy.Controls.Add(this.lblau);
            this.dureemoy.Controls.Add(this.btnvalider);
            this.dureemoy.Controls.Add(this.cbboxService);
            this.dureemoy.Controls.Add(this.lblPeriode);
            this.dureemoy.Controls.Add(this.lblService);
            this.dureemoy.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.dureemoy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dureemoy.Location = new System.Drawing.Point(287, 22);
            this.dureemoy.Name = "dureemoy";
            this.dureemoy.Size = new System.Drawing.Size(404, 425);
            this.dureemoy.TabIndex = 0;
            this.dureemoy.TabStop = false;
            this.dureemoy.Text = "Durée moyenne de séjour";
            this.dureemoy.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbbfinperiode
            // 
            this.cbbfinperiode.FormattingEnabled = true;
            this.cbbfinperiode.Location = new System.Drawing.Point(171, 236);
            this.cbbfinperiode.Name = "cbbfinperiode";
            this.cbbfinperiode.Size = new System.Drawing.Size(121, 30);
            this.cbbfinperiode.TabIndex = 15;
            // 
            // cbbdebutperiode
            // 
            this.cbbdebutperiode.FormattingEnabled = true;
            this.cbbdebutperiode.Location = new System.Drawing.Point(171, 160);
            this.cbbdebutperiode.Name = "cbbdebutperiode";
            this.cbbdebutperiode.Size = new System.Drawing.Size(121, 30);
            this.cbbdebutperiode.TabIndex = 14;
            // 
            // btnBascule2
            // 
            this.btnBascule2.BackColor = System.Drawing.Color.White;
            this.btnBascule2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBascule2.Location = new System.Drawing.Point(216, 353);
            this.btnBascule2.Name = "btnBascule2";
            this.btnBascule2.Size = new System.Drawing.Size(149, 56);
            this.btnBascule2.TabIndex = 13;
            this.btnBascule2.Text = " < Page Précedente";
            this.btnBascule2.UseVisualStyleBackColor = false;
            this.btnBascule2.Click += new System.EventHandler(this.btnBascule2_Click);
            // 
            // lblau
            // 
            this.lblau.AutoSize = true;
            this.lblau.BackColor = System.Drawing.Color.White;
            this.lblau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblau.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblau.Location = new System.Drawing.Point(60, 242);
            this.lblau.Name = "lblau";
            this.lblau.Size = new System.Drawing.Size(28, 24);
            this.lblau.TabIndex = 11;
            this.lblau.Text = "au";
            // 
            // btnvalider
            // 
            this.btnvalider.BackColor = System.Drawing.Color.White;
            this.btnvalider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvalider.Location = new System.Drawing.Point(34, 353);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(149, 56);
            this.btnvalider.TabIndex = 6;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = false;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // cbboxService
            // 
            this.cbboxService.BackColor = System.Drawing.SystemColors.Window;
            this.cbboxService.FormattingEnabled = true;
            this.cbboxService.Location = new System.Drawing.Point(171, 76);
            this.cbboxService.Name = "cbboxService";
            this.cbboxService.Size = new System.Drawing.Size(121, 30);
            this.cbboxService.TabIndex = 5;
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.BackColor = System.Drawing.Color.White;
            this.lblPeriode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPeriode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPeriode.Location = new System.Drawing.Point(60, 163);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(96, 24);
            this.lblPeriode.TabIndex = 2;
            this.lblPeriode.Text = "Période: du";
            this.lblPeriode.Click += new System.EventHandler(this.lblPeriode_Click);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.BackColor = System.Drawing.Color.White;
            this.lblService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblService.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblService.Location = new System.Drawing.Point(60, 79);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(66, 24);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Service";
            this.lblService.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ApplicationResponsables.Properties.Resources.hopital;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 470);
            this.Controls.Add(this.dureemoy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Tableau de bord 2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.dureemoy.ResumeLayout(false);
            this.dureemoy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dureemoy;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.ComboBox cbboxService;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.Label lblau;
        private System.Windows.Forms.Button btnBascule2;
        private System.Windows.Forms.ComboBox cbbfinperiode;
        private System.Windows.Forms.ComboBox cbbdebutperiode;
    }
}