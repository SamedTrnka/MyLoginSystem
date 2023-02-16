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
    public partial class AdminVerwaltung : Form
    {

        public AdminVerwaltung()
        {
            InitializeComponent();
        }
        private List<Benutzer> benutzerliste = new List<Benutzer>();
        public ArrayList datensätze = new ArrayList();
        private string dateipfad = string.Empty;
        private void btnAuswahl_Click(object sender, EventArgs e)
        {
            lbxAuswahl.Items.Clear();
            var dateiInhalt = string.Empty;
            OpenFileDialog auswahl = new OpenFileDialog();

            auswahl.InitialDirectory = "D:\\C#\\MyLoginSystem";
            auswahl.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            auswahl.FilterIndex = 2;
            auswahl.RestoreDirectory = true;

            if (auswahl.ShowDialog() == DialogResult.OK)
            {
                dateipfad = auswahl.FileName;

                var datenfluss = auswahl.OpenFile();

                using (StreamReader reader = new StreamReader(datenfluss))
                {
                    dateiInhalt = reader.ReadToEnd();
                }
            }
            lbxAuswahl.Items.Clear();

            StreamReader streamR = new StreamReader(dateipfad, Encoding.Default);
            String zeile = streamR.ReadLine();
            while (zeile != null && zeile != "")
            {
                lbxAuswahl.Items.Add(zeile.Split(',')[0] + " " + zeile.Split(',')[1]);
                datensätze.Add(zeile);
                zeile = streamR.ReadLine();
            }
            streamR.Close();
            
            foreach (string datensatz in datensätze){
                if (datensatz != null)
                {
                    benutzerliste.Add(new Benutzer(datensatz));
                }  
            }
        }

        private void lbxAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxAuswahl.SelectedIndex > -1)
            {
                Benutzer benutzer = benutzerliste[lbxAuswahl.SelectedIndex];
                txbVorname.Text = benutzer.vorname;
                txbNachname.Text = benutzer.nachname;
                txbBenutzername.Text = benutzer.benutzername;
                txbEmail.Text = benutzer.email;
                txbPasswort.Text = benutzer.passwort;
            }
        }
        private void btnBenutzerSpeichern_Click(object sender, EventArgs e)
        {
            Benutzer benutzer = benutzerliste[lbxAuswahl.SelectedIndex];
            benutzer.vorname = txbVorname.Text;
            benutzer.nachname = txbNachname.Text;
            benutzer.benutzername = txbBenutzername.Text;
            benutzer.email = txbEmail.Text;
            benutzer.passwort = txbPasswort.Text;

            String newDatensatz = txbVorname.Text + "," + txbNachname.Text + "," + txbBenutzername.Text + "," + txbEmail.Text + "," + txbPasswort.Text;
            lbxAuswahl.Items[lbxAuswahl.SelectedIndex] = txbVorname.Text + " " + txbNachname.Text;
            datensätze[lbxAuswahl.SelectedIndex] = newDatensatz;

            using (TextWriter writer = File.CreateText(dateipfad))
            {
                foreach (string datensatz in datensätze)
                {
                    writer.WriteLine(datensatz);
                }
            }
        }
        private void btnBenutzerlöschen_Click(object sender, EventArgs e)
        {
            datensätze.RemoveAt(lbxAuswahl.SelectedIndex);
            benutzerliste.RemoveAt(lbxAuswahl.SelectedIndex);
            lbxAuswahl.Items.Remove(lbxAuswahl.SelectedItem);
            
            using (TextWriter writer = File.CreateText(dateipfad))
            {
                foreach (string datensatz in datensätze)
                {
                    writer.WriteLine(datensatz);
                }
            }
            lbxAuswahl.SelectedIndex = 0;
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
