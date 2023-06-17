namespace WinFormsApp3
{
    partial class frmAraçListele
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAraçListele));
            dataGridView1 = new DataGridView();
            comboAraçlar = new ComboBox();
            btnResim = new Button();
            btnİptal = new Button();
            ımageList1 = new ImageList(components);
            btnGüncelle = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Ücrettxt = new TextBox();
            Kmtxt = new TextBox();
            Renktext = new TextBox();
            Yiltxt = new TextBox();
            Sericombo = new ComboBox();
            Yakıtcombo = new ComboBox();
            Markacombo = new ComboBox();
            Plakatxt = new TextBox();
            btnSil = new Button();
            pictureBox2 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(331, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(673, 333);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // comboAraçlar
            // 
            comboAraçlar.FormattingEnabled = true;
            comboAraçlar.Items.AddRange(new object[] { "Tüm Araçlar", "Boş Araçlar", "Dolu Araçlar" });
            comboAraçlar.Location = new Point(774, 15);
            comboAraçlar.Name = "comboAraçlar";
            comboAraçlar.Size = new Size(151, 28);
            comboAraçlar.TabIndex = 1;
            comboAraçlar.SelectedIndexChanged += comboAraçlar_SelectedIndexChanged;
            // 
            // btnResim
            // 
            btnResim.BackColor = Color.White;
            btnResim.Location = new Point(81, 328);
            btnResim.Name = "btnResim";
            btnResim.Size = new Size(139, 25);
            btnResim.TabIndex = 40;
            btnResim.Text = "Resim Değiştir";
            btnResim.UseVisualStyleBackColor = false;
            btnResim.Click += btnResim_Click;
            // 
            // btnİptal
            // 
            btnİptal.BackColor = Color.White;
            btnİptal.ImageAlign = ContentAlignment.MiddleLeft;
            btnİptal.ImageIndex = 0;
            btnİptal.ImageList = ımageList1;
            btnİptal.Location = new Point(160, 488);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(109, 44);
            btnİptal.TabIndex = 39;
            btnİptal.Text = "İptal";
            btnİptal.TextAlign = ContentAlignment.MiddleRight;
            btnİptal.UseVisualStyleBackColor = false;
            btnİptal.Click += btnİptal_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "çıkış.png");
            ımageList1.Images.SetKeyName(1, "sil.png");
            ımageList1.Images.SetKeyName(2, "update.png");
            // 
            // btnGüncelle
            // 
            btnGüncelle.BackColor = Color.White;
            btnGüncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGüncelle.ImageIndex = 2;
            btnGüncelle.ImageList = ımageList1;
            btnGüncelle.Location = new Point(49, 488);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(105, 44);
            btnGüncelle.TabIndex = 38;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.TextAlign = ContentAlignment.MiddleRight;
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(2, 281);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 36;
            label8.Text = "Kira Ücreti";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 243);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 35;
            label7.Text = "Yakıt";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 205);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 34;
            label6.Text = "Km";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 167);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 33;
            label5.Text = "Renk";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 129);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 32;
            label4.Text = "Model(Yıl)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 91);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 31;
            label3.Text = "Seri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 53);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 30;
            label2.Text = "Marka";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 15);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 29;
            label1.Text = "Plaka";
            // 
            // Ücrettxt
            // 
            Ücrettxt.Location = new Point(90, 277);
            Ücrettxt.Name = "Ücrettxt";
            Ücrettxt.Size = new Size(179, 27);
            Ücrettxt.TabIndex = 28;
            Ücrettxt.Text = " ";
            // 
            // Kmtxt
            // 
            Kmtxt.Location = new Point(90, 200);
            Kmtxt.Name = "Kmtxt";
            Kmtxt.Size = new Size(179, 27);
            Kmtxt.TabIndex = 27;
            // 
            // Renktext
            // 
            Renktext.Location = new Point(90, 162);
            Renktext.Name = "Renktext";
            Renktext.Size = new Size(179, 27);
            Renktext.TabIndex = 26;
            // 
            // Yiltxt
            // 
            Yiltxt.Location = new Point(90, 124);
            Yiltxt.Name = "Yiltxt";
            Yiltxt.Size = new Size(179, 27);
            Yiltxt.TabIndex = 25;
            // 
            // Sericombo
            // 
            Sericombo.FormattingEnabled = true;
            Sericombo.Location = new Point(90, 85);
            Sericombo.Name = "Sericombo";
            Sericombo.Size = new Size(179, 28);
            Sericombo.TabIndex = 24;
            // 
            // Yakıtcombo
            // 
            Yakıtcombo.FormattingEnabled = true;
            Yakıtcombo.Items.AddRange(new object[] { "Dizel", "Benzin", "Benzin+Lpg" });
            Yakıtcombo.Location = new Point(90, 238);
            Yakıtcombo.Name = "Yakıtcombo";
            Yakıtcombo.Size = new Size(179, 28);
            Yakıtcombo.TabIndex = 23;
            // 
            // Markacombo
            // 
            Markacombo.FormattingEnabled = true;
            Markacombo.Items.AddRange(new object[] { "Opel", "Renault ", "Fiat", "Ford " });
            Markacombo.Location = new Point(90, 46);
            Markacombo.Name = "Markacombo";
            Markacombo.Size = new Size(179, 28);
            Markacombo.TabIndex = 22;
            Markacombo.SelectedIndexChanged += Markacombo_SelectedIndexChanged;
            // 
            // Plakatxt
            // 
            Plakatxt.Location = new Point(90, 8);
            Plakatxt.Name = "Plakatxt";
            Plakatxt.Size = new Size(179, 27);
            Plakatxt.TabIndex = 21;
            Plakatxt.TextChanged += Plakatxt_TextChanged;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.White;
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.ImageIndex = 0;
            btnSil.Location = new Point(1010, 69);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(88, 44);
            btnSil.TabIndex = 41;
            btnSil.Text = "Sil";
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(63, 359);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(185, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAraçListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1108, 544);
            Controls.Add(pictureBox2);
            Controls.Add(btnSil);
            Controls.Add(btnResim);
            Controls.Add(btnİptal);
            Controls.Add(btnGüncelle);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Ücrettxt);
            Controls.Add(Kmtxt);
            Controls.Add(Renktext);
            Controls.Add(Yiltxt);
            Controls.Add(Sericombo);
            Controls.Add(Yakıtcombo);
            Controls.Add(Markacombo);
            Controls.Add(Plakatxt);
            Controls.Add(comboAraçlar);
            Controls.Add(dataGridView1);
            Name = "frmAraçListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç Listeleme Sayfası";
            Load += frmAraçListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboAraçlar;
        private Button btnResim;
        private Button btnİptal;
        private Button btnGüncelle;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Ücrettxt;
        private TextBox Kmtxt;
        private TextBox Renktext;
        private TextBox Yiltxt;
        private ComboBox Sericombo;
        private ComboBox Yakıtcombo;
        private ComboBox Markacombo;
        private TextBox Plakatxt;
        private Button btnSil;
        private PictureBox pictureBox2;
        private OpenFileDialog openFileDialog1;
        private ImageList ımageList1;
    }
}