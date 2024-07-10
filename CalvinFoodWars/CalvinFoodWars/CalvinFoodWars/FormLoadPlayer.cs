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
    public partial class FormLoadPlayer : Form
    {
        FormMenu formMain;
        Players currentPlayer;
        public FormLoadPlayer()
        {
            InitializeComponent();
        }

        private void FormLoadPlayer_Load(object sender, EventArgs e)
        {
            formMain = (FormMenu)this.Owner;
            comboBoxPlayers.DataSource = formMain.listPlayers;
            comboBoxPlayers.DisplayMember = "Name";
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            currentPlayer = (Players)comboBoxPlayers.SelectedItem;
            MessageBox.Show("Player Loaded Successfully!");
            formMain.ProfileSet(currentPlayer);
        }
    }
}
