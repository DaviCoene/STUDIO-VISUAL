using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int EndingMileage;
        double milesTraveled;
        double reimburseRate = .39;
        double amountOwed;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numericUpDown3.Value;
            EndingMileage = (int)numericUpDown4.Value;
            if (startingMileage <= EndingMileage)
            {
                milesTraveled = EndingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                label8.Text = "$" + amountOwed;
            } else
            {
                MessageBox.Show("A milha iniciar necessita ser menor do que a milha final" , "Nâo consigo calcular a milhagem");
                }
            }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + "milhas", "Milhas Viajadas");
        }
    }
    }

    
