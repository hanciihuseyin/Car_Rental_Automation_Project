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
            frmM�steriEkle ekle = new frmM�steriEkle();
            ekle.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            frmSat�� sat�� = new frmSat��();
            sat��.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frmS�zle�me s�zle�me = new frmS�zle�me();
            s�zle�me.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {frmAra�Listele listele = new frmAra�Listele();
            listele.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmAra�Kay�t kay�t = new frmAra�Kay�t();
            kay�t.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmM��teriListele listele = new frmM��teriListele();
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