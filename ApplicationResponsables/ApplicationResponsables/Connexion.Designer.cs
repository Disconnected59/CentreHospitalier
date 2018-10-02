namespace ApplicationResponsables
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnValiderConnexion = new System.Windows.Forms.Button();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtBoxMdp = new System.Windows.Forms.TextBox();
            this.txtBoxLabel = new System.Windows.Forms.TextBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.lblerror);
            this.groupBox4.Controls.Add(this.btnValiderConnexion);
            this.groupBox4.Controls.Add(this.lblMdp);
            this.groupBox4.Controls.Add(this.lblLogin);
            this.groupBox4.Controls.Add(this.txtBoxMdp);
            this.groupBox4.Controls.Add(this.txtBoxLabel);
            this.groupBox4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(25, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(536, 116);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vous êtes administrateur? Connectez vous !";
            // 
            // btnValiderConnexion
            // 
            this.btnValiderConnexion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnValiderConnexion.Location = new System.Drawing.Point(320, 35);
            this.btnValiderConnexion.Name = "btnValiderConnexion";
            this.btnValiderConnexion.Size = new System.Drawing.Size(152, 45);
            this.btnValiderConnexion.TabIndex = 10;
            this.btnValiderConnexion.Text = "Valider";
            this.btnValiderConnexion.UseVisualStyleBackColor = true;
            this.btnValiderConnexion.Click += new System.EventHandler(this.btnValiderConnexion_Click);
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
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.DarkRed;
            this.lblerror.Location = new System.Drawing.Point(264, 83);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 13);
            this.lblerror.TabIndex = 11;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ApplicationResponsables.Properties.Resources.secureFond;
            this.ClientSize = new System.Drawing.Size(584, 162);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnValiderConnexion;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtBoxMdp;
        private System.Windows.Forms.TextBox txtBoxLabel;
        private System.Windows.Forms.Label lblerror;
    }
}