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
        Buff buff;
        ItemsShop item;
        Players players;
        Buff freeze;
        Buff boost;
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
        }

        private void FormShop_Load(object sender, EventArgs e)
        {
            form = (FormMenu)this.Owner;
            comboBoxPlayers.DataSource = form.listPlayer;
            comboBoxPlayers.DisplayMember = "Name";
            freeze = new Buff("freeze", 50000, Properties.Resources.freeze);
            boost = new Buff("boost", 100000, Properties.Resources.doublemoney);
            labelPriceBoost.Text = boost.Price.ToString();
            labelPriceFreeze.Text = freeze.Price.ToString();
            labelDescBoost.Text = boost.Display();
            labelDescFreeze.Text = freeze.Display();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            players = (Players)comboBoxPlayers.SelectedItem;
            labelCurrency.Text = players.Income.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            item.Sell();
            labelBoostRemaining.Text = boost.Stock.ToString();

        }

        private void buttonBuyFreeze_Click_1(object sender, EventArgs e)
        {
            item.Sell();
            labelFrRem.Text = freeze.Stock.ToString();
        }

        private void labelBoostRemaining_Click(object sender, EventArgs e)
        {

        }
    }
}
