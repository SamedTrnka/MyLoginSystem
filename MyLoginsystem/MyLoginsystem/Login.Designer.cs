
namespace MyLoginSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txbBenutzername = new System.Windows.Forms.TextBox();
            this.txbPasswort = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblBenutzername = new System.Windows.Forms.Label();
            this.lblPasswort = new System.Windows.Forms.Label();
            this.lblFehler = new System.Windows.Forms.Label();
            this.lblÜberschrift = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStartseite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbBenutzername
            // 
            this.txbBenutzername.Location = new System.Drawing.Point(243, 156);
            this.txbBenutzername.Name = "txbBenutzername";
            this.txbBenutzername.Size = new System.Drawing.Size(179, 20);
            this.txbBenutzername.TabIndex = 0;
            // 
            // txbPasswort
            // 
            this.txbPasswort.Location = new System.Drawing.Point(243, 212);
            this.txbPasswort.Name = "txbPasswort";
            this.txbPasswort.Size = new System.Drawing.Size(179, 20);
            this.txbPasswort.TabIndex = 1;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.Location = new System.Drawing.Point(243, 250);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(178, 40);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Einloggen";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblBenutzername
            // 
            this.lblBenutzername.AutoSize = true;
            this.lblBenutzername.Location = new System.Drawing.Point(243, 140);
            this.lblBenutzername.Name = "lblBenutzername";
            this.lblBenutzername.Size = new System.Drawing.Size(78, 13);
            this.lblBenutzername.TabIndex = 3;
            this.lblBenutzername.Text = "Benutzername:";
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.Location = new System.Drawing.Point(243, 197);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(53, 13);
            this.lblPasswort.TabIndex = 4;
            this.lblPasswort.Text = "Passwort:";
            // 
            // lblFehler
            // 
            this.lblFehler.AutoSize = true;
            this.lblFehler.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblFehler.ForeColor = System.Drawing.Color.Red;
            this.lblFehler.Location = new System.Drawing.Point(103, 309);
            this.lblFehler.Name = "lblFehler";
            this.lblFehler.Size = new System.Drawing.Size(538, 19);
            this.lblFehler.TabIndex = 5;
            this.lblFehler.Text = "Fehler! Benutzername/Passwort falsch. Bitte versuchen Sie es erneut.";
            this.lblFehler.Visible = false;
            // 
            // lblÜberschrift
            // 
            this.lblÜberschrift.AutoSize = true;
            this.lblÜberschrift.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblÜberschrift.Location = new System.Drawing.Point(291, 38);
            this.lblÜberschrift.Name = "lblÜberschrift";
            this.lblÜberschrift.Size = new System.Drawing.Size(91, 32);
            this.lblÜberschrift.TabIndex = 6;
            this.lblÜberschrift.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 56);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnStartseite
            // 
            this.btnStartseite.Location = new System.Drawing.Point(611, 360);
            this.btnStartseite.Name = "btnStartseite";
            this.btnStartseite.Size = new System.Drawing.Size(64, 20);
            this.btnStartseite.TabIndex = 8;
            this.btnStartseite.Text = "zurück";
            this.btnStartseite.UseVisualStyleBackColor = true;
            this.btnStartseite.Click += new System.EventHandler(this.btnStartseite_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.btnStartseite);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblÜberschrift);
            this.Controls.Add(this.lblFehler);
            this.Controls.Add(this.lblPasswort);
            this.Controls.Add(this.lblBenutzername);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txbPasswort);
            this.Controls.Add(this.txbBenutzername);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbBenutzername;
        private System.Windows.Forms.TextBox txbPasswort;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblBenutzername;
        private System.Windows.Forms.Label lblPasswort;
        private System.Windows.Forms.Label lblFehler;
        private System.Windows.Forms.Label lblÜberschrift;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStartseite;
    }
}