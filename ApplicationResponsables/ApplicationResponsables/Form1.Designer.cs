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
            this.lblDebut = new System.Windows.Forms.Label();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnValidChangerDebut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbllService = new System.Windows.Forms.Label();
            this.lblPeriode = new System.Windows.Forms.Label();
            this.lblPeriode2 = new System.Windows.Forms.Label();
            this.dtDebutPeriode = new System.Windows.Forms.DateTimePicker();
            this.lblPeriod3 = new System.Windows.Forms.Label();
            this.dtFinPeriode = new System.Windows.Forms.DateTimePicker();
            this.btnValidMoisService = new System.Windows.Forms.Button();
            this.btnValidPeriodeService = new System.Windows.Forms.Button();
            this.cmbPatients = new System.Windows.Forms.ComboBox();
            this.cmbServices = new System.Windows.Forms.ComboBox();
            this.cmbMois = new System.Windows.Forms.ComboBox();
            this.cmbServices2 = new System.Windows.Forms.ComboBox();
            this.lblFin = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDebut
            // 
            this.lblDebut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDebut.AutoSize = true;
            this.lblDebut.Location = new System.Drawing.Point(300, 186);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(152, 22);
            this.lblDebut.TabIndex = 2;
            this.lblDebut.Text = "Changer date de fin";
            this.lblDebut.Click += new System.EventHandler(this.lblDebut_Click);
            // 
            // dtpDebut
            // 
            this.dtpDebut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDebut.Location = new System.Drawing.Point(0, 220);
            this.dtpDebut.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpDebut.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(256, 26);
            this.dtpDebut.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbPatients);
            this.groupBox1.Controls.Add(this.btnValidChangerDebut);
            this.groupBox1.Controls.Add(this.lblFin);
            this.groupBox1.Controls.Add(this.dtpFin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpDebut);
            this.groupBox1.Controls.Add(this.lblDebut);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(608, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 543);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Changer la date d\'hospitalisation";
            // 
            // btnValidChangerDebut
            // 
            this.btnValidChangerDebut.Location = new System.Drawing.Point(32, 351);
            this.btnValidChangerDebut.Name = "btnValidChangerDebut";
            this.btnValidChangerDebut.Size = new System.Drawing.Size(169, 62);
            this.btnValidChangerDebut.TabIndex = 6;
            this.btnValidChangerDebut.Text = "Valider date de début";
            this.btnValidChangerDebut.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbMois);
            this.groupBox2.Controls.Add(this.cmbServices);
            this.groupBox2.Controls.Add(this.btnValidMoisService);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblService);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(300, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 543);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Taux d\'occupation des lits par mois pour un service choisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mois : ";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(7, 101);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(80, 22);
            this.lblService.TabIndex = 1;
            this.lblService.Text = "Service : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbServices2);
            this.groupBox3.Controls.Add(this.btnValidPeriodeService);
            this.groupBox3.Controls.Add(this.dtFinPeriode);
            this.groupBox3.Controls.Add(this.lblPeriod3);
            this.groupBox3.Controls.Add(this.dtDebutPeriode);
            this.groupBox3.Controls.Add(this.lblPeriode2);
            this.groupBox3.Controls.Add(this.lblPeriode);
            this.groupBox3.Controls.Add(this.lbllService);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 543);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Taux d\'occupation des lits par période et service choisi";
            // 
            // lbllService
            // 
            this.lbllService.AutoSize = true;
            this.lbllService.Location = new System.Drawing.Point(7, 101);
            this.lbllService.Name = "lbllService";
            this.lbllService.Size = new System.Drawing.Size(80, 22);
            this.lbllService.TabIndex = 0;
            this.lbllService.Text = "Service : ";
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.Location = new System.Drawing.Point(48, 166);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(153, 22);
            this.lblPeriode.TabIndex = 2;
            this.lblPeriode.Text = "Définir la periode : ";
            // 
            // lblPeriode2
            // 
            this.lblPeriode2.AutoSize = true;
            this.lblPeriode2.Location = new System.Drawing.Point(89, 198);
            this.lblPeriode2.Name = "lblPeriode2";
            this.lblPeriode2.Size = new System.Drawing.Size(44, 22);
            this.lblPeriode2.TabIndex = 3;
            this.lblPeriode2.Text = "Du : ";
            // 
            // dtDebutPeriode
            // 
            this.dtDebutPeriode.Location = new System.Drawing.Point(11, 235);
            this.dtDebutPeriode.Name = "dtDebutPeriode";
            this.dtDebutPeriode.Size = new System.Drawing.Size(248, 26);
            this.dtDebutPeriode.TabIndex = 4;
            // 
            // lblPeriod3
            // 
            this.lblPeriod3.AutoSize = true;
            this.lblPeriod3.Location = new System.Drawing.Point(84, 281);
            this.lblPeriod3.Name = "lblPeriod3";
            this.lblPeriod3.Size = new System.Drawing.Size(43, 22);
            this.lblPeriod3.TabIndex = 5;
            this.lblPeriod3.Text = "Au : ";
            // 
            // dtFinPeriode
            // 
            this.dtFinPeriode.Location = new System.Drawing.Point(6, 306);
            this.dtFinPeriode.Name = "dtFinPeriode";
            this.dtFinPeriode.Size = new System.Drawing.Size(248, 26);
            this.dtFinPeriode.TabIndex = 6;
            // 
            // btnValidMoisService
            // 
            this.btnValidMoisService.Location = new System.Drawing.Point(89, 368);
            this.btnValidMoisService.Name = "btnValidMoisService";
            this.btnValidMoisService.Size = new System.Drawing.Size(152, 45);
            this.btnValidMoisService.TabIndex = 7;
            this.btnValidMoisService.Text = "Valider";
            this.btnValidMoisService.UseVisualStyleBackColor = true;
            // 
            // btnValidPeriodeService
            // 
            this.btnValidPeriodeService.Location = new System.Drawing.Point(52, 368);
            this.btnValidPeriodeService.Name = "btnValidPeriodeService";
            this.btnValidPeriodeService.Size = new System.Drawing.Size(152, 45);
            this.btnValidPeriodeService.TabIndex = 7;
            this.btnValidPeriodeService.Text = "Valider";
            this.btnValidPeriodeService.UseVisualStyleBackColor = true;
            // 
            // cmbPatients
            // 
            this.cmbPatients.FormattingEnabled = true;
            this.cmbPatients.Location = new System.Drawing.Point(187, 100);
            this.cmbPatients.Name = "cmbPatients";
            this.cmbPatients.Size = new System.Drawing.Size(140, 30);
            this.cmbPatients.TabIndex = 7;
            // 
            // cmbServices
            // 
            this.cmbServices.FormattingEnabled = true;
            this.cmbServices.Location = new System.Drawing.Point(135, 103);
            this.cmbServices.Name = "cmbServices";
            this.cmbServices.Size = new System.Drawing.Size(143, 30);
            this.cmbServices.TabIndex = 8;
            // 
            // cmbMois
            // 
            this.cmbMois.FormattingEnabled = true;
            this.cmbMois.Location = new System.Drawing.Point(135, 144);
            this.cmbMois.Name = "cmbMois";
            this.cmbMois.Size = new System.Drawing.Size(143, 30);
            this.cmbMois.TabIndex = 9;
            // 
            // cmbServices2
            // 
            this.cmbServices2.FormattingEnabled = true;
            this.cmbServices2.Location = new System.Drawing.Point(88, 101);
            this.cmbServices2.Name = "cmbServices2";
            this.cmbServices2.Size = new System.Drawing.Size(166, 30);
            this.cmbServices2.TabIndex = 9;
            // 
            // lblFin
            // 
            this.lblFin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(6, 186);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(151, 22);
            this.lblFin.TabIndex = 4;
            this.lblFin.Text = "Changer date début";
            // 
            // dtpFin
            // 
            this.dtpFin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFin.Location = new System.Drawing.Point(278, 220);
            this.dtpFin.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpFin.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(252, 26);
            this.dtpFin.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "Valider date de fin";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 557);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tableau de bord";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDebut;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValidChangerDebut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnValidMoisService;
        private System.Windows.Forms.Button btnValidPeriodeService;
        private System.Windows.Forms.DateTimePicker dtFinPeriode;
        private System.Windows.Forms.Label lblPeriod3;
        private System.Windows.Forms.DateTimePicker dtDebutPeriode;
        private System.Windows.Forms.Label lblPeriode2;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.Label lbllService;
        private System.Windows.Forms.ComboBox cmbPatients;
        private System.Windows.Forms.ComboBox cmbServices;
        private System.Windows.Forms.ComboBox cmbMois;
        private System.Windows.Forms.ComboBox cmbServices2;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button button1;
    }
}

