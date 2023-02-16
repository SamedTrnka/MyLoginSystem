using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyLoginSystem
{
    public partial class Eingeloggt : Form
    {
        public Eingeloggt(string newData)
        {
            InitializeComponent();
            lblWilkommen.Text = lblWilkommen.Text +" "+ newData;
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
