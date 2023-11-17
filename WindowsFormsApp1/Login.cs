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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoginReset_Click(object sender, EventArgs e)
        {
            txtLoginPassword.Text = "";
            txtLogin_Login.Text = "";
        }

        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin_Login.Text == "" || txtLoginPassword.Text== "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı Ve Şifre giriniz");
            }

            else if (txtLoginPassword.Text == "123456789" && txtLogin_Login.Text == "admin")
            {
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalıdır");
            }
        }
    }
}
