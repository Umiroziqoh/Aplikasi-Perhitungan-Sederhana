namespace Aplikasi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJumlah_Click(object sender, EventArgs e)
        {
            int numA = 0;
            int numB = 0;
            bool isNumericA = int.TryParse(txtA.Text, out numA);
            bool isNumericB = int.TryParse(txtA.Text, out numB);
            if (isNumericA && isNumericB)
            {
                int jumlah = numA + numB;
                txtHasil.Text = jumlah.ToString();
            }
            else
            {
                MessageBox.Show("Angka yang anda masukan tidak valid","salah input");
            }
        }
    }
}
