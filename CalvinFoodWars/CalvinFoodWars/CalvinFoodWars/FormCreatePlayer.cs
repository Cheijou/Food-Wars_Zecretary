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
    
    public partial class FormCreatePlayer : Form
    {
        FormMenu formMain;
        public Players newPlayer;
        public Time recordedTime;
        public FormCreatePlayer()
        {
            InitializeComponent();
        }

        private void FormCreatePlayer_Load(object sender, EventArgs e)
        {
            formMain = (FormMenu)this.Owner;
            pictureBoxPlayer.Image = Properties.Resources.player;
        }
        private void CreatePlayer()
        {
            //player = new Players("Calvin", 0, Properties.Resources.player, recordedTime);
            //listPlayer.Add(player);
            //labelName.Text = player.DisplayName();
            //labelIncome.Text = player.DisplayIncome();
            //labelPrevTime.Text = displayCurrent.DisplayTime();
            //labelCurrentIncome.Text = "Prev Income: " + incomePerGame.ToString();
            //pictureBoxPlayer.Image = player.Picture; \
            recordedTime = new Time();
            newPlayer = new Players(textBoxName.Text, 0, pictureBoxPlayer.Image, recordedTime);
            formMain.listPlayer.Add(newPlayer);
            formMain.player = newPlayer;    
            //formMain.SaveToFilePlayers(formMain.playerFileName);
            this.Close();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPlayer.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBoxPlayer.Image == Properties.Resources.player)
                {
                    var result = MessageBox.Show("Set the profile picture to default?", "Profile picture not set", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        CreatePlayer();
                    }
                }
                else if (pictureBoxPlayer.Image != Properties.Resources.player) 
                {
                    CreatePlayer();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
