﻿namespace ApplicationResponsables
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
            this.cmbAnnee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbMoisTot2 = new System.Windows.Forms.ComboBox();
            this.cmbMoisTot1 = new System.Windows.Forms.ComboBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.btnBascule1 = new System.Windows.Forms.Button();
            this.btnValidChangerDebut = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAnnee2 = new System.Windows.Forms.ComboBox();
            this.cmbMois3 = new System.Windows.Forms.ComboBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbAnnee);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cmbMoisTot2);
            this.groupBox1.Controls.Add(this.cmbMoisTot1);
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.btnBascule1);
            this.groupBox1.Controls.Add(this.btnValidChangerDebut);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(539, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 424);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taux d\'occupation total de l\'hopital";
            // 
            // cmbAnnee
            // 
            this.cmbAnnee.FormattingEnabled = true;
            this.cmbAnnee.Location = new System.Drawing.Point(210, 40);
            this.cmbAnnee.Name = "cmbAnnee";
            this.cmbAnnee.Size = new System.Drawing.Size(121, 30);
            this.cmbAnnee.TabIndex = 18;
            this.cmbAnnee.SelectedIndexChanged += new System.EventHandler(this.cmbAnnee_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(296, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mois de fin : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mois de départ :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ApplicationResponsables.Properties.Resources.telephone;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(314, 319);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 104);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // cmbMoisTot2
            // 
            this.cmbMoisTot2.FormattingEnabled = true;
            this.cmbMoisTot2.Location = new System.Drawing.Point(300, 110);
            this.cmbMoisTot2.Name = "cmbMoisTot2";
            this.cmbMoisTot2.Size = new System.Drawing.Size(143, 30);
            this.cmbMoisTot2.TabIndex = 12;
            // 
            // cmbMoisTot1
            // 
            this.cmbMoisTot1.FormattingEnabled = true;
            this.cmbMoisTot1.Location = new System.Drawing.Point(44, 110);
            this.cmbMoisTot1.Name = "cmbMoisTot1";
            this.cmbMoisTot1.Size = new System.Drawing.Size(143, 30);
            this.cmbMoisTot1.TabIndex = 11;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(87, 43);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(117, 22);
            this.lbl5.TabIndex = 10;
            this.lbl5.Text = "Pour l\'année  : ";
            // 
            // btnBascule1
            // 
            this.btnBascule1.Location = new System.Drawing.Point(17, 371);
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
            this.btnValidChangerDebut.Click += new System.EventHandler(this.btnValidChangerDebut_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbAnnee2);
            this.groupBox3.Controls.Add(this.cmbMois3);
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
            this.groupBox3.Size = new System.Drawing.Size(507, 424);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Taux d\'occupation des lits par période et service choisi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(107, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mois";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(293, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Année : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbAnnee2
            // 
            this.cmbAnnee2.FormattingEnabled = true;
            this.cmbAnnee2.Location = new System.Drawing.Point(368, 250);
            this.cmbAnnee2.Name = "cmbAnnee2";
            this.cmbAnnee2.Size = new System.Drawing.Size(121, 30);
            this.cmbAnnee2.TabIndex = 19;
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
            this.cmbServices.SelectedIndexChanged += new System.EventHandler(this.cmbServices_SelectedIndexChanged);
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
            this.lblPeriod3.BackColor = System.Drawing.Color.White;
            this.lblPeriod3.Location = new System.Drawing.Point(210, 275);
            this.lblPeriod3.Name = "lblPeriod3";
            this.lblPeriod3.Size = new System.Drawing.Size(43, 22);
            this.lblPeriod3.TabIndex = 5;
            this.lblPeriod3.Text = "Au : ";
            // 
            // lblPeriode2
            // 
            this.lblPeriode2.AutoSize = true;
            this.lblPeriode2.BackColor = System.Drawing.Color.White;
            this.lblPeriode2.Location = new System.Drawing.Point(210, 191);
            this.lblPeriode2.Name = "lblPeriode2";
            this.lblPeriode2.Size = new System.Drawing.Size(44, 22);
            this.lblPeriode2.TabIndex = 3;
            this.lblPeriode2.Text = "Du : ";
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.BackColor = System.Drawing.Color.White;
            this.lblPeriode.Location = new System.Drawing.Point(146, 169);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(153, 22);
            this.lblPeriode.TabIndex = 2;
            this.lblPeriode.Text = "Définir la periode : ";
            // 
            // lbllService
            // 
            this.lbllService.AutoSize = true;
            this.lbllService.BackColor = System.Drawing.Color.White;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ApplicationResponsables.Properties.Resources.hopital;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 438);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tableau de bord";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbMois2;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.ComboBox cmbMois3;
        private System.Windows.Forms.ComboBox cmbMoisTot2;
        private System.Windows.Forms.ComboBox cmbMoisTot1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbAnnee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAnnee2;
        private System.Windows.Forms.Label label4;
    }
}

