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
                    string query = "insert into UyeTbl values('" + txtUyeEkleAdSoyad.Text + "','" + txtUyeEkleTelefon.Text +  "','" + cmbUyeEkleCinsiyet.SelectedItem.ToString() + "','" + txtUyeEkleYas.Text +"','"+ txtUyeEkletutar.Text +"','" + cmbUyeEkleZamanlama.SelectedItem.ToString() + "')"; 

                    //SQL sorgumuzu oluşturuyoruz

                    SqlCommand komut = new SqlCommand(query, baglanti); 

                    // Komut Satırı, query ile sorgumuzu yazıp bağlantı ile yetkilendiriyoruz

                    komut.ExecuteNonQuery(); 

                    //katalog işlemlerini gerçekleştirmek (örneğin, veritabanının yapısını sorgulamak veya tablolar gibi veritabanı nesneleri oluşturmak) ya da UPDATE, INSERT veya DELETE deyimlerini yürüterek veritabanındaki verileri kullanmadan DataSet değiştirmek için kullanılır

                    MessageBox.Show("Üye Başarıyla Eklenmiştir");
                    baglanti.Close();

                    txtUyeEkleAdSoyad.Text = "";
                    txtUyeEkleTelefon.Text = "";
                    txtUyeEkletutar.Text = "";
                    txtUyeEkleYas.Text = "";
                    cmbUyeEkleZamanlama.Text = "";
                    cmbUyeEkleCinsiyet.Text = "";
                } 
                catch(Exception ex) 
                // Bazı programlar yazılırken hata vermediği halde çalışma sırasında hata verebilir. Bu hataları kontrol etme işlemine İstisnai Durum Yönetimi (Exception Handling)denir
                {
                    MessageBox.Show("ex.Message");
                }
            }
        }

        private void btnUyeEkleReset_Click(object sender, EventArgs e)
        {
            txtUyeEkleAdSoyad.Text = "";
            txtUyeEkleTelefon.Text = "";
            txtUyeEkletutar.Text = "";
            txtUyeEkleYas.Text = "";
            cmbUyeEkleZamanlama.Text = "";
            cmbUyeEkleCinsiyet.Text = "";
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}