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
    public partial class FormEdit : Form
    {
        FormMenu formMain;
        bool plushieSelected;
        bool tumblerSelected;
        bool zetaMerchSelected;
        bool zetaTumblerSelected;
        public FormEdit()
        {
            InitializeComponent();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            formMain = (FormMenu)this.Owner;
            pictureBoxPlayer.Image = formMain.playerPicture;
            if (formMain.merchActive == true)
            {
                zetaMerchSelected = true;
                pictureBoxMerchZeta.Image = Properties.Resources.ZetaMerch;
                plushieSelected = false;
                pictureBoxPlushie.Image = Properties.Resources.plushieOff;
            }
            else
            {
                zetaMerchSelected = false;
                pictureBoxMerchZeta.Image = Properties.Resources.zetaMerchOff;
                plushieSelected = true;
                pictureBoxPlushie.Image = Properties.Resources.plushie;
            }
            if (formMain.tumblerActive == true)
            {
                zetaTumblerSelected = true;
                pictureBoxTumblerZeta.Image = Properties.Resources.ZetaTumbler;
                tumblerSelected = false;
                pictureBoxTumbler.Image = Properties.Resources.tumblerOff;
            }
            else
            {
                zetaTumblerSelected = false;
                pictureBoxTumblerZeta.Image = Properties.Resources.zetaTumblerOff;
                tumblerSelected = true;
                pictureBoxTumbler.Image = Properties.Resources.tumbler;
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPlayer.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void pictureBoxPlushie_Click(object sender, EventArgs e)
        {
            formMain.PlaySound("quack");
            pictureBoxPlushie.Image = Properties.Resources.plushie;
            plushieSelected = true;
            zetaMerchSelected = false;
            pictureBoxMerchZeta.Image = Properties.Resources.zetaMerchOff;
        }

        private void pictureBoxMerchZeta_Click(object sender, EventArgs e)
        {
            if (formMain.merchZeta.Purchased == true)
            {
                formMain.PlaySound("zeta");
                zetaMerchSelected = true;
                pictureBoxMerchZeta.Image = Properties.Resources.ZetaMerch;
                plushieSelected = false;
                pictureBoxPlushie.Image = Properties.Resources.plushieOff;
            }
            else
            {
                MessageBox.Show("You need to obtain this item from shop.");
            }
        }

        private void pictureBoxTumbler_Click(object sender, EventArgs e)
        {
            pictureBoxTumbler.Image = Properties.Resources.tumbler;
            tumblerSelected = true;
            zetaTumblerSelected = false;
            pictureBoxTumblerZeta.Image = Properties.Resources.zetaTumblerOff;
        }

        private void pictureBoxTumblerZeta_Click(object sender, EventArgs e)
        {
            if (formMain.tumblerZeta.Purchased == true)
            {
                tumblerSelected = false;
                pictureBoxTumbler.Image = Properties.Resources.tumblerOff;
                zetaTumblerSelected = true;
                pictureBoxTumblerZeta.Image = Properties.Resources.ZetaTumbler;
            }
            else
            {
                MessageBox.Show("You need to obtain this item from shop.");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (zetaTumblerSelected == true)
            {
                formMain.tumblerActive = true;
            }
            else
            {
                formMain.tumblerActive = false;
            }

            if (zetaMerchSelected == true) 
            {
                formMain.merchActive = true;
            }
            else
            {
                formMain.merchActive = false;
            }
            if (textBoxName.Text != "")
            {
                formMain.playerName = textBoxName.Text;
            }
            formMain.playerPicture = pictureBoxPlayer.Image;
            MessageBox.Show("Changes saved successfully!");
        }
    }
}
