using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Odemeler : Form
    {
        public Odemeler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MONSTER\\OneDrive\\Belgeler\\FitnessDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void uyeler()
        {
            baglanti.Open();
            string query = "select * from OdemeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dgOdemeler.DataSource = ds.Tables[0]; ;
            baglanti.Close();
        }

        private void OdemeFiltreleme()
        {
            baglanti.Open();
            string query = "select * from OdemeTbl where OdemeUye like '%"+ txtOdemeAra.Text +"%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();    
            var ds = new DataSet();
            sda.Fill(ds);
            dgOdemeler.DataSource = ds.Tables[0]; ;
            baglanti.Close();
        }

        private void FillName()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select UyeAdsoyad from UyeTbl", baglanti);
            SqlDataReader rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("UyeAdsoyad", typeof(string));
            dt.Load(rdr);
            cmbOdemeAdSoyad.ValueMember = "UyeAdsoyad";
            cmbOdemeAdSoyad.DataSource = dt;
            baglanti.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void btnOdemeReset_Click(object sender, EventArgs e)
        {
            cmbOdemeAdSoyad.Text = "";
            txtOdemeUcret.Text = "";        
        }

        private void Odemeler_Load(object sender, EventArgs e)
        {
            FillName();
            uyeler();
        }

        private void btnOdeme_Odeme_Click(object sender, EventArgs e)
        {
            if (cmbOdemeAdSoyad.Text == "" || txtOdemeUcret.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz");
            }

            else 
            {
                string odemeperiyot = dtpOdeme_OdemeAyı.Value.Month.ToString() + dtpOdeme_OdemeAyı.Value.Year.ToString();
                baglanti.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from OdemeTbl where OdemeUye='" + cmbOdemeAdSoyad.SelectedValue.ToString() + "' and OdemeAy='"+ odemeperiyot + "'", baglanti);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString()== "1")
                {
                    MessageBox.Show("Zaten Ödeme Yapıldı");
                }

                else
                {
                    string query = "insert into OdemeTbl values('" + odemeperiyot + "','" + cmbOdemeAdSoyad.SelectedValue.ToString() + "','" + txtOdemeUcret.Text + "')";
                    SqlCommand komut = new SqlCommand(query,baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Ödeme İşlemi Başarıyla Gerçekleşti");
                }
                baglanti.Close();
                uyeler();
            }
        }

        private void dgOdemeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOdemeAra_Click(object sender, EventArgs e)
        {
            OdemeFiltreleme();
            txtOdemeAra.Text = "";
        }
    }
}
