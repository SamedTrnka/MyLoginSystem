using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace MyLoginSystem
{
    public partial class Registrierung : Form
    {
        ArrayList dateninhalte = new ArrayList();
        public Registrierung()
        {
            InitializeComponent();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
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
                if (suche.Split(',')[2] == txbBenutzername.Text)
                {
                    txbBenutzername.Text = "";
                    lblBenutzername.ForeColor = Color.Red;
                    lblFehler.Visible = true;
                }
            }
            FileStream fileS;
            StreamWriter streamW;
            String dataName = "Benutzer.txt";
            String directory = "F:\\C#\\MyLoginSystem\\Daten";
            String dataSet = txbVorname.Text.Trim() + "," + txbNachname.Text.Trim() + "," + txbBenutzername.Text.Trim() + "," + txbEmail.Text.Trim() + "," + txbPasswort.Text.Trim(); 

            fileS = new FileStream(directory + "\\" + dataName, FileMode.Append);
            streamW = new StreamWriter(fileS);

            if (txbEmail.Text == txbEmailCheck.Text)
            {
                if (txbPasswort.Text == txbPasswortCheck.Text)
                {
                    lblPasswort.ForeColor = Color.Black;
                    lblEmail.ForeColor = Color.Black;
                    
                    if (!dataSet.Contains(",,") && txbVorname.Text != string.Empty && txbEmail.Text != string.Empty)
                    {
                        streamW.WriteLine(dataSet);
                        streamW.Close();
                        this.Hide();
                        Startseite stSeite = new Startseite();
                        stSeite.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    lblEmail.ForeColor = Color.Black;
                    lblPasswort.ForeColor = Color.Red;
                    txbPasswortCheck.Text = string.Empty;
                }
            }
            else if (txbPasswort.Text == txbPasswortCheck.Text)
            {
                lblPasswort.ForeColor = Color.Black;
                lblEmail.ForeColor = Color.Red;
                txbEmailCheck.Text = string.Empty;
            }
            else
            {
                lblEmail.ForeColor = Color.Red;
                txbEmailCheck.Text = string.Empty;
                lblPasswort.ForeColor = Color.Red;
                txbPasswortCheck.Text = string.Empty;
            }
            streamW.Close();
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
