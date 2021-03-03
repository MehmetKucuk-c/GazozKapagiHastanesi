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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        protected bool suruklensinMi = false;
        protected Point ilkKonumAl;


        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void PanelSide(Button Btn)
        {
            SidePanel.Top = Btn.Top;
            SidePanel.Left = Btn.Left - 15;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BrnRaandevu_Click(object sender, EventArgs e)
        {
            PanelSide(BrnRaandevu);
            userHasta1.BringToFront();
        }

        private void BtnDenme_Click(object sender, EventArgs e)
        {
            PanelSide(BtnDenme);
            userDeneme1.BringToFront();
        }

        private void ButtonPanel_MouseDown(object sender, MouseEventArgs e)
        {
            suruklensinMi = true;
            ilkKonumAl = e.Location;
        }

        private void ButtonPanel_MouseUp(object sender, MouseEventArgs e)
        {
            suruklensinMi = false;
        }

        private void ButtonPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklensinMi)
            {
                this.Left = e.X + this.Left - (ilkKonumAl.X);
                this.Top = e.Y + this.Top - (ilkKonumAl.Y);
            }
        }
    }
}
