using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchbillCalculatorApp
{
    public partial class Form1 : Form
    {
     
        private double tPrice=200;

        public Form1()
        {
            InitializeComponent();
        }


        private void showTotalButton_Click(object sender, EventArgs e)
        {
            //int aRice, bFish, cMeat,tprice,nunit=1,riceUnit=20,fishUnit=80,meatUnit=100 ;
            //aRice = Convert.ToInt32(riceTextBox.Text);
            //bFish = Convert.ToInt32(fishTextBox.Text);
            //cMeat = Convert.ToInt32(meatTextBox.Text);
            //aRice = nunit*riceUnit;
            //bFish = nunit*fishUnit;
            //cMeat = nunit*meatUnit;
            //tprice = aRice + bFish + cMeat;
            //totalGrossTextBox.Text = tprice.ToString();

            double aRice = Convert.ToDouble(riceTextBox.Text);
            double aFish = Convert.ToDouble(fishTextBox.Text);
            int meat = Convert.ToInt32(meatTextBox.Text);

            totalGrossTextBox.Text=
        }

        private void showNetButton_Click(object sender, EventArgs e)
        {
            double Discount ,dcount,vat=5;
            Discount = Convert.ToInt32(discountTextBox.Text);
            dcount = (Discount*vat)/100;
            MessageBox.Show( "Price"+tPrice);

        }
    }
}
