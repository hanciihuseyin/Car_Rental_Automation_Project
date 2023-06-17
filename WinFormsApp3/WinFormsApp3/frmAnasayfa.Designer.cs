namespace WinFormsApp3
{
    partial class frmAnasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            panel1 = new Panel();
            button7 = new Button();
            ımageList1 = new ImageList(components);
            button5 = new Button();
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1021, 125);
            panel1.TabIndex = 0;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.ImageAlign = ContentAlignment.TopCenter;
            button7.ImageIndex = 3;
            button7.ImageList = ımageList1;
            button7.Location = new Point(858, 22);
            button7.Name = "button7";
            button7.Size = new Size(141, 100);
            button7.TabIndex = 6;
            button7.Text = "Çıkış";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "5-56154_qual-a-melhor-tcnica-para-fechar-a-venda.png");
            ımageList1.Images.SetKeyName(1, "images (1).png");
            ımageList1.Images.SetKeyName(2, "images.png");
            ımageList1.Images.SetKeyName(3, "indir (1).jpg");
            ımageList1.Images.SetKeyName(4, "indir.jpg");
            ımageList1.Images.SetKeyName(5, "png-transparent-vehicle-registration-certificate-vehicle-license-plates-motor-vehicle-registration-councillor-san-miguel-angle-text-poster-thumbnail.png");
            ımageList1.Images.SetKeyName(6, "pngtree-check-list-icon-isolated-on-abstract-background-png-image_1776830.jpg");
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.ImageIndex = 0;
            button5.ImageList = ımageList1;
            button5.Location = new Point(576, 22);
            button5.Name = "button5";
            button5.Size = new Size(141, 100);
            button5.TabIndex = 4;
            button5.Text = "Sözleşme";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.ImageIndex = 4;
            button6.ImageList = ımageList1;
            button6.Location = new Point(717, 22);
            button6.Name = "button6";
            button6.Size = new Size(141, 100);
            button6.TabIndex = 5;
            button6.Text = "Satış";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.ImageIndex = 1;
            button4.ImageList = ımageList1;
            button4.Location = new Point(435, 22);
            button4.Name = "button4";
            button4.Size = new Size(141, 100);
            button4.TabIndex = 3;
            button4.Text = "Araç Listeleme";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.ImageIndex = 5;
            button3.ImageList = ımageList1;
            button3.Location = new Point(294, 22);
            button3.Name = "button3";
            button3.Size = new Size(141, 100);
            button3.TabIndex = 2;
            button3.Text = "Araç Kayıt";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.ImageIndex = 6;
            button2.ImageList = ımageList1;
            button2.Location = new Point(153, 22);
            button2.Name = "button2";
            button2.Size = new Size(141, 100);
            button2.TabIndex = 1;
            button2.Text = "Müşteri Lisleleme";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.ImageIndex = 2;
            button1.ImageList = ımageList1;
            button1.Location = new Point(12, 22);
            button1.Name = "button1";
            button1.Size = new Size(141, 100);
            button1.TabIndex = 0;
            button1.Text = "Müşteri Ekleme";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // frmAnasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            BackgroundImage = Properties.Resources._51_1_arac_kiralama_firmalari_arasindan_secim_yaparken_nelere_dikkat_edilmeli_200;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1021, 447);
            Controls.Add(panel1);
            Name = "frmAnasayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Sayfa";
            Load += frmAnasayfa_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private ImageList ımageList1;
    }
}