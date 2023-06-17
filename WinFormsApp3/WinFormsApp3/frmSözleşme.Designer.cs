namespace WinFormsApp3
{
    partial class frmSözleşme
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
            groupBox1 = new GroupBox();
            txtTcAra = new TextBox();
            label18 = new Label();
            txtE_Yer = new TextBox();
            txtE_Tarih = new TextBox();
            txtE_No = new TextBox();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTc = new TextBox();
            lblE_Yer = new Label();
            lblE_Tarih = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnTemizle = new Button();
            btnHesapla = new Button();
            btnGüncelle = new Button();
            btnEkle = new Button();
            dateDönüş = new DateTimePicker();
            dateÇıkış = new DateTimePicker();
            txtTutar = new TextBox();
            txtGün = new TextBox();
            txtKiraÜcreti = new TextBox();
            txtRenk = new TextBox();
            txtYil = new TextBox();
            txtSeri = new TextBox();
            txtMarka = new TextBox();
            comboKiraŞekli = new ComboBox();
            comboAraçlar = new ComboBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            btnAraçTeslim = new Button();
            txtEkstra = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTcAra);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(txtE_Yer);
            groupBox1.Controls.Add(txtE_Tarih);
            groupBox1.Controls.Add(txtE_No);
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(txtTc);
            groupBox1.Controls.Add(lblE_Yer);
            groupBox1.Controls.Add(lblE_Tarih);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(47, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 311);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri Bilgileri";
            // 
            // txtTcAra
            // 
            txtTcAra.Location = new Point(108, 33);
            txtTcAra.Name = "txtTcAra";
            txtTcAra.Size = new Size(125, 27);
            txtTcAra.TabIndex = 13;
            txtTcAra.TextChanged += txtTcAra_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(32, 36);
            label18.Name = "label18";
            label18.Size = new Size(70, 23);
            label18.TabIndex = 12;
            label18.Text = "TC ARA";
            // 
            // txtE_Yer
            // 
            txtE_Yer.Location = new Point(108, 271);
            txtE_Yer.Name = "txtE_Yer";
            txtE_Yer.Size = new Size(125, 27);
            txtE_Yer.TabIndex = 11;
            // 
            // txtE_Tarih
            // 
            txtE_Tarih.Location = new Point(108, 235);
            txtE_Tarih.Name = "txtE_Tarih";
            txtE_Tarih.Size = new Size(125, 27);
            txtE_Tarih.TabIndex = 10;
            // 
            // txtE_No
            // 
            txtE_No.Location = new Point(108, 194);
            txtE_No.Name = "txtE_No";
            txtE_No.Size = new Size(125, 27);
            txtE_No.TabIndex = 9;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(108, 153);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(125, 27);
            txtTelefon.TabIndex = 8;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(108, 112);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 7;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(108, 71);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(125, 27);
            txtTc.TabIndex = 6;
            txtTc.TextChanged += txtTc_TextChanged;
            // 
            // lblE_Yer
            // 
            lblE_Yer.AutoSize = true;
            lblE_Yer.Location = new Point(1, 274);
            lblE_Yer.Name = "lblE_Yer";
            lblE_Yer.Size = new Size(101, 20);
            lblE_Yer.TabIndex = 5;
            lblE_Yer.Text = "E_verildiği Yer";
            // 
            // lblE_Tarih
            // 
            lblE_Tarih.AutoSize = true;
            lblE_Tarih.Location = new Point(10, 235);
            lblE_Tarih.Name = "lblE_Tarih";
            lblE_Tarih.Size = new Size(92, 20);
            lblE_Tarih.TabIndex = 4;
            lblE_Tarih.Text = "Ehliyet Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 194);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "Ehliyet No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 156);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 114);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 74);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "TC";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTemizle);
            groupBox2.Controls.Add(btnHesapla);
            groupBox2.Controls.Add(btnGüncelle);
            groupBox2.Controls.Add(btnEkle);
            groupBox2.Controls.Add(dateDönüş);
            groupBox2.Controls.Add(dateÇıkış);
            groupBox2.Controls.Add(txtTutar);
            groupBox2.Controls.Add(txtGün);
            groupBox2.Controls.Add(txtKiraÜcreti);
            groupBox2.Controls.Add(txtRenk);
            groupBox2.Controls.Add(txtYil);
            groupBox2.Controls.Add(txtSeri);
            groupBox2.Controls.Add(txtMarka);
            groupBox2.Controls.Add(comboKiraŞekli);
            groupBox2.Controls.Add(comboAraçlar);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(315, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(711, 311);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Araç Bilgileri";
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.White;
            btnTemizle.ImageAlign = ContentAlignment.MiddleLeft;
            btnTemizle.Location = new Point(436, 262);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(148, 36);
            btnTemizle.TabIndex = 25;
            btnTemizle.Text = "Temizle";
            btnTemizle.TextAlign = ContentAlignment.MiddleRight;
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.White;
            btnHesapla.Location = new Point(600, 32);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(105, 203);
            btnHesapla.TabIndex = 24;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.BackColor = Color.White;
            btnGüncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGüncelle.Location = new Point(155, 262);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(148, 36);
            btnGüncelle.TabIndex = 23;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.TextAlign = ContentAlignment.MiddleRight;
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.White;
            btnEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnEkle.Location = new Point(6, 262);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(143, 36);
            btnEkle.TabIndex = 22;
            btnEkle.Text = "Ekle";
            btnEkle.TextAlign = ContentAlignment.MiddleRight;
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // dateDönüş
            // 
            dateDönüş.Format = DateTimePickerFormat.Short;
            dateDönüş.Location = new Point(459, 210);
            dateDönüş.Name = "dateDönüş";
            dateDönüş.Size = new Size(125, 27);
            dateDönüş.TabIndex = 21;
            // 
            // dateÇıkış
            // 
            dateÇıkış.Format = DateTimePickerFormat.Short;
            dateÇıkış.Location = new Point(459, 173);
            dateÇıkış.Name = "dateÇıkış";
            dateÇıkış.Size = new Size(125, 27);
            dateÇıkış.TabIndex = 20;
            dateÇıkış.ValueChanged += dateÇıkış_ValueChanged;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(459, 138);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(125, 27);
            txtTutar.TabIndex = 19;
            // 
            // txtGün
            // 
            txtGün.Location = new Point(459, 103);
            txtGün.Name = "txtGün";
            txtGün.Size = new Size(125, 27);
            txtGün.TabIndex = 18;
            // 
            // txtKiraÜcreti
            // 
            txtKiraÜcreti.Location = new Point(459, 68);
            txtKiraÜcreti.Name = "txtKiraÜcreti";
            txtKiraÜcreti.Size = new Size(125, 27);
            txtKiraÜcreti.TabIndex = 17;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(149, 196);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(125, 27);
            txtRenk.TabIndex = 16;
            // 
            // txtYil
            // 
            txtYil.Location = new Point(149, 156);
            txtYil.Name = "txtYil";
            txtYil.Size = new Size(125, 27);
            txtYil.TabIndex = 15;
            // 
            // txtSeri
            // 
            txtSeri.Location = new Point(149, 116);
            txtSeri.Name = "txtSeri";
            txtSeri.Size = new Size(125, 27);
            txtSeri.TabIndex = 14;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(149, 76);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(125, 27);
            txtMarka.TabIndex = 13;
            // 
            // comboKiraŞekli
            // 
            comboKiraŞekli.FormattingEnabled = true;
            comboKiraŞekli.Items.AddRange(new object[] { "Günlük ", "Haftalık ", "Aylık" });
            comboKiraŞekli.Location = new Point(459, 32);
            comboKiraŞekli.Name = "comboKiraŞekli";
            comboKiraŞekli.Size = new Size(125, 28);
            comboKiraŞekli.TabIndex = 12;
            comboKiraŞekli.SelectedIndexChanged += comboKiraŞekli_SelectedIndexChanged;
            // 
            // comboAraçlar
            // 
            comboAraçlar.FormattingEnabled = true;
            comboAraçlar.Location = new Point(149, 35);
            comboAraçlar.Name = "comboAraçlar";
            comboAraçlar.Size = new Size(125, 28);
            comboAraçlar.TabIndex = 11;
            comboAraçlar.SelectedIndexChanged += comboAraçlar_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(352, 215);
            label17.Name = "label17";
            label17.Size = new Size(90, 20);
            label17.TabIndex = 10;
            label17.Text = "Dönüş Tarihi";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(364, 179);
            label16.Name = "label16";
            label16.Size = new Size(78, 20);
            label16.TabIndex = 9;
            label16.Text = "Çıkış Tarihi";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(399, 143);
            label15.Name = "label15";
            label15.Size = new Size(43, 20);
            label15.TabIndex = 8;
            label15.Text = "Tutar";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(407, 107);
            label14.Name = "label14";
            label14.Size = new Size(35, 20);
            label14.TabIndex = 7;
            label14.Text = "Gün";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(364, 71);
            label13.Name = "label13";
            label13.Size = new Size(78, 20);
            label13.TabIndex = 6;
            label13.Text = "Kira Ücreti";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(372, 35);
            label12.Name = "label12";
            label12.Size = new Size(70, 20);
            label12.TabIndex = 5;
            label12.Text = "Kira Şekli";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(82, 199);
            label11.Name = "label11";
            label11.Size = new Size(41, 20);
            label11.TabIndex = 4;
            label11.Text = "Renk";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(45, 158);
            label10.Name = "label10";
            label10.Size = new Size(78, 20);
            label10.TabIndex = 3;
            label10.Text = "Model(Yıl)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(89, 117);
            label9.Name = "label9";
            label9.Size = new Size(34, 20);
            label9.TabIndex = 2;
            label9.Text = "Seri";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(73, 76);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 1;
            label8.Text = "Marka";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(67, 35);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 0;
            label7.Text = "Araçlar";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 329);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(979, 294);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnAraçTeslim
            // 
            btnAraçTeslim.BackColor = Color.White;
            btnAraçTeslim.Location = new Point(874, 634);
            btnAraçTeslim.Name = "btnAraçTeslim";
            btnAraçTeslim.Size = new Size(152, 41);
            btnAraçTeslim.TabIndex = 3;
            btnAraçTeslim.Text = "Araç Teslim";
            btnAraçTeslim.UseVisualStyleBackColor = false;
            btnAraçTeslim.Click += btnAraçTeslim_Click;
            // 
            // txtEkstra
            // 
            txtEkstra.Location = new Point(733, 641);
            txtEkstra.Name = "txtEkstra";
            txtEkstra.Size = new Size(125, 27);
            txtEkstra.TabIndex = 13;
            txtEkstra.TextChanged += txtEkstra_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(561, 644);
            label5.Name = "label5";
            label5.Size = new Size(167, 20);
            label5.TabIndex = 12;
            label5.Text = "Alacak/Verecek Durumu";
            // 
            // frmSözleşme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1096, 687);
            Controls.Add(txtEkstra);
            Controls.Add(label5);
            Controls.Add(btnAraçTeslim);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmSözleşme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sözleşme Sayfası";
            Load += frmSözleşme_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtE_Yer;
        private TextBox txtE_Tarih;
        private TextBox txtE_No;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTc;
        private Label lblE_Yer;
        private Label lblE_Tarih;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnGüncelle;
        private Button btnEkle;
        private DateTimePicker dateDönüş;
        private DateTimePicker dateÇıkış;
        private TextBox txtTutar;
        private TextBox txtGün;
        private TextBox txtKiraÜcreti;
        private TextBox txtRenk;
        private TextBox txtYil;
        private TextBox txtSeri;
        private TextBox txtMarka;
        private ComboBox comboKiraŞekli;
        private ComboBox comboAraçlar;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private DataGridView dataGridView1;
        private Button btnAraçTeslim;
        private Button btnHesapla;
        private Button btnTemizle;
        private TextBox txtTcAra;
        private Label label18;
        private TextBox txtEkstra;
        private Label label5;
    }
}