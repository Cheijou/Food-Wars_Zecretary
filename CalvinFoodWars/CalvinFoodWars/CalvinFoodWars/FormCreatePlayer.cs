﻿using System;
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
        public Players player;
        public Time recordedTime;
        public FormCreatePlayer()
        {
            InitializeComponent();
        }

        private void FormCreatePlayer_Load(object sender, EventArgs e)
        {
            formMain = (FormMenu)this.Owner;
        }
        private void CreatePlayer()
        {   
            //player = new Players("Calvin", 0, Properties.Resources.player, recordedTime);
            //listPlayer.Add(player);
            //labelName.Text = player.DisplayName();
            //labelIncome.Text = player.DisplayIncome();
            //labelPrevTime.Text = displayCurrent.DisplayTime();
            //labelCurrentIncome.Text = "Prev Income: " + incomePerGame.ToString();
            //pictureBoxPlayer.Image = player.Picture; 
        }
    }
}