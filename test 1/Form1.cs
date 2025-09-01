using System;
using System.Windows.Forms;
namespace test_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHasil.Text = "Masukkan berat dan tinggi, lalu klik hitung";
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                double berat = double.Parse(txtBerat.Text);
                double tinggi = double.Parse(txtTinggi.Text) / 100; // cm -> meter

                double bmi = berat / (tinggi * tinggi);

                string kategori;
                if (bmi < 18.5)
                    kategori = "Kurus";
                else if (bmi < 25)
                    kategori = "Normal";
                else if (bmi < 30)
                    kategori = "Gemuk";
                else
                    kategori = "Obesitas";

               
                lblHasil.Text = $"BMI: {bmi:F2} ({kategori})";
            }
            catch
            {
                MessageBox.Show("Input tidak valid, masukkan angka!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void grpHasil_Enter(object sender, EventArgs e)
        {
           
        }

        private void lblJudul_Click(object sender, EventArgs e)
        {
            
        }

      
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void lblHasil_Click(object sender, EventArgs e) { }
    }
}