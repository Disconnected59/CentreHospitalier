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
            this.cbboxMois = new System.Windows.Forms.ComboBox();
            this.lblPeriode = new System.Windows.Forms.Label();
            this.lblMois = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.dureemoy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dureemoy
            // 
            this.dureemoy.Controls.Add(this.cbbfinperiode);
            this.dureemoy.Controls.Add(this.cbbdebutperiode);
            this.dureemoy.Controls.Add(this.btnBascule2);
            this.dureemoy.Controls.Add(this.lblau);
            this.dureemoy.Controls.Add(this.btnvalider);
            this.dureemoy.Controls.Add(this.cbboxService);
            this.dureemoy.Controls.Add(this.cbboxMois);
            this.dureemoy.Controls.Add(this.lblPeriode);
            this.dureemoy.Controls.Add(this.lblMois);
            this.dureemoy.Controls.Add(this.lblService);
            this.dureemoy.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.dureemoy.Location = new System.Drawing.Point(105, 3);
            this.dureemoy.Name = "dureemoy";
            this.dureemoy.Size = new System.Drawing.Size(723, 455);
            this.dureemoy.TabIndex = 0;
            this.dureemoy.TabStop = false;
            this.dureemoy.Text = "Durée moyenne de séjour";
            this.dureemoy.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbbfinperiode
            // 
            this.cbbfinperiode.FormattingEnabled = true;
            this.cbbfinperiode.Location = new System.Drawing.Point(308, 266);
            this.cbbfinperiode.Name = "cbbfinperiode";
            this.cbbfinperiode.Size = new System.Drawing.Size(121, 30);
            this.cbbfinperiode.TabIndex = 15;
            // 
            // cbbdebutperiode
            // 
            this.cbbdebutperiode.FormattingEnabled = true;
            this.cbbdebutperiode.Location = new System.Drawing.Point(308, 208);
            this.cbbdebutperiode.Name = "cbbdebutperiode";
            this.cbbdebutperiode.Size = new System.Drawing.Size(121, 30);
            this.cbbdebutperiode.TabIndex = 14;
            // 
            // btnBascule2
            // 
            this.btnBascule2.Location = new System.Drawing.Point(526, 377);
            this.btnBascule2.Name = "btnBascule2";
            this.btnBascule2.Size = new System.Drawing.Size(149, 56);
            this.btnBascule2.TabIndex = 13;
            this.btnBascule2.Text = " < Page Précedente";
            this.btnBascule2.UseVisualStyleBackColor = true;
            this.btnBascule2.Click += new System.EventHandler(this.btnBascule2_Click);
            // 
            // lblau
            // 
            this.lblau.AutoSize = true;
            this.lblau.Location = new System.Drawing.Point(196, 274);
            this.lblau.Name = "lblau";
            this.lblau.Size = new System.Drawing.Size(26, 22);
            this.lblau.TabIndex = 11;
            this.lblau.Text = "au";
            // 
            // btnvalider
            // 
            this.btnvalider.Location = new System.Drawing.Point(56, 377);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(149, 56);
            this.btnvalider.TabIndex = 6;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = true;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // cbboxService
            // 
            this.cbboxService.FormattingEnabled = true;
            this.cbboxService.Location = new System.Drawing.Point(308, 76);
            this.cbboxService.Name = "cbboxService";
            this.cbboxService.Size = new System.Drawing.Size(121, 30);
            this.cbboxService.TabIndex = 5;
            // 
            // cbboxMois
            // 
            this.cbboxMois.FormattingEnabled = true;
            this.cbboxMois.Location = new System.Drawing.Point(308, 145);
            this.cbboxMois.Name = "cbboxMois";
            this.cbboxMois.Size = new System.Drawing.Size(121, 30);
            this.cbboxMois.TabIndex = 3;
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.Location = new System.Drawing.Point(196, 216);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(94, 22);
            this.lblPeriode.TabIndex = 2;
            this.lblPeriode.Text = "Période: du";
            this.lblPeriode.Click += new System.EventHandler(this.lblPeriode_Click);
            // 
            // lblMois
            // 
            this.lblMois.AutoSize = true;
            this.lblMois.Location = new System.Drawing.Point(196, 153);
            this.lblMois.Name = "lblMois";
            this.lblMois.Size = new System.Drawing.Size(41, 22);
            this.lblMois.TabIndex = 1;
            this.lblMois.Text = "Mois";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(196, 84);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(64, 22);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Service";
            this.lblService.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.ComboBox cbboxMois;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.Label lblMois;
        private System.Windows.Forms.ComboBox cbboxService;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.Label lblau;
        private System.Windows.Forms.Button btnBascule2;
        private System.Windows.Forms.ComboBox cbbfinperiode;
        private System.Windows.Forms.ComboBox cbbdebutperiode;
    }
}