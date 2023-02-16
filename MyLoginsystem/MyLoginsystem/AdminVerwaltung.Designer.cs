
namespace MyLoginSystem
{
    partial class AdminVerwaltung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminVerwaltung));
            this.lbxAuswahl = new System.Windows.Forms.ListBox();
            this.btnAuswahl = new System.Windows.Forms.Button();
            this.txbVorname = new System.Windows.Forms.TextBox();
            this.txbNachname = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbBenutzername = new System.Windows.Forms.TextBox();
            this.txbPasswort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBenutzerSpeichern = new System.Windows.Forms.Button();
            this.btnBenutzerlöschen = new System.Windows.Forms.Button();
            this.btnStartseite = new System.Windows.Forms.Button();
            this.lblÜberschrift = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxAuswahl
            // 
            this.lbxAuswahl.FormattingEnabled = true;
            this.lbxAuswahl.Location = new System.Drawing.Point(10, 10);
            this.lbxAuswahl.Name = "lbxAuswahl";
            this.lbxAuswahl.Size = new System.Drawing.Size(205, 329);
            this.lbxAuswahl.TabIndex = 0;
            this.lbxAuswahl.SelectedIndexChanged += new System.EventHandler(this.lbxAuswahl_SelectedIndexChanged);
            // 
            // btnAuswahl
            // 
            this.btnAuswahl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAuswahl.Location = new System.Drawing.Point(26, 345);
            this.btnAuswahl.Name = "btnAuswahl";
            this.btnAuswahl.Size = new System.Drawing.Size(169, 26);
            this.btnAuswahl.TabIndex = 1;
            this.btnAuswahl.Text = "Datei auswählen";
            this.btnAuswahl.UseVisualStyleBackColor = true;
            this.btnAuswahl.Click += new System.EventHandler(this.btnAuswahl_Click);
            // 
            // txbVorname
            // 
            this.txbVorname.Location = new System.Drawing.Point(328, 85);
            this.txbVorname.Name = "txbVorname";
            this.txbVorname.Size = new System.Drawing.Size(205, 20);
            this.txbVorname.TabIndex = 2;
            // 
            // txbNachname
            // 
            this.txbNachname.Location = new System.Drawing.Point(328, 129);
            this.txbNachname.Name = "txbNachname";
            this.txbNachname.Size = new System.Drawing.Size(205, 20);
            this.txbNachname.TabIndex = 3;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(328, 218);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(205, 20);
            this.txbEmail.TabIndex = 5;
            // 
            // txbBenutzername
            // 
            this.txbBenutzername.Location = new System.Drawing.Point(328, 173);
            this.txbBenutzername.Name = "txbBenutzername";
            this.txbBenutzername.Size = new System.Drawing.Size(205, 20);
            this.txbBenutzername.TabIndex = 4;
            // 
            // txbPasswort
            // 
            this.txbPasswort.Location = new System.Drawing.Point(328, 259);
            this.txbPasswort.Name = "txbPasswort";
            this.txbPasswort.Size = new System.Drawing.Size(205, 20);
            this.txbPasswort.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vorname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nachname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Benutzername:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Passwort:";
            // 
            // btnBenutzerSpeichern
            // 
            this.btnBenutzerSpeichern.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBenutzerSpeichern.Location = new System.Drawing.Point(328, 309);
            this.btnBenutzerSpeichern.Name = "btnBenutzerSpeichern";
            this.btnBenutzerSpeichern.Size = new System.Drawing.Size(153, 30);
            this.btnBenutzerSpeichern.TabIndex = 12;
            this.btnBenutzerSpeichern.Text = "Änderungen speichern";
            this.btnBenutzerSpeichern.UseVisualStyleBackColor = true;
            this.btnBenutzerSpeichern.Click += new System.EventHandler(this.btnBenutzerSpeichern_Click);
            // 
            // btnBenutzerlöschen
            // 
            this.btnBenutzerlöschen.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBenutzerlöschen.Location = new System.Drawing.Point(328, 349);
            this.btnBenutzerlöschen.Name = "btnBenutzerlöschen";
            this.btnBenutzerlöschen.Size = new System.Drawing.Size(153, 30);
            this.btnBenutzerlöschen.TabIndex = 13;
            this.btnBenutzerlöschen.Text = "Benutzer löschen";
            this.btnBenutzerlöschen.UseVisualStyleBackColor = true;
            this.btnBenutzerlöschen.Click += new System.EventHandler(this.btnBenutzerlöschen_Click);
            // 
            // btnStartseite
            // 
            this.btnStartseite.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnStartseite.Location = new System.Drawing.Point(536, 349);
            this.btnStartseite.Name = "btnStartseite";
            this.btnStartseite.Size = new System.Drawing.Size(127, 30);
            this.btnStartseite.TabIndex = 14;
            this.btnStartseite.Text = "Startseite";
            this.btnStartseite.UseVisualStyleBackColor = true;
            this.btnStartseite.Click += new System.EventHandler(this.btnStartseite_Click);
            // 
            // lblÜberschrift
            // 
            this.lblÜberschrift.AutoSize = true;
            this.lblÜberschrift.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblÜberschrift.Location = new System.Drawing.Point(262, 10);
            this.lblÜberschrift.Name = "lblÜberschrift";
            this.lblÜberschrift.Size = new System.Drawing.Size(257, 32);
            this.lblÜberschrift.TabIndex = 15;
            this.lblÜberschrift.Text = "Admin Verwaltung";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(579, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 104);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // AdminVerwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblÜberschrift);
            this.Controls.Add(this.btnStartseite);
            this.Controls.Add(this.btnBenutzerlöschen);
            this.Controls.Add(this.btnBenutzerSpeichern);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPasswort);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbBenutzername);
            this.Controls.Add(this.txbNachname);
            this.Controls.Add(this.txbVorname);
            this.Controls.Add(this.btnAuswahl);
            this.Controls.Add(this.lbxAuswahl);
            this.Name = "AdminVerwaltung";
            this.Text = "AdminVerwaltung";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAuswahl;
        private System.Windows.Forms.Button btnAuswahl;
        private System.Windows.Forms.TextBox txbVorname;
        private System.Windows.Forms.TextBox txbNachname;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbBenutzername;
        private System.Windows.Forms.TextBox txbPasswort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBenutzerSpeichern;
        private System.Windows.Forms.Button btnBenutzerlöschen;
        private System.Windows.Forms.Button btnStartseite;
        private System.Windows.Forms.Label lblÜberschrift;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}