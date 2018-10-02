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
            this.dureemoy = new System.Windows.Forms.GroupBox();
            this.lblService = new System.Windows.Forms.Label();
            this.lblMois = new System.Windows.Forms.Label();
            this.lblPeriode = new System.Windows.Forms.Label();
            this.cbboxMois = new System.Windows.Forms.ComboBox();
            this.cbboxService = new System.Windows.Forms.ComboBox();
            this.btnvalider = new System.Windows.Forms.Button();
            this.txtboxPeriode = new System.Windows.Forms.TextBox();
            this.dureemoy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dureemoy
            // 
            this.dureemoy.Controls.Add(this.txtboxPeriode);
            this.dureemoy.Controls.Add(this.btnvalider);
            this.dureemoy.Controls.Add(this.cbboxService);
            this.dureemoy.Controls.Add(this.cbboxMois);
            this.dureemoy.Controls.Add(this.lblPeriode);
            this.dureemoy.Controls.Add(this.lblMois);
            this.dureemoy.Controls.Add(this.lblService);
            this.dureemoy.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.dureemoy.Location = new System.Drawing.Point(218, -1);
            this.dureemoy.Name = "dureemoy";
            this.dureemoy.Size = new System.Drawing.Size(535, 469);
            this.dureemoy.TabIndex = 0;
            this.dureemoy.TabStop = false;
            this.dureemoy.Text = "Durée moyenne de séjour";
            this.dureemoy.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(15, 84);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(64, 22);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Service";
            this.lblService.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMois
            // 
            this.lblMois.AutoSize = true;
            this.lblMois.Location = new System.Drawing.Point(15, 153);
            this.lblMois.Name = "lblMois";
            this.lblMois.Size = new System.Drawing.Size(41, 22);
            this.lblMois.TabIndex = 1;
            this.lblMois.Text = "Mois";
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.Location = new System.Drawing.Point(15, 219);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(66, 22);
            this.lblPeriode.TabIndex = 2;
            this.lblPeriode.Text = "Période";
            // 
            // cbboxMois
            // 
            this.cbboxMois.FormattingEnabled = true;
            this.cbboxMois.Location = new System.Drawing.Point(107, 145);
            this.cbboxMois.Name = "cbboxMois";
            this.cbboxMois.Size = new System.Drawing.Size(121, 30);
            this.cbboxMois.TabIndex = 3;
            // 
            // cbboxService
            // 
            this.cbboxService.FormattingEnabled = true;
            this.cbboxService.Location = new System.Drawing.Point(107, 76);
            this.cbboxService.Name = "cbboxService";
            this.cbboxService.Size = new System.Drawing.Size(121, 30);
            this.cbboxService.TabIndex = 5;
            // 
            // btnvalider
            // 
            this.btnvalider.Location = new System.Drawing.Point(107, 313);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(149, 56);
            this.btnvalider.TabIndex = 6;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = true;
            // 
            // txtboxPeriode
            // 
            this.txtboxPeriode.Location = new System.Drawing.Point(107, 215);
            this.txtboxPeriode.Name = "txtboxPeriode";
            this.txtboxPeriode.Size = new System.Drawing.Size(121, 26);
            this.txtboxPeriode.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 466);
            this.Controls.Add(this.dureemoy);
            this.Name = "Form2";
            this.Text = "Form2";
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
        private System.Windows.Forms.TextBox txtboxPeriode;
    }
}