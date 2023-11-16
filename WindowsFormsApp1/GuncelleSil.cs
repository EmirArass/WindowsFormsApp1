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
using System.Data.Sql;

namespace WindowsFormsApp1
{
    public partial class GuncelleSil : Form
    {
        public GuncelleSil()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MONSTER\\OneDrive\\Belgeler\\FitnessDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void uyeler()
        {
            baglanti.Open();
            string query = "select * from UyeTbl"; // string bir değişken oluşturup bu değişkene sql server verilerini değer olarak atadık

            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti); // Komut Satırı, query ile sorgumuzu yazıp bağlantı ile yetkilendiriyoruz(SqlDataAdapter, verileri almak ve kaydetmek için ve SQL Server arasında bir DataSet köprü görevi görür)
            SqlCommandBuilder builder = new SqlCommandBuilder(); // SqlCommandBuilder belirtilen nesnenin geçerli nesneye eşit olup olmadığını belirler.
            var ds = new DataSet();
            sda.Fill(ds);
            grdGuncelleSil.DataSource = ds.Tables[0]; ;
            baglanti.Close();

        }

        
        void reset()
        {
            txtGuncelleSilUyeAdSoyad.Text = "";
            txtGuncelleSilTelefon.Text = "";
            txtGuncelleYas.Text = "";
            cmbGuncelleZamanlama.Text = "";
            cmbGuncelleCinsiyet.SelectedItem = "";
            txtGuncelleTutar.Text = "";
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

        private void GuncelleSil_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        int key = 0;
        private void grdGuncelleSil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(grdGuncelleSil.SelectedRows[0].Cells[0].Value.ToString());
            txtGuncelleSilUyeAdSoyad.Text = grdGuncelleSil.SelectedRows[0].Cells[1].Value.ToString();
            txtGuncelleSilTelefon.Text = grdGuncelleSil.SelectedRows[0].Cells[2].Value.ToString();
            cmbGuncelleCinsiyet.Text = grdGuncelleSil.SelectedRows[0].Cells[3].Value.ToString();
            txtGuncelleYas.Text = grdGuncelleSil.SelectedRows[0].Cells[4].Value.ToString();
            txtGuncelleTutar.Text = grdGuncelleSil.SelectedRows[0].Cells[5].Value.ToString();
            cmbGuncelleZamanlama.Text = grdGuncelleSil.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnGuncelleReset_Click(object sender, EventArgs e)
        {
            txtGuncelleSilUyeAdSoyad.Text = "";
            txtGuncelleSilTelefon.Text = "";
            txtGuncelleTutar.Text = "";
            txtGuncelleYas.Text = "";
            cmbGuncelleCinsiyet.SelectedItem = "";
            cmbGuncelleZamanlama.SelectedItem = "";
        }

        private void btnGuncelle_Sil_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek Üyeyi Seçiniz");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from UyeTbl where UyeId=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla Silindi");
                    baglanti.Close();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnGuncelle_Guncelle_Click(object sender, EventArgs e)
        {
            if (key == 0 || txtGuncelleSilUyeAdSoyad.Text == "" || txtGuncelleSilTelefon.Text == "" || txtGuncelleTutar.Text == "" || txtGuncelleYas.Text == "" || cmbGuncelleCinsiyet.Text == "" || cmbGuncelleZamanlama.Text == "")
            {
                MessageBox.Show("Silinecek Üyeyi Seçiniz");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update UyeTbl set UyeAdsoyad='" + txtGuncelleSilUyeAdSoyad.Text + "',UyeTelefon='" + txtGuncelleSilTelefon.Text + "',UyeCinsiyet='" + cmbGuncelleCinsiyet.SelectedItem.ToString() + "',UyeYas='" + txtGuncelleYas.Text + "',UyeOdeme='" + txtGuncelleTutar.Text + "',UyeZamanlama='" + cmbGuncelleZamanlama.SelectedItem.ToString() + "' where UyeId=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla Güncellendi");
                    baglanti.Close();
                    uyeler();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
