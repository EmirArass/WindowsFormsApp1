namespace WindowsFormsApp1
{
    partial class UyeEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUyeEkleAdSoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUyeEkleTelefon = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUyeEkleYas = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpUyeEkleCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUyeEkletutar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUyeEkleZamanlama = new System.Windows.Forms.ComboBox();
            this.btnUyeEkle_Ekle = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUyeEkleReset = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUyeEkleGeri = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGeri = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(10)))), ((int)(((byte)(155)))));
            this.label1.Location = new System.Drawing.Point(447, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 47);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fitness Center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(282, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Üye Ad Soyad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUyeEkleAdSoyad
            // 
            this.txtUyeEkleAdSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUyeEkleAdSoyad.DefaultText = "";
            this.txtUyeEkleAdSoyad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUyeEkleAdSoyad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUyeEkleAdSoyad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUyeEkleAdSoyad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUyeEkleAdSoyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUyeEkleAdSoyad.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtUyeEkleAdSoyad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUyeEkleAdSoyad.Location = new System.Drawing.Point(282, 176);
            this.txtUyeEkleAdSoyad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUyeEkleAdSoyad.Name = "txtUyeEkleAdSoyad";
            this.txtUyeEkleAdSoyad.PasswordChar = '\0';
            this.txtUyeEkleAdSoyad.PlaceholderText = "";
            this.txtUyeEkleAdSoyad.SelectedText = "";
            this.txtUyeEkleAdSoyad.Size = new System.Drawing.Size(170, 28);
            this.txtUyeEkleAdSoyad.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(502, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefon Numarası";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUyeEkleTelefon
            // 
            this.txtUyeEkleTelefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUyeEkleTelefon.DefaultText = "";
            this.txtUyeEkleTelefon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUyeEkleTelefon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUyeEkleTelefon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUyeEkleTelefon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUyeEkleTelefon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUyeEkleTelefon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUyeEkleTelefon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUyeEkleTelefon.Location = new System.Drawing.Point(502, 176);
            this.txtUyeEkleTelefon.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUyeEkleTelefon.Name = "txtUyeEkleTelefon";
            this.txtUyeEkleTelefon.PasswordChar = '\0';
            this.txtUyeEkleTelefon.PlaceholderText = "";
            this.txtUyeEkleTelefon.SelectedText = "";
            this.txtUyeEkleTelefon.Size = new System.Drawing.Size(170, 28);
            this.txtUyeEkleTelefon.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(734, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yaş";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUyeEkleYas
            // 
            this.txtUyeEkleYas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUyeEkleYas.DefaultText = "";
            this.txtUyeEkleYas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUyeEkleYas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUyeEkleYas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUyeEkleYas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUyeEkleYas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUyeEkleYas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUyeEkleYas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUyeEkleYas.Location = new System.Drawing.Point(734, 176);
            this.txtUyeEkleYas.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUyeEkleYas.Name = "txtUyeEkleYas";
            this.txtUyeEkleYas.PasswordChar = '\0';
            this.txtUyeEkleYas.PlaceholderText = "";
            this.txtUyeEkleYas.SelectedText = "";
            this.txtUyeEkleYas.Size = new System.Drawing.Size(170, 28);
            this.txtUyeEkleYas.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(278, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cinsiyet";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpUyeEkleCinsiyet
            // 
            this.dtpUyeEkleCinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(4)))), ((int)(((byte)(224)))));
            this.dtpUyeEkleCinsiyet.FormattingEnabled = true;
            this.dtpUyeEkleCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.dtpUyeEkleCinsiyet.Location = new System.Drawing.Point(282, 281);
            this.dtpUyeEkleCinsiyet.Name = "dtpUyeEkleCinsiyet";
            this.dtpUyeEkleCinsiyet.Size = new System.Drawing.Size(170, 24);
            this.dtpUyeEkleCinsiyet.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(502, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Aylık Tutar";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUyeEkletutar
            // 
            this.txtUyeEkletutar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUyeEkletutar.DefaultText = "";
            this.txtUyeEkletutar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUyeEkletutar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUyeEkletutar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUyeEkletutar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUyeEkletutar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUyeEkletutar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUyeEkletutar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUyeEkletutar.Location = new System.Drawing.Point(502, 277);
            this.txtUyeEkletutar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUyeEkletutar.Name = "txtUyeEkletutar";
            this.txtUyeEkletutar.PasswordChar = '\0';
            this.txtUyeEkletutar.PlaceholderText = "";
            this.txtUyeEkletutar.SelectedText = "";
            this.txtUyeEkletutar.Size = new System.Drawing.Size(170, 28);
            this.txtUyeEkletutar.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(734, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Zamanlama";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbUyeEkleZamanlama
            // 
            this.cmbUyeEkleZamanlama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(4)))), ((int)(((byte)(224)))));
            this.cmbUyeEkleZamanlama.FormattingEnabled = true;
            this.cmbUyeEkleZamanlama.Items.AddRange(new object[] {
            "06:00-08:00",
            "08:00-10:00",
            "18:00-20:00",
            "20:00-22:00"});
            this.cmbUyeEkleZamanlama.Location = new System.Drawing.Point(734, 281);
            this.cmbUyeEkleZamanlama.Name = "cmbUyeEkleZamanlama";
            this.cmbUyeEkleZamanlama.Size = new System.Drawing.Size(170, 24);
            this.cmbUyeEkleZamanlama.TabIndex = 11;
            // 
            // btnUyeEkle_Ekle
            // 
            this.btnUyeEkle_Ekle.BorderRadius = 8;
            this.btnUyeEkle_Ekle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUyeEkle_Ekle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUyeEkle_Ekle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUyeEkle_Ekle.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUyeEkle_Ekle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUyeEkle_Ekle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUyeEkle_Ekle.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUyeEkle_Ekle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUyeEkle_Ekle.ForeColor = System.Drawing.Color.White;
            this.btnUyeEkle_Ekle.Location = new System.Drawing.Point(460, 376);
            this.btnUyeEkle_Ekle.Name = "btnUyeEkle_Ekle";
            this.btnUyeEkle_Ekle.Size = new System.Drawing.Size(92, 36);
            this.btnUyeEkle_Ekle.TabIndex = 16;
            this.btnUyeEkle_Ekle.Text = "Ekle";
            this.btnUyeEkle_Ekle.Click += new System.EventHandler(this.btnUyeEkle_Ekle_Click);
            // 
            // btnUyeEkleReset
            // 
            this.btnUyeEkleReset.BorderRadius = 8;
            this.btnUyeEkleReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUyeEkleReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUyeEkleReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUyeEkleReset.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUyeEkleReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUyeEkleReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUyeEkleReset.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUyeEkleReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUyeEkleReset.ForeColor = System.Drawing.Color.White;
            this.btnUyeEkleReset.Location = new System.Drawing.Point(558, 376);
            this.btnUyeEkleReset.Name = "btnUyeEkleReset";
            this.btnUyeEkleReset.Size = new System.Drawing.Size(92, 36);
            this.btnUyeEkleReset.TabIndex = 16;
            this.btnUyeEkleReset.Text = "Reset";
            // 
            // btnUyeEkleGeri
            // 
            this.btnUyeEkleGeri.BorderRadius = 8;
            this.btnUyeEkleGeri.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUyeEkleGeri.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUyeEkleGeri.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUyeEkleGeri.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUyeEkleGeri.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUyeEkleGeri.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUyeEkleGeri.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUyeEkleGeri.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUyeEkleGeri.ForeColor = System.Drawing.Color.White;
            this.btnUyeEkleGeri.Location = new System.Drawing.Point(656, 376);
            this.btnUyeEkleGeri.Name = "btnUyeEkleGeri";
            this.btnUyeEkleGeri.Size = new System.Drawing.Size(92, 36);
            this.btnUyeEkleGeri.TabIndex = 16;
            this.btnUyeEkleGeri.Text = "Geri";
            // 
            // btnGeri
            // 
            this.btnGeri.BorderRadius = 8;
            this.btnGeri.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGeri.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGeri.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGeri.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGeri.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGeri.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGeri.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.Location = new System.Drawing.Point(538, 418);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(137, 36);
            this.btnGeri.TabIndex = 16;
            this.btnGeri.Text = "Geri";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button1.BackgroundImage")));
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1090, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(48, 48);
            this.guna2Button1.TabIndex = 17;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(10)))), ((int)(((byte)(155)))));
            this.label8.Location = new System.Drawing.Point(502, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 34);
            this.label8.TabIndex = 9;
            this.label8.Text = "Üye Ekleme";
            // 
            // UyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 620);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnUyeEkleGeri);
            this.Controls.Add(this.btnUyeEkleReset);
            this.Controls.Add(this.btnUyeEkle_Ekle);
            this.Controls.Add(this.cmbUyeEkleZamanlama);
            this.Controls.Add(this.dtpUyeEkleCinsiyet);
            this.Controls.Add(this.txtUyeEkleYas);
            this.Controls.Add(this.txtUyeEkletutar);
            this.Controls.Add(this.txtUyeEkleTelefon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUyeEkleAdSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UyeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeEkle";
            this.Load += new System.EventHandler(this.UyeEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtUyeEkleAdSoyad;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtUyeEkleTelefon;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtUyeEkleYas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dtpUyeEkleCinsiyet;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtUyeEkletutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbUyeEkleZamanlama;
        private Guna.UI2.WinForms.Guna2GradientButton btnUyeEkle_Ekle;
        private Guna.UI2.WinForms.Guna2GradientButton btnUyeEkleReset;
        private Guna.UI2.WinForms.Guna2GradientButton btnUyeEkleGeri;
        private Guna.UI2.WinForms.Guna2GradientButton btnGeri;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label8;
    }
}