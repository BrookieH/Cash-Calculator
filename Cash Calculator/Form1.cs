using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


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
        double change;
        int shots = 100;
        double price;
        double tax;
        double pricewithtax;
        double amount;

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
                


                //get inputs from screen and put into poodle, pug, and  ...

                price = (poodle * POODLE_COST) + (pug * PUG_COST) + (shihtzu * SHITTZU_COST) + ((poodle + pug + shihtzu) * FIRSTSHOTS_COST);
                tax = price * TAX_COST;
                pricewithtax = price + tax;
                

                priceLabel.Text = price.ToString("C");
                taxLabel.Text = tax.ToString("C");
                priceWithTaxLabel.Text = pricewithtax.ToString("C");


            }
            catch
            { 
                   outputLabel.Text = " please put a number in every space";
            }

        }

        private void taxShow_Click(object sender, EventArgs e)
        {

        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush taxBrush = new SolidBrush(Color.White);
            SolidBrush receiptBrush = new SolidBrush(Color.Black);

            Font receiptFont = new Font("Microsoft Sans Serif New", 9);
            formGraphics.FillRectangle(taxBrush, 600, 0, 500, 500);

            formGraphics.DrawString("Your Ordered", receiptFont, receiptBrush, 670, 35);
            formGraphics.DrawString("Poodles Ordered;    " +poodle, receiptFont, receiptBrush, 650, 70);
            formGraphics.DrawString("Pugs Ordered;       " +pug, receiptFont, receiptBrush, 650, 90);
            formGraphics.DrawString("Shih Tzu's Ordered;  " +shihtzu, receiptFont, receiptBrush, 650, 110);
            formGraphics.DrawString("Shot price added;   " +shots, receiptFont, receiptBrush, 650, 130);
            formGraphics.DrawString("Total Comes to;     " +price.ToString("C"), receiptFont, receiptBrush, 650, 150);
            formGraphics.DrawString("Tax;                " +tax.ToString("C"), receiptFont, receiptBrush, 650, 170);
            formGraphics.DrawString("Your total with tax " +pricewithtax.ToString("C"), receiptFont, receiptBrush, 650, 190);
            formGraphics.DrawString("Thank you           " + receiptFont, receiptFont, 650, 200);





        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountInput.Text);

            change = amount - pricewithtax;

            changeLabel.Text = change.ToString("C");

        }
    }
}
