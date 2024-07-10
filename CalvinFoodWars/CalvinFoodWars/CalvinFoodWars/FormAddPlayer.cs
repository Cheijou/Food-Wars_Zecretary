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
    public partial class FormAddPlayer : Form
    {
        FormMenu formMain;
        Players newPlayer;
        Time newTime;
        public FormAddPlayer()
        {
            InitializeComponent();
        }

        private void FormAddPlayer_Load(object sender, EventArgs e)
        {
            formMain = (FormMenu)this.Owner;
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBoxPlayer.Image == Properties.Resources.player)
                {
                    var result = MessageBox.Show("Are you sure to set profile picture to default?", "Profile picture not changed", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        CreatePlayer();
                    }
                } 
                else
                {
                    CreatePlayer();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void CreatePlayer()
        {
            MessageBox.Show("Player added successfully!");
            newTime = new Time();
            newPlayer = new Players(textBoxInputName.Text, 0 , pictureBoxPlayer.Image, newTime);
            formMain.listPlayers.Add(newPlayer);
            formMain.SaveToFilePlayers(formMain.playerFileName);
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
    }
}
