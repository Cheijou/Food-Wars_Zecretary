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
    public partial class FormCredit : Form
    {
        FormMenu formMain;
        public FormCredit()
        {
            InitializeComponent();
        }

        private void FormCredit_Load(object sender, EventArgs e)
        {
            formMain = (FormMenu)this.Owner;
            pictureBoxBack.Visible = false;
            pictureBoxBack.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox1.Enabled = true; 
            labelZec.Visible = true;
            labelCal.Visible = true;
            labelFelik.Visible = true;
            labelRen.Visible = true;
            labelpage2.Visible = false;
            labepage21.Visible = false;
            labelpage22.Visible = false;
            labelpage23.Visible = false;
            labelpage24.Visible = false;
            labelpage25.Visible = false;
            labelpage26.Visible = false;
            labelpage27.Visible = false;
            labelpage28.Visible = false;
            labelpage29.Visible = false;
            labelpage30.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBoxBack.Visible = true;
            pictureBoxBack.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox1.Enabled = false;
            labelZec.Visible = false;
            labelCal.Visible = false;
            labelFelik.Visible = false;
            labelRen.Visible = false;
            labelpage2.Visible = true;
            labepage21.Visible = true;
            labelpage22.Visible = true;
            labelpage23.Visible = true;
            labelpage24.Visible = true;
            labelpage25.Visible = true;
            labelpage26.Visible = true;
            labelpage27.Visible = true;
            labelpage28.Visible = true;
            labelpage30.Visible = true;
            labelpage29.Visible = true;
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            pictureBoxBack.Visible = false;
            pictureBoxBack.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox1.Enabled = true;
            labelZec.Visible = true;
            labelCal.Visible = true;
            labelFelik.Visible = true;
            labelRen.Visible = true;
            labelpage2.Visible = false;
            labepage21.Visible = false;
            labelpage22.Visible = false;
            labelpage23.Visible = false;
            labelpage24.Visible = false;
            labelpage25.Visible = false;
            labelpage26.Visible = false;
            labelpage27.Visible = false;
            labelpage28.Visible = false;
            labelpage29.Visible = false;
            labelpage30.Visible = false;
        }

        
    }
}
