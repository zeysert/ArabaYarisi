using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace melek_yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int birinciatsoluzaklık, ikinciatsoluzaklık, üçüncüatsoluzaklık;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label7.Text);
            derece++;

            label7.Text = derece.ToString();

            int biratgen = pictureBox1.Width;
            int ikiatgen = pictureBox2.Width;
            int üçatgen = pictureBox3.Width;

            int bitisuzakligi = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "1 numaralı yarışmacı yarışı önde götürüyor";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "2 numaralı yarışmacı öne geçti";
            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5)
            {
                label6.Text = "3 numaralı yarışmacı liderliği ele geçirdi";
            }



            if (biratgen + pictureBox1.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("1.yarışmacı yarışı kazandı!");
            }
            if (ikiatgen + pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("2.yarışmacı yarışı kazandı!");
            }
            if (üçatgen + pictureBox3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("3.yarışmacı yarışı kazandı!");
            }
        }

       

        Random rastgele = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsoluzaklık = pictureBox1.Left;
            ikinciatsoluzaklık = pictureBox2.Left;
            üçüncüatsoluzaklık = pictureBox3.Left;

        }

        
    }
}
