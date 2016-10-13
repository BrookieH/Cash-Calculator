using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Calculator
{
    public partial class Form1 : Form
    {
        const double POODLE_COST = 550.00;
        const double PUG_COST = 270.00;
        const double SHITTZU_COST = 325.00;
        const double FIRSTSHOTS_COST = 100.00;
        const double TAX_COST = 0.13;
        int poodle = 0;
        int pug = 0;
        int shihtzu = 0;
        int change;
        double price;
        double tax;
        double pricewithTax;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // number in text box into diameter equation
                poodle = Convert.ToInt16(poodleInput.Text);
                pug = Convert.ToInt16(pugInput.Text);
                shihtzu = Convert.ToInt16(shihtzuInput.Text);
                pricewithTax = Convert.ToInt16(Text);

                tax = price * TAX_COST;
               
                

                //get inputs from screen and put into poodle, pug, and  ...

                price = (poodle * POODLE_COST) + (pug * PUG_COST) + (shihtzu * SHITTZU_COST) + (poodle + pug + shihtzu * FIRSTSHOTS_COST) * TAX_COST;

                outputLabel.Text = price.ToString("C");

            }
            catch
            { 
                   outputLabel.Text = " please put a number in every space";
            }

        }
    }
}
