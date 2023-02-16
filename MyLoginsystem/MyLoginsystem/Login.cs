using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace MyLoginSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            ArrayList dateninhalte = new ArrayList();
            if(txbBenutzername.Text == "admin" && txbPasswort.Text == "admin123")
            {
                this.Hide();
                AdminVerwaltung verwaltung = new AdminVerwaltung();
                verwaltung.ShowDialog();
                this.Close();
            }
            StreamReader streamR = new StreamReader("D:\\C#\\MyLoginSystem\\Daten\\Benutzer.txt", Encoding.Default);
            String zeile = streamR.ReadLine();

            while (zeile != null)
            {
                dateninhalte.Add(zeile);
                
                zeile = streamR.ReadLine();
            }
            streamR.Close();

            foreach (string suche in dateninhalte)
            {
                if(suche.Split(',')[2] + suche.Split(',')[4] == txbBenutzername.Text + txbPasswort.Text)
                {
                    lblBenutzername.ForeColor = Color.Black;
                    lblPasswort.ForeColor = Color.Black;
                    lblFehler.Visible = false;
                    this.Hide();
                    Eingeloggt eingeloggt = new Eingeloggt(suche.Split(',')[0] + " " + suche.Split(',')[1]);
                    eingeloggt.ShowDialog();
                    this.Close();
                    continue;
                }
                else
                {
                    
                    lblBenutzername.ForeColor = Color.Red;
                    lblPasswort.ForeColor = Color.Red;
                    lblFehler.Visible = true;
                }
            }
            txbBenutzername.Text = "";
            txbPasswort.Text = "";
        }

        private void btnStartseite_Click(object sender, EventArgs e)
        {
            this.Hide();
            Startseite stSeite = new Startseite();
            stSeite.ShowDialog();
            this.Close();
        }
    }
}
