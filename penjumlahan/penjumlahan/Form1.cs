namespace penjumlahan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numA = 0;
            int numB = 0;
            bool isNumericA = int.TryParse(textBox1.Text, out numA);
            bool isNumericB = int.TryParse(textBox2.Text, out numB);
            if (isNumericA && isNumericB)
            {
                int jumlah = numA + numB;
                textBox3.Text = jumlah.ToString();
            }else
            {
                MessageBox.Show("Angka yang kamu salah tidak valid", "Salah Input");
            }
        }
    }
}
