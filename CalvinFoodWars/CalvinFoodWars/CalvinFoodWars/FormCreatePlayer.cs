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
        public string name;
        Players newPlayer;
        public Image picture;
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
            try
            {
                formMain.playerName = textBoxName.Text;
                newPlayer = new Players (textBoxName.Text,0,pictureBoxPlayer.Image,null);
                formMain.playerPicture = pictureBoxPlayer.Image;
                MessageBox.Show("Player created successfully!");
                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
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

        private void FormCreatePlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            {
                if (formMain.playerName == "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Please create a player");
                }
            }
        }
    }
}
