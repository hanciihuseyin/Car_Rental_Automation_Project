namespace WinFormsApp3
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmMüsteriEkle ekle = new frmMüsteriEkle();
            ekle.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            frmSatýþ satýþ = new frmSatýþ();
            satýþ.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frmSözleþme sözleþme = new frmSözleþme();
            sözleþme.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {frmAraçListele listele = new frmAraçListele();
            listele.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmAraçKayýt kayýt = new frmAraçKayýt();
            kayýt.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmMüþteriListele listele = new frmMüþteriListele();
            listele.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {



        }
    }
}