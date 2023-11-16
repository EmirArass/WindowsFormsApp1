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
    public partial class UyeleriListele : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MONSTER\\OneDrive\\Belgeler\\FitnessDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void uyeler()
        {
            baglanti.Open();
            string query = "select * from UyeTbl"; // string bir değişken oluşturup bu değişkene sql server verilerini değer olarak atadık

            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti); // Komut Satırı, query ile sorgumuzu yazıp bağlantı ile yetkilendiriyoruz(SqlDataAdapter, verileri almak ve kaydetmek için ve SQL Server arasında bir DataSet köprü görevi görür)
            SqlCommandBuilder builder = new SqlCommandBuilder(); // SqlCommandBuilder belirtilen nesnenin geçerli nesneye eşit olup olmadığını belirler.
            var ds = new DataSet();
            sda.Fill(ds);
            grdUyeleriListele.DataSource = ds.Tables[0]; ;
            baglanti.Close();

        }

        public UyeleriListele()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UyeleriListele_Load(object sender, EventArgs e)
        {
            uyeler();
        }
    }
}
