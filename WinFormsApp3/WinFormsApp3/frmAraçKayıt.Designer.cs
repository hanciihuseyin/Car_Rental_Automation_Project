namespace WinFormsApp3
{
    partial class frmAraçKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAraçKayıt));
            Plakatxt = new TextBox();
            Markacombo = new ComboBox();
            Yakıtcombo = new ComboBox();
            Sericombo = new ComboBox();
            Yiltxt = new TextBox();
            Renktext = new TextBox();
            Kmtxt = new TextBox();
            Ücrettxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ımageList1 = new ImageList(components);
            button2 = new Button();
            btnResim = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Plakatxt
            // 
            Plakatxt.Location = new Point(159, 55);
            Plakatxt.Name = "Plakatxt";
            Plakatxt.Size = new Size(239, 27);
            Plakatxt.TabIndex = 0;
            Plakatxt.TextChanged += Plakatxt_TextChanged;
            // 
            // Markacombo
            // 
            Markacombo.FormattingEnabled = true;
            Markacombo.Items.AddRange(new object[] { "Opel", "Renault ", "Fiat", "Ford " });
            Markacombo.Location = new Point(159, 93);
            Markacombo.Name = "Markacombo";
            Markacombo.Size = new Size(239, 28);
            Markacombo.TabIndex = 1;
            Markacombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Yakıtcombo
            // 
            Yakıtcombo.FormattingEnabled = true;
            Yakıtcombo.Items.AddRange(new object[] { "Dizel", "Benzin", "Benzin+Lpg" });
            Yakıtcombo.Location = new Point(159, 285);
            Yakıtcombo.Name = "Yakıtcombo";
            Yakıtcombo.Size = new Size(239, 28);
            Yakıtcombo.TabIndex = 2;
            // 
            // Sericombo
            // 
            Sericombo.FormattingEnabled = true;
            Sericombo.Location = new Point(159, 132);
            Sericombo.Name = "Sericombo";
            Sericombo.Size = new Size(239, 28);
            Sericombo.TabIndex = 3;
            // 
            // Yiltxt
            // 
            Yiltxt.Location = new Point(159, 171);
            Yiltxt.Name = "Yiltxt";
            Yiltxt.Size = new Size(239, 27);
            Yiltxt.TabIndex = 4;
            // 
            // Renktext
            // 
            Renktext.Location = new Point(159, 209);
            Renktext.Name = "Renktext";
            Renktext.Size = new Size(239, 27);
            Renktext.TabIndex = 5;
            // 
            // Kmtxt
            // 
            Kmtxt.Location = new Point(159, 247);
            Kmtxt.Name = "Kmtxt";
            Kmtxt.Size = new Size(239, 27);
            Kmtxt.TabIndex = 6;
            // 
            // Ücrettxt
            // 
            Ücrettxt.Location = new Point(159, 324);
            Ücrettxt.Name = "Ücrettxt";
            Ücrettxt.Size = new Size(239, 27);
            Ücrettxt.TabIndex = 8;
            Ücrettxt.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 58);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 9;
            label1.Text = "Plaka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 96);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 10;
            label2.Text = "Marka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 134);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 11;
            label3.Text = "Seri";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 172);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 12;
            label4.Text = "Model(Yıl)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 210);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 13;
            label5.Text = "Renk";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 248);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 14;
            label6.Text = "Km";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 286);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 15;
            label7.Text = "Yakıt";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 324);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 16;
            label8.Text = "Kira Ücreti";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(415, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 1;
            button1.ImageList = ımageList1;
            button1.Location = new Point(159, 367);
            button1.Name = "button1";
            button1.Size = new Size(115, 67);
            button1.TabIndex = 18;
            button1.Text = "Kayıt";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "png-transparent-button-computer-icons-cancel-button-angle-rectangle-symmetry-thumbnail.png");
            ımageList1.Images.SetKeyName(1, "png-transparent-vehicle-registration-certificate-vehicle-license-plates-motor-vehicle-registration-councillor-san-miguel-angle-text-poster-thumbnail.png");
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImageIndex = 0;
            button2.ImageList = ımageList1;
            button2.Location = new Point(280, 367);
            button2.Name = "button2";
            button2.Size = new Size(118, 67);
            button2.TabIndex = 19;
            button2.Text = "İptal";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnResim
            // 
            btnResim.BackColor = Color.White;
            btnResim.Location = new Point(458, 209);
            btnResim.Name = "btnResim";
            btnResim.Size = new Size(111, 48);
            btnResim.TabIndex = 20;
            btnResim.Text = "Resim Ekle";
            btnResim.UseVisualStyleBackColor = false;
            btnResim.Click += btnResim_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAraçKayıt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(631, 446);
            Controls.Add(btnResim);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
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
            Name = "frmAraçKayıt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç Kayıt Sayfası";
            Load += frmAraçKayıt_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Plakatxt;
        private ComboBox Markacombo;
        private ComboBox Yakıtcombo;
        private ComboBox Sericombo;
        private TextBox Yiltxt;
        private TextBox Renktext;
        private TextBox Kmtxt;
        private TextBox Ücrettxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button btnResim;
        private ImageList ımageList1;
        private OpenFileDialog openFileDialog1;
    }
}