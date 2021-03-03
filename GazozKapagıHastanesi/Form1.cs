using GazozKapagıHastanesi.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazozKapagıHastanesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AnaEkran anaEkran = new AnaEkran();

        private void Kapatma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnGiriş_Click(object sender, EventArgs e)
        {
            anaEkran.Show();
            this.Hide();
        }

        private void Txt_Sifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnGiriş_Click(null, null);
            }
        }
    }
}
