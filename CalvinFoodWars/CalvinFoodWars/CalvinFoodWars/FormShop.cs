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
        }
    }
}
