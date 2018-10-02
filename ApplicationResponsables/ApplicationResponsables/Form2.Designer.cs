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
            this.btnvalider = new System.Windows.Forms.Button();
            this.cbboxService = new System.Windows.Forms.ComboBox();
            this.cbboxMois = new System.Windows.Forms.ComboBox();
            this.lblPeriode = new System.Windows.Forms.Label();
            this.lblMois = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblduree = new System.Windows.Forms.Label();
            this.dtpdebut = new System.Windows.Forms.DateTimePicker();
            this.dtpfin = new System.Windows.Forms.DateTimePicker();
            this.lblau = new System.Windows.Forms.Label();
            this.btnValiderMois = new System.Windows.Forms.Button();
            this.dureemoy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dureemoy
            // 
            this.dureemoy.Controls.Add(this.btnValiderMois);
            this.dureemoy.Controls.Add(this.lblau);
            this.dureemoy.Controls.Add(this.dtpfin);
            this.dureemoy.Controls.Add(this.dtpdebut);
            this.dureemoy.Controls.Add(this.lblduree);
            this.dureemoy.Controls.Add(this.btnvalider);
            this.dureemoy.Controls.Add(this.cbboxService);
            this.dureemoy.Controls.Add(this.cbboxMois);
            this.dureemoy.Controls.Add(this.lblPeriode);
            this.dureemoy.Controls.Add(this.lblMois);
            this.dureemoy.Controls.Add(this.lblService);
            this.dureemoy.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.dureemoy.Location = new System.Drawing.Point(-1, -1);
            this.dureemoy.Name = "dureemoy";
            this.dureemoy.Size = new System.Drawing.Size(950, 469);
            this.dureemoy.TabIndex = 0;
            this.dureemoy.TabStop = false;
            this.dureemoy.Text = "Durée moyenne de séjour";
            this.dureemoy.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnvalider
            // 
            this.btnvalider.Location = new System.Drawing.Point(107, 332);
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
            this.cbboxService.Location = new System.Drawing.Point(107, 76);
            this.cbboxService.Name = "cbboxService";
            this.cbboxService.Size = new System.Drawing.Size(121, 30);
            this.cbboxService.TabIndex = 5;
            // 
            // cbboxMois
            // 
            this.cbboxMois.FormattingEnabled = true;
            this.cbboxMois.Location = new System.Drawing.Point(107, 145);
            this.cbboxMois.Name = "cbboxMois";
            this.cbboxMois.Size = new System.Drawing.Size(121, 30);
            this.cbboxMois.TabIndex = 3;
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.Location = new System.Drawing.Point(15, 234);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(94, 22);
            this.lblPeriode.TabIndex = 2;
            this.lblPeriode.Text = "Période: du";
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
            // lblduree
            // 
            this.lblduree.AutoSize = true;
            this.lblduree.Location = new System.Drawing.Point(6, 192);
            this.lblduree.Name = "lblduree";
            this.lblduree.Size = new System.Drawing.Size(574, 22);
            this.lblduree.TabIndex = 8;
            this.lblduree.Text = "Veuillez valider le mois avec le bouton \"valider mois\" avant d\'entrer la période";
            this.lblduree.Click += new System.EventHandler(this.lblduree_Click);
            // 
            // dtpdebut
            // 
            this.dtpdebut.Location = new System.Drawing.Point(107, 230);
            this.dtpdebut.Name = "dtpdebut";
            this.dtpdebut.Size = new System.Drawing.Size(245, 26);
            this.dtpdebut.TabIndex = 9;
            // 
            // dtpfin
            // 
            this.dtpfin.Location = new System.Drawing.Point(107, 287);
            this.dtpfin.Name = "dtpfin";
            this.dtpfin.Size = new System.Drawing.Size(245, 26);
            this.dtpfin.TabIndex = 10;
            // 
            // lblau
            // 
            this.lblau.AutoSize = true;
            this.lblau.Location = new System.Drawing.Point(83, 291);
            this.lblau.Name = "lblau";
            this.lblau.Size = new System.Drawing.Size(26, 22);
            this.lblau.TabIndex = 11;
            this.lblau.Text = "au";
            // 
            // btnValiderMois
            // 
            this.btnValiderMois.Location = new System.Drawing.Point(264, 146);
            this.btnValiderMois.Name = "btnValiderMois";
            this.btnValiderMois.Size = new System.Drawing.Size(137, 29);
            this.btnValiderMois.TabIndex = 12;
            this.btnValiderMois.Text = "Valider Mois";
            this.btnValiderMois.UseVisualStyleBackColor = true;
            this.btnValiderMois.Click += new System.EventHandler(this.btnValiderMois_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 466);
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
        private System.Windows.Forms.Label lblduree;
        private System.Windows.Forms.Label lblau;
        private System.Windows.Forms.DateTimePicker dtpfin;
        private System.Windows.Forms.DateTimePicker dtpdebut;
        private System.Windows.Forms.Button btnValiderMois;
    }
}