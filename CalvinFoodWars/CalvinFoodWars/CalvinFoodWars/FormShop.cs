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
        public FormShop(Players player)
        {
            InitializeComponent();
            players = player;
        }

        private void labelDisplayFreeze_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuyBoost_Click(object sender, EventArgs e)
        {
            item = new Buff("boost", 200000, Properties.Resources.doublemoney, players);
            item.Sell("boost");
        }

        private void buttonBuyFreeze_Click(object sender, EventArgs e)
        {
            item = new Buff("freeze", 100000, Properties.Resources.freeze, players);
            item.Sell("");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormShop_Load(object sender, EventArgs e)
        {
            form = (FormMenu)this.Owner;
        }
    }
}
