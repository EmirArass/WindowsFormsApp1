using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAnasayfaUyeEkle_Click(object sender, EventArgs e)
        {
            UyeEkle uyeekle = new UyeEkle();
            uyeekle.Show();
            this.Hide();
        }

        private void btnAnasayfaGuncelle_Click(object sender, EventArgs e)
        {
            GuncelleSil guncelleSil = new GuncelleSil();
            guncelleSil.Show();
            this.Hide();
        }

        private void btnAnasayfaOde_Click(object sender, EventArgs e)
        {
            Odemeler odeme = new Odemeler();
            odeme.Show();
            this.Hide();
        }

        private void btnAnsayfaUyeGoster_Click(object sender, EventArgs e)
        {
            UyeleriListele uyeleriListele = new UyeleriListele();
            uyeleriListele.Show();
            this.Hide();
        }
    }
}
