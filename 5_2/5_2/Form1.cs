using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_2
{
    public partial class Form1 : Form
    {
        Farmer farmer;
        public Form1()
        {

            InitializeComponent();
            farmer = new Farmer() { NumberOfCows = 15 };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Farmer myFarmer = new Farmer();
            myFarmer.NumberOfCows = 10;
            int howManyBags = myFarmer.BagsOfFeed;
            Console.WriteLine("I need {0} bags of fees for {1} cows", farmer.BagsOfFeed, farmer.NumberOfCows);
        }

        public class Farmer
        {
            public int BagsOfFeed;
            public const int FeedMultiplier = 30;
            private int numberOfCows;
            public int NumberOfCows
            {
                get { return numberOfCows; }
                set
                {
                    numberOfCows = value;
                    BagsOfFeed = numberOfCows * FeedMultiplier;
                }
            }
            public int GetNumberOFCows()
            {
                return numberOfCows;
            }
            public void SetNumberOfCows(int newNumberOfCows)
            {
                numberOfCows = newNumberOfCows;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
            {
                farmer.NumberOfCows = (int)numericUpDown1.Value;
            }
        }
    }

