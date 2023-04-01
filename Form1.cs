using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maei
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            MessageBox.Show(" Seu nome é " + name
                + "\nx is  " + x
                + "\nx is " + d);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                MessageBox.Show("o resultado é 10");
            }
            else;
            {
                MessageBox.Show(" o resultado não é 10");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int someValue = 4;
            String name = "bobbo JR.";
            if ((someValue < 3) && (name.Equals("Joe")))
            {
                MessageBox.Show("X ´r 3 e o nome é JOE");
            }
            MessageBox.Show("essa linha executa em qualquer caso");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            while (count < 10)
            {
                count++;

            }
            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }
            MessageBox.Show(" O resultado é " + count);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" o resultador é 10");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.BackColor= Color.Red;
                
            }
            if (checkBox1.Checked == false)
            {
                MessageBox.Show("a caixa não está marcada");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
