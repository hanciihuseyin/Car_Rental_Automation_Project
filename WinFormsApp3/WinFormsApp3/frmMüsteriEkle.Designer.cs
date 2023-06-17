namespace WinFormsApp3
{
    partial class frmMüsteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMüsteriEkle));
            txtTc = new TextBox();
            txtAdSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtAdres = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnEkle = new Button();
            ımageList1 = new ImageList(components);
            btnİptal = new Button();
            SuspendLayout();
            // 
            // txtTc
            // 
            txtTc.Location = new Point(137, 37);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(228, 27);
            txtTc.TabIndex = 0;
            txtTc.TextChanged += textBox1_TextChanged;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(137, 70);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(228, 27);
            txtAdSoyad.TabIndex = 1;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(137, 103);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(228, 27);
            txtTelefon.TabIndex = 2;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(137, 136);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(228, 27);
            txtAdres.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(137, 169);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(228, 27);
            txtEmail.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 40);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 5;
            label1.Text = "TC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 70);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 6;
            label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 103);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 7;
            label3.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 136);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 8;
            label4.Text = "Adres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 172);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 9;
            label5.Text = "E-Mail";
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.White;
            btnEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnEkle.ImageIndex = 0;
            btnEkle.ImageList = ımageList1;
            btnEkle.Location = new Point(137, 213);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(82, 40);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "Ekle";
            btnEkle.TextAlign = ContentAlignment.MiddleRight;
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += button1_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "images.png");
            ımageList1.Images.SetKeyName(1, "indir (1).jpg");
            // 
            // btnİptal
            // 
            btnİptal.BackColor = Color.White;
            btnİptal.ImageAlign = ContentAlignment.MiddleLeft;
            btnİptal.ImageIndex = 1;
            btnİptal.ImageList = ımageList1;
            btnİptal.Location = new Point(283, 213);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(82, 40);
            btnİptal.TabIndex = 11;
            btnİptal.Text = "İptal";
            btnİptal.TextAlign = ContentAlignment.MiddleRight;
            btnİptal.UseVisualStyleBackColor = false;
            btnİptal.Click += button2_Click;
            // 
            // frmMüsteriEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(433, 340);
            Controls.Add(btnİptal);
            Controls.Add(btnEkle);
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
            Name = "frmMüsteriEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Müşteri Ekleme Sayfası";
            Load += frmMüsteriEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTc;
        private TextBox txtAdSoyad;
        private TextBox txtTelefon;
        private TextBox txtAdres;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnEkle;
        private Button btnİptal;
        private ImageList ımageList1;
    }
}