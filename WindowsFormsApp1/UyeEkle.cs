using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MONSTER\\OneDrive\\Belgeler\\FitnessDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void UyeEkle_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUyeEkle_Ekle_Click(object sender, EventArgs e)
        {
            if (txtUyeEkleAdSoyad.Text =="" || txtUyeEkletutar.Text=="" || txtUyeEkleYas.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Tabloları Doldurunuz");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into UyeTbl values('" + txtUyeEkleAdSoyad.Text + "','" + txtUyeEkleTelefon.Text +  "','" + dtpUyeEkleCinsiyet.SelectedItem.ToString() + "','" + txtUyeEkleYas.Text +"','"+ txtUyeEkletutar.Text +"','" + cmbUyeEkleZamanlama.SelectedItem.ToString() + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla Eklenmiştir");
                    baglanti.Close();
                } 
                catch(Exception ex)
                {
                    MessageBox.Show("ex.Message");
                }
            }
        }
    }
}

//Data Source = .; Initial Catalog = Hafta6; Integrated Security = true