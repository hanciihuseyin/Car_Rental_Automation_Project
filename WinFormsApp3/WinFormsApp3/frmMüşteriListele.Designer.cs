namespace WinFormsApp3
{
    partial class frmMüşteriListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMüşteriListele));
            dataGridView1 = new DataGridView();
            btnİptal = new Button();
            ımageList1 = new ImageList(components);
            btnGüncelle = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            txtAdres = new TextBox();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTc = new TextBox();
            btnSil = new Button();
            label6 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(350, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(569, 351);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            
            // 
            // btnİptal
            // 
            btnİptal.BackColor = Color.White;
            btnİptal.ImageAlign = ContentAlignment.MiddleLeft;
            btnİptal.ImageIndex = 1;
            btnİptal.ImageList = ımageList1;
            btnİptal.Location = new Point(226, 271);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(113, 57);
            btnİptal.TabIndex = 23;
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
            ımageList1.Images.SetKeyName(0, "indir.png");
            ımageList1.Images.SetKeyName(1, "png-transparent-button-computer-icons-cancel-button-angle-rectangle-symmetry-thumbnail.png");
            ımageList1.Images.SetKeyName(2, "png-transparent-firefox-computer-icons-computer-software-patch-update-button-computer-network-trademark-computer-wallpaper-thumbnail.png");
            // 
            // btnGüncelle
            // 
            btnGüncelle.BackColor = Color.White;
            btnGüncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGüncelle.ImageIndex = 2;
            btnGüncelle.ImageList = ımageList1;
            btnGüncelle.Location = new Point(80, 271);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(113, 57);
            btnGüncelle.TabIndex = 22;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.TextAlign = ContentAlignment.MiddleRight;
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 230);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 21;
            label5.Text = "E-Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 194);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 20;
            label4.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 161);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 19;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 128);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 18;
            label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 98);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 17;
            label1.Text = "TC";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(111, 227);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(228, 27);
            txtEmail.TabIndex = 16;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(111, 194);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(228, 27);
            txtAdres.TabIndex = 15;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(111, 161);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(228, 27);
            txtTelefon.TabIndex = 14;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(111, 128);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(228, 27);
            txtAdSoyad.TabIndex = 13;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(111, 95);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(228, 27);
            txtTc.TabIndex = 12;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.White;
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.ImageIndex = 0;
            btnSil.ImageList = ımageList1;
            btnSil.Location = new Point(925, 98);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(69, 50);
            btnSil.TabIndex = 24;
            btnSil.Text = "Sil";
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(612, 55);
            label6.Name = "label6";
            label6.Size = new Size(63, 23);
            label6.TabIndex = 26;
            label6.Text = "TC Ara";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(691, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 27);
            textBox1.TabIndex = 25;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // frmMüşteriListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1014, 473);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(btnSil);
            Controls.Add(btnİptal);
            Controls.Add(btnGüncelle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtAdres);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTc);
            Controls.Add(dataGridView1);
            Name = "frmMüşteriListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Listeleme Sayfası";
            Load += frmMüşteriListele_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnİptal;
        private Button btnGüncelle;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtAdres;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTc;
        private Button btnSil;
        private ImageList ımageList1;
        private Label label6;
        private TextBox textBox1;
    }
}