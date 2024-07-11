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
            form.currentIncome = players.Income;
        }

        private void FormShop_Load(object sender, EventArgs e)
        {
            form = (FormMenu)this.Owner;
            comboBoxPlayers.DataSource = form.listPlayer;
            comboBoxPlayers.DisplayMember = "Name";
            freeze = form.freeze;
            boost = form.boost;
            labelPriceBoost.Text = boost.Price.ToString();
            labelPriceFreeze.Text = freeze.Price.ToString();
            labelDescBoost.Text = boost.Display();
            labelDescFreeze.Text = freeze.Display();
            labelFrRem.Text = freeze.Stock.ToString();
            labelBoostRemaining.Text = boost.Stock.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            players = (Players)comboBoxPlayers.SelectedItem;
            labelCurrency.Text = "Income : "+players.Income.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                players = (Players)comboBoxPlayers.SelectedItem;
                int income = players.Income;
                players.Income = boost.Sell(income);
                labelBoostRemaining.Text = boost.Stock.ToString();
                labelCurrency.Text = "Income : " + players.Income.ToString();
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
                players = (Players)comboBoxPlayers.SelectedItem;
                int income = players.Income;
                players.Income = freeze.Sell(income);
                labelFrRem.Text = freeze.Stock.ToString();
                labelCurrency.Text = "Income : " + players.Income.ToString();
                form.currentIncome = income;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelBoostRemaining_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void FormShop_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.currentIncome = players.Income;
        }
    }
}
