using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            MenuMaker menu = new MenuMaker() { Randomizer = new Random() };
            label1.Text = menu.GetMenuItem();
            label2.Text = menu.GetMenuItem();
            label3.Text = menu.GetMenuItem();
            label4.Text = menu.GetMenuItem();
            label5.Text = menu.GetMenuItem();
            label6.Text = menu.GetMenuItem();
        }
    }
    public class MenuMaker
    {
        public Random Randomizer;
        string[] Meats = { "Rosbife", "Salami", "Peru", "presunto", "Pastrami" };
        string[] Condiments = { "mostarda amarela", "mostarda marrom", "mostarda com mel", "maionese", " gosto", "molho francês" };
        string[] Breads = { "Centeio", " branco", "trigo", "pumpernicker", "pão italiano", "árabe" };
        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat + " com " + randomCondiment + " no " + randomBread;
        }
    }
}
