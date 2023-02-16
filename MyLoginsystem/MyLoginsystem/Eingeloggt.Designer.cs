
namespace MyLoginSystem
{
    partial class Eingeloggt
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
            this.lblWilkommen = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnStartseite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWilkommen
            // 
            this.lblWilkommen.AutoSize = true;
            this.lblWilkommen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWilkommen.Location = new System.Drawing.Point(238, 47);
            this.lblWilkommen.Name = "lblWilkommen";
            this.lblWilkommen.Size = new System.Drawing.Size(112, 19);
            this.lblWilkommen.TabIndex = 0;
            this.lblWilkommen.Text = "Willkommen: ";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(218, 174);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(339, 29);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Heute steht nichts neues an!";
            // 
            // btnStartseite
            // 
            this.btnStartseite.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartseite.Location = new System.Drawing.Point(293, 247);
            this.btnStartseite.Name = "btnStartseite";
            this.btnStartseite.Size = new System.Drawing.Size(166, 67);
            this.btnStartseite.TabIndex = 2;
            this.btnStartseite.Text = "Abmelden";
            this.btnStartseite.UseVisualStyleBackColor = true;
            this.btnStartseite.Click += new System.EventHandler(this.btnStartseite_Click);
            // 
            // Eingeloggt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStartseite);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblWilkommen);
            this.Name = "Eingeloggt";
            this.Text = "Eingeloggt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWilkommen;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnStartseite;
    }
}