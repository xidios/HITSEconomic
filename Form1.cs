using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HITSEconomic
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        double price;
        int days_count = 0;
        int days;
        double rub = 3000;
        double usd = 0;
        double m = 0.0005, sig = 0.05;

        public Form1()
        {
            InitializeComponent();
            daysCount.Value = 99;
            startPrice.Value = 60;
            buyAndSell.Value = 10;
        }


        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            days_count = 0;
            rub = 1000;
            usd = 0;

            chart1.Series[0].Points.Clear();
            price = (double)startPrice.Value;
            days = (int)daysCount.Value;
            chart1.Series[0].Points.AddXY(0, price);
            ChangeAmount();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (days_count <= days)
            {
                days_count++;
                double randNum = rand.NextDouble() * 12 - 6;
                price = Math.Round(price * Math.Exp(m - Math.Pow(sig, 2) / 2) + sig * (randNum + (Math.Pow(randNum, 3) - 3 * randNum) / 240), 3);
                chart1.Series[0].Points.AddXY(days_count, price);
            }
            else
            {
                timer1.Stop();
            }
        }


        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            double money = (double)buyAndSell.Value;
            rub -= money * price;
            if (rub < 0)
            {
                timer1.Stop();
            }
            else
            {
                usd += money;

            }
            ChangeAmount();
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            double money = (double)buyAndSell.Value;
            usd -= money;
            if (usd < 0)
            {
                timer1.Stop();
            }
            else
            {
                rub += money * price;

            }
            ChangeAmount();
        }

        private void ChangeAmount()
        {
            AmountOfRubles.Text = rub.ToString();
            AmountOfEuro.Text = usd.ToString();
        }
    }
}
