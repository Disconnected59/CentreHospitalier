namespace ApplicationResponsables
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.btnBascule1 = new System.Windows.Forms.Button();
            this.btnValidChangerDebut = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbldate2 = new System.Windows.Forms.Label();
            this.lbldate1 = new System.Windows.Forms.Label();
            this.cmbMois2 = new System.Windows.Forms.ComboBox();
            this.cmbServices = new System.Windows.Forms.ComboBox();
            this.btnValidPeriodeService = new System.Windows.Forms.Button();
            this.lblPeriod3 = new System.Windows.Forms.Label();
            this.lblPeriode2 = new System.Windows.Forms.Label();
            this.lblPeriode = new System.Windows.Forms.Label();
            this.lbllService = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnValiderConnexion = new System.Windows.Forms.Button();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtBoxMdp = new System.Windows.Forms.TextBox();
            this.txtBoxLabel = new System.Windows.Forms.TextBox();
            this.cmbMois3 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.btnBascule1);
            this.groupBox1.Controls.Add(this.btnValidChangerDebut);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(539, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 424);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taux d\'occupation total de l\'hopital";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(181, 143);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(149, 22);
            this.lbl5.TabIndex = 10;
            this.lbl5.Text = "Pour l\'année 2018 : ";
            // 
            // btnBascule1
            // 
            this.btnBascule1.Location = new System.Drawing.Point(171, 379);
            this.btnBascule1.Name = "btnBascule1";
            this.btnBascule1.Size = new System.Drawing.Size(159, 45);
            this.btnBascule1.TabIndex = 9;
            this.btnBascule1.Text = "Page suivante >";
            this.btnBascule1.UseVisualStyleBackColor = true;
            this.btnBascule1.Click += new System.EventHandler(this.btnBascule1_Click);
            // 
            // btnValidChangerDebut
            // 
            this.btnValidChangerDebut.Location = new System.Drawing.Point(171, 191);
            this.btnValidChangerDebut.Name = "btnValidChangerDebut";
            this.btnValidChangerDebut.Size = new System.Drawing.Size(169, 62);
            this.btnValidChangerDebut.TabIndex = 6;
            this.btnValidChangerDebut.Text = "Valider";
            this.btnValidChangerDebut.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbMois3);
            this.groupBox3.Controls.Add(this.lbldate2);
            this.groupBox3.Controls.Add(this.lbldate1);
            this.groupBox3.Controls.Add(this.cmbMois2);
            this.groupBox3.Controls.Add(this.cmbServices);
            this.groupBox3.Controls.Add(this.btnValidPeriodeService);
            this.groupBox3.Controls.Add(this.lblPeriod3);
            this.groupBox3.Controls.Add(this.lblPeriode2);
            this.groupBox3.Controls.Add(this.lblPeriode);
            this.groupBox3.Controls.Add(this.lbllService);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(26, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 437);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Taux d\'occupation des lits par période et service choisi";
            // 
            // lbldate2
            // 
            this.lbldate2.AutoSize = true;
            this.lbldate2.Location = new System.Drawing.Point(295, 319);
            this.lbldate2.Name = "lbldate2";
            this.lbldate2.Size = new System.Drawing.Size(42, 22);
            this.lbldate2.TabIndex = 13;
            this.lbldate2.Text = "2018";
            // 
            // lbldate1
            // 
            this.lbldate1.AutoSize = true;
            this.lbldate1.Location = new System.Drawing.Point(295, 223);
            this.lbldate1.Name = "lbldate1";
            this.lbldate1.Size = new System.Drawing.Size(42, 22);
            this.lbldate1.TabIndex = 12;
            this.lbldate1.Text = "2018";
            // 
            // cmbMois2
            // 
            this.cmbMois2.FormattingEnabled = true;
            this.cmbMois2.Location = new System.Drawing.Point(61, 220);
            this.cmbMois2.Name = "cmbMois2";
            this.cmbMois2.Size = new System.Drawing.Size(143, 30);
            this.cmbMois2.TabIndex = 10;
            this.cmbMois2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbServices
            // 
            this.cmbServices.FormattingEnabled = true;
            this.cmbServices.Location = new System.Drawing.Point(171, 101);
            this.cmbServices.Name = "cmbServices";
            this.cmbServices.Size = new System.Drawing.Size(166, 30);
            this.cmbServices.TabIndex = 9;
            // 
            // btnValidPeriodeService
            // 
            this.btnValidPeriodeService.Location = new System.Drawing.Point(147, 371);
            this.btnValidPeriodeService.Name = "btnValidPeriodeService";
            this.btnValidPeriodeService.Size = new System.Drawing.Size(152, 45);
            this.btnValidPeriodeService.TabIndex = 7;
            this.btnValidPeriodeService.Text = "Valider";
            this.btnValidPeriodeService.UseVisualStyleBackColor = true;
            this.btnValidPeriodeService.Click += new System.EventHandler(this.btnValidPeriodeService_Click);
            // 
            // lblPeriod3
            // 
            this.lblPeriod3.AutoSize = true;
            this.lblPeriod3.Location = new System.Drawing.Point(210, 275);
            this.lblPeriod3.Name = "lblPeriod3";
            this.lblPeriod3.Size = new System.Drawing.Size(43, 22);
            this.lblPeriod3.TabIndex = 5;
            this.lblPeriod3.Text = "Au : ";
            // 
            // lblPeriode2
            // 
            this.lblPeriode2.AutoSize = true;
            this.lblPeriode2.Location = new System.Drawing.Point(210, 191);
            this.lblPeriode2.Name = "lblPeriode2";
            this.lblPeriode2.Size = new System.Drawing.Size(44, 22);
            this.lblPeriode2.TabIndex = 3;
            this.lblPeriode2.Text = "Du : ";
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.Location = new System.Drawing.Point(146, 169);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(153, 22);
            this.lblPeriode.TabIndex = 2;
            this.lblPeriode.Text = "Définir la periode : ";
            // 
            // lbllService
            // 
            this.lbllService.AutoSize = true;
            this.lbllService.Location = new System.Drawing.Point(57, 104);
            this.lbllService.Name = "lbllService";
            this.lbllService.Size = new System.Drawing.Size(80, 22);
            this.lbllService.TabIndex = 0;
            this.lbllService.Text = "Service : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnValiderConnexion);
            this.groupBox4.Controls.Add(this.lblMdp);
            this.groupBox4.Controls.Add(this.lblLogin);
            this.groupBox4.Controls.Add(this.txtBoxMdp);
            this.groupBox4.Controls.Add(this.txtBoxLabel);
            this.groupBox4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(608, 429);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(536, 116);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vous êtes administrateur? Connectez vous !";
            // 
            // btnValiderConnexion
            // 
            this.btnValiderConnexion.Location = new System.Drawing.Point(305, 25);
            this.btnValiderConnexion.Name = "btnValiderConnexion";
            this.btnValiderConnexion.Size = new System.Drawing.Size(152, 45);
            this.btnValiderConnexion.TabIndex = 10;
            this.btnValiderConnexion.Text = "Valider";
            this.btnValiderConnexion.UseVisualStyleBackColor = true;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(22, 65);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(94, 18);
            this.lblMdp.TabIndex = 3;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(19, 22);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(53, 18);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login : ";
            // 
            // txtBoxMdp
            // 
            this.txtBoxMdp.Location = new System.Drawing.Point(155, 65);
            this.txtBoxMdp.Name = "txtBoxMdp";
            this.txtBoxMdp.Size = new System.Drawing.Size(100, 23);
            this.txtBoxMdp.TabIndex = 1;
            // 
            // txtBoxLabel
            // 
            this.txtBoxLabel.Location = new System.Drawing.Point(155, 22);
            this.txtBoxLabel.Name = "txtBoxLabel";
            this.txtBoxLabel.Size = new System.Drawing.Size(100, 23);
            this.txtBoxLabel.TabIndex = 0;
            // 
            // cmbMois3
            // 
            this.cmbMois3.FormattingEnabled = true;
            this.cmbMois3.Location = new System.Drawing.Point(61, 319);
            this.cmbMois3.Name = "cmbMois3";
            this.cmbMois3.Size = new System.Drawing.Size(143, 30);
            this.cmbMois3.TabIndex = 14;
            this.cmbMois3.SelectedIndexChanged += new System.EventHandler(this.cmbMois3_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 438);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tableau de bord";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnValidChangerDebut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnValidPeriodeService;
        private System.Windows.Forms.Label lblPeriod3;
        private System.Windows.Forms.Label lblPeriode2;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.Label lbllService;
        private System.Windows.Forms.ComboBox cmbServices;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBoxMdp;
        private System.Windows.Forms.TextBox txtBoxLabel;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnValiderConnexion;
        private System.Windows.Forms.Button btnBascule1;
        private System.Windows.Forms.Label lbldate2;
        private System.Windows.Forms.Label lbldate1;
        private System.Windows.Forms.ComboBox cmbMois2;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.ComboBox cmbMois3;
    }
}

