namespace BaslıkOlusturupEklemek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VeriEkleButton_Click(object sender, EventArgs e)
        {
            string baslik = BaslıkTextBox.Text;
            string konu = KonuTextBox.Text;
            string icerik = icerikRichTextBox1.Text;

            dataGridView1.Rows.Add(baslik, konu, icerik);

            MessageBox.Show("Veri Ekleneme başarılı");

        }
    }
}
