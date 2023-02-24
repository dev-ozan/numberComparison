using System.Linq.Expressions;
using System.Windows.Forms;

namespace WinFormsApp1_sil_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void krsLbl_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(firstText.Text);
                int sayi2 = Convert.ToInt32(textBox1.Text);

                if (sayi1 < sayi2)
                {
                    MessageBox.Show("Girilen sayi Küçüktür");


                }

                else if (sayi1 == sayi2)
                {
                    MessageBox.Show("Girilen sayi eşittir");
                }
                else
                {
                    MessageBox.Show("Girilen sayi büyüktür");

                }


            }
            catch
            {
                MessageBox.Show("Lütfen sayı girin");

            }
        }
    }
}