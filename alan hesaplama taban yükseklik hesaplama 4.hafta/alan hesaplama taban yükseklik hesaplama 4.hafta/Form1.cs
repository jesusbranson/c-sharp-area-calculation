using System.Linq.Expressions;

namespace alan_hesaplama_taban_yükseklik_hesaplama_4.hafta
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
            try
            {
                double taban, yukseklik, ucgenalan;

                taban = Convert.ToDouble(textBox1.Text);

                yukseklik = Convert.ToDouble(textBox2.Text);

                ucgenalan = taban * yukseklik / 2;

                textBox3.Text = ucgenalan.ToString();
            }
                catch
                { MessageBox.Show("Değer giriniz"); };
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try

            {
                double yaricap, dairealani;

                yaricap = Convert.ToDouble(textBox4.Text);

                dairealani = Math.PI * Math.Pow(yaricap, 2);


                textBox5.Text = dairealani.ToString();
            }
            catch
            { MessageBox.Show("Değer giriniz"); }

        }
    }
}