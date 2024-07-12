using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalvinFoodWars
{
    public partial class FormShop : Form
    {
        FormMenu form;
        Players players;
        public Buff freeze;
        public Buff boost;
        public Skin merchZeta;
        public Skin tumblerZeta;
        int income;
        public FormShop()
        {
            InitializeComponent();
        }

        private void labelDisplayFreeze_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuyBoost_Click(object sender, EventArgs e)
        {
        }

        private void buttonBuyFreeze_Click(object sender, EventArgs e)
        {
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            players = form.player;
            form.currentIncome = players.Income;
        }

        private void FormShop_Load(object sender, EventArgs e)
        {
            form = (FormMenu)this.Owner;
            //comboBoxPlayers.DataSource = form.listPlayer;
            //comboBoxPlayers.DisplayMember = "Name";
            freeze = form.freeze;
            boost = form.boost;
            players = form.player;
            merchZeta = form.merchZeta;
            tumblerZeta = form.tumblerZeta;
            players = form.player;
            labelPriceBoost.Text = boost.Price.ToString();
            labelPriceFreeze.Text = freeze.Price.ToString();
            labelPriceMerch.Text = merchZeta.Price.ToString();
            labelPriceTumbler.Text = tumblerZeta.Price.ToString();
            labelDescBoost.Text = boost.Display();
            labelDescFreeze.Text = freeze.Display();
            labelDescMerch.Text = merchZeta.Display();
            labelDescTumbler.Text = tumblerZeta.Display();
            labelFrRem.Text = "Stock :" + freeze.Stock.ToString();
            labelBoostRemaining.Text = "Stock : "+boost.Stock.ToString();
            if (merchZeta.Purchased == false)
            {
                labelMerchAvailable.Text = "Not Obtained";
            }
            else if(merchZeta.Purchased == true)
            {
                labelMerchAvailable.Text = "Obtained";
                buttonBuyMerch.Text = "Purchased";
                buttonBuyMerch.Enabled = false;
            }
            if (tumblerZeta.Purchased == false)
            {
                labelTumblerAvailable.Text = "Not Obtained";
            }
            else if(tumblerZeta.Purchased == true)
            {
                labelTumblerAvailable.Text = "Obtained";
                buttonBuyTumbler.Text = "Purchased";
                buttonBuyTumbler.Enabled = false;
            }
            labelCurrency.Text = "Income : "+players.Income.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                players = form.player;
                //players = (Players)comboBoxPlayers.SelectedItem;
                income = players.Income;
                players.Income = boost.Sell(income);
                labelBoostRemaining.Text = "Stock : " + boost.Stock.ToString();
                labelCurrency.Text = "Income : " + players.Income.ToString();
                form.PlaySound("correct");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBuyFreeze_Click_1(object sender, EventArgs e)
        {
            try
            {
                players = form.player;
                //players = (Players)comboBoxPlayers.SelectedItem;
                income = players.Income;
                players.Income = freeze.Sell(income);
                labelFrRem.Text = "Stock :"+ freeze.Stock.ToString();
                labelCurrency.Text = "Income : " + players.Income.ToString();
                form.PlaySound("correct");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void FormShop_FormClosing(object sender, FormClosingEventArgs e)
        {
            players = form.player;
            form.currentIncome = players.Income;
        }

        private void buttonBuyMerch_Click(object sender, EventArgs e)
        {
            try
            {
                players = form.player;
                income = players.Income;
                players.Income = merchZeta.Sell(income);
                labelMerchAvailable.Text = "Obtained";
                labelCurrency.Text = "Income : " + players.Income.ToString();
                form.currentIncome = income;
                form.PlaySound("correct");
                buttonBuyMerch.Text = "Purchased";
                buttonBuyMerch.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void buttonBuyTumbler_Click(object sender, EventArgs e)
        {
            try
            {
                players = form.player;
                income = players.Income;
                players.Income = tumblerZeta.Sell(income);
                labelTumblerAvailable.Text = "Obtained";
                labelCurrency.Text = "Income : " + players.Income.ToString();
                form.currentIncome = income;
                form.PlaySound("correct");
                buttonBuyTumbler.Text = "Purchased";
                buttonBuyTumbler.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
