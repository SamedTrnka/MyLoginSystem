using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyLoginSystem
{
    public partial class Startseite : Form
    {
        public Startseite()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
        private void btnRegistrieren_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrierung registrierung = new Registrierung();
            registrierung.ShowDialog();
            this.Close();
        }
    }
}
