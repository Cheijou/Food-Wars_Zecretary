namespace CalvinFoodWars
{
    partial class FormShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelBoost = new System.Windows.Forms.Panel();
            this.labelBoostRemaining = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelDescBoost = new System.Windows.Forms.Label();
            this.labelPriceBoost = new System.Windows.Forms.Label();
            this.buttonBuyBoost = new System.Windows.Forms.Button();
            this.labelNameBoost = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panelFreeze = new System.Windows.Forms.Panel();
            this.labelFrRem = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.labelDescFreeze = new System.Windows.Forms.Label();
            this.labelPriceFreeze = new System.Windows.Forms.Label();
            this.buttonBuyFreeze = new System.Windows.Forms.Button();
            this.labelNameFreeze = new System.Windows.Forms.Label();
            this.pictureBoxFreeze = new System.Windows.Forms.PictureBox();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.comboBoxPlayers = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelBoost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panelFreeze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFreeze)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(465, 473);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(83, 35);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelBoost
            // 
            this.panelBoost.BackColor = System.Drawing.Color.Yellow;
            this.panelBoost.Controls.Add(this.labelBoostRemaining);
            this.panelBoost.Controls.Add(this.pictureBox4);
            this.panelBoost.Controls.Add(this.labelDescBoost);
            this.panelBoost.Controls.Add(this.labelPriceBoost);
            this.panelBoost.Controls.Add(this.buttonBuyBoost);
            this.panelBoost.Controls.Add(this.labelNameBoost);
            this.panelBoost.Controls.Add(this.pictureBox6);
            this.panelBoost.Location = new System.Drawing.Point(238, 41);
            this.panelBoost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBoost.Name = "panelBoost";
            this.panelBoost.Size = new System.Drawing.Size(150, 278);
            this.panelBoost.TabIndex = 33;
            // 
            // labelBoostRemaining
            // 
            this.labelBoostRemaining.AutoSize = true;
            this.labelBoostRemaining.BackColor = System.Drawing.Color.Transparent;
            this.labelBoostRemaining.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBoostRemaining.Location = new System.Drawing.Point(38, 250);
            this.labelBoostRemaining.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBoostRemaining.Name = "labelBoostRemaining";
            this.labelBoostRemaining.Size = new System.Drawing.Size(66, 17);
            this.labelBoostRemaining.TabIndex = 31;
            this.labelBoostRemaining.Text = "labelBoost";
            this.labelBoostRemaining.Click += new System.EventHandler(this.labelBoostRemaining_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CalvinFoodWars.Properties.Resources.money;
            this.pictureBox4.Location = new System.Drawing.Point(31, 173);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // labelDescBoost
            // 
            this.labelDescBoost.AutoSize = true;
            this.labelDescBoost.BackColor = System.Drawing.Color.White;
            this.labelDescBoost.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescBoost.Location = new System.Drawing.Point(20, 200);
            this.labelDescBoost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescBoost.Name = "labelDescBoost";
            this.labelDescBoost.Size = new System.Drawing.Size(66, 17);
            this.labelDescBoost.TabIndex = 5;
            this.labelDescBoost.Text = "labelBoost";
            // 
            // labelPriceBoost
            // 
            this.labelPriceBoost.AutoSize = true;
            this.labelPriceBoost.BackColor = System.Drawing.Color.White;
            this.labelPriceBoost.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceBoost.Location = new System.Drawing.Point(60, 178);
            this.labelPriceBoost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPriceBoost.Name = "labelPriceBoost";
            this.labelPriceBoost.Size = new System.Drawing.Size(48, 17);
            this.labelPriceBoost.TabIndex = 4;
            this.labelPriceBoost.Text = "100000";
            // 
            // buttonBuyBoost
            // 
            this.buttonBuyBoost.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuyBoost.Location = new System.Drawing.Point(44, 152);
            this.buttonBuyBoost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuyBoost.Name = "buttonBuyBoost";
            this.buttonBuyBoost.Size = new System.Drawing.Size(60, 23);
            this.buttonBuyBoost.TabIndex = 3;
            this.buttonBuyBoost.Text = "Buy";
            this.buttonBuyBoost.UseVisualStyleBackColor = true;
            this.buttonBuyBoost.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNameBoost
            // 
            this.labelNameBoost.AutoSize = true;
            this.labelNameBoost.BackColor = System.Drawing.Color.White;
            this.labelNameBoost.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameBoost.Location = new System.Drawing.Point(38, 127);
            this.labelNameBoost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameBoost.Name = "labelNameBoost";
            this.labelNameBoost.Size = new System.Drawing.Size(78, 17);
            this.labelNameBoost.TabIndex = 1;
            this.labelNameBoost.Text = "Money Boost";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Image = global::CalvinFoodWars.Properties.Resources.doublemoney;
            this.pictureBox6.Location = new System.Drawing.Point(10, 9);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(133, 129);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // panelFreeze
            // 
            this.panelFreeze.BackColor = System.Drawing.Color.Aquamarine;
            this.panelFreeze.Controls.Add(this.labelFrRem);
            this.panelFreeze.Controls.Add(this.pictureBox5);
            this.panelFreeze.Controls.Add(this.labelDescFreeze);
            this.panelFreeze.Controls.Add(this.labelPriceFreeze);
            this.panelFreeze.Controls.Add(this.buttonBuyFreeze);
            this.panelFreeze.Controls.Add(this.labelNameFreeze);
            this.panelFreeze.Controls.Add(this.pictureBoxFreeze);
            this.panelFreeze.Location = new System.Drawing.Point(25, 41);
            this.panelFreeze.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFreeze.Name = "panelFreeze";
            this.panelFreeze.Size = new System.Drawing.Size(150, 278);
            this.panelFreeze.TabIndex = 34;
            // 
            // labelFrRem
            // 
            this.labelFrRem.AutoSize = true;
            this.labelFrRem.BackColor = System.Drawing.Color.Transparent;
            this.labelFrRem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrRem.Location = new System.Drawing.Point(38, 250);
            this.labelFrRem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFrRem.Name = "labelFrRem";
            this.labelFrRem.Size = new System.Drawing.Size(71, 17);
            this.labelFrRem.TabIndex = 31;
            this.labelFrRem.Text = "labelFreeze";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CalvinFoodWars.Properties.Resources.money;
            this.pictureBox5.Location = new System.Drawing.Point(31, 173);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            // 
            // labelDescFreeze
            // 
            this.labelDescFreeze.AutoSize = true;
            this.labelDescFreeze.BackColor = System.Drawing.Color.White;
            this.labelDescFreeze.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescFreeze.Location = new System.Drawing.Point(28, 200);
            this.labelDescFreeze.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescFreeze.Name = "labelDescFreeze";
            this.labelDescFreeze.Size = new System.Drawing.Size(71, 17);
            this.labelDescFreeze.TabIndex = 5;
            this.labelDescFreeze.Text = "labelFreeze";
            // 
            // labelPriceFreeze
            // 
            this.labelPriceFreeze.AutoSize = true;
            this.labelPriceFreeze.BackColor = System.Drawing.Color.White;
            this.labelPriceFreeze.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceFreeze.Location = new System.Drawing.Point(60, 178);
            this.labelPriceFreeze.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPriceFreeze.Name = "labelPriceFreeze";
            this.labelPriceFreeze.Size = new System.Drawing.Size(43, 17);
            this.labelPriceFreeze.TabIndex = 4;
            this.labelPriceFreeze.Text = "50000";
            // 
            // buttonBuyFreeze
            // 
            this.buttonBuyFreeze.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuyFreeze.Location = new System.Drawing.Point(44, 152);
            this.buttonBuyFreeze.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuyFreeze.Name = "buttonBuyFreeze";
            this.buttonBuyFreeze.Size = new System.Drawing.Size(60, 23);
            this.buttonBuyFreeze.TabIndex = 3;
            this.buttonBuyFreeze.Text = "Buy";
            this.buttonBuyFreeze.UseVisualStyleBackColor = true;
            this.buttonBuyFreeze.Click += new System.EventHandler(this.buttonBuyFreeze_Click_1);
            // 
            // labelNameFreeze
            // 
            this.labelNameFreeze.AutoSize = true;
            this.labelNameFreeze.BackColor = System.Drawing.Color.White;
            this.labelNameFreeze.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameFreeze.Location = new System.Drawing.Point(38, 127);
            this.labelNameFreeze.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameFreeze.Name = "labelNameFreeze";
            this.labelNameFreeze.Size = new System.Drawing.Size(75, 17);
            this.labelNameFreeze.TabIndex = 1;
            this.labelNameFreeze.Text = "Time Freeze";
            // 
            // pictureBoxFreeze
            // 
            this.pictureBoxFreeze.BackColor = System.Drawing.Color.Turquoise;
            this.pictureBoxFreeze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFreeze.Image = global::CalvinFoodWars.Properties.Resources.freeze;
            this.pictureBoxFreeze.Location = new System.Drawing.Point(10, 9);
            this.pictureBoxFreeze.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxFreeze.Name = "pictureBoxFreeze";
            this.pictureBoxFreeze.Size = new System.Drawing.Size(133, 129);
            this.pictureBoxFreeze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFreeze.TabIndex = 0;
            this.pictureBoxFreeze.TabStop = false;
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrency.Location = new System.Drawing.Point(416, 11);
            this.labelCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(113, 23);
            this.labelCurrency.TabIndex = 35;
            this.labelCurrency.Text = "labelCurrency";
            // 
            // comboBoxPlayers
            // 
            this.comboBoxPlayers.FormattingEnabled = true;
            this.comboBoxPlayers.Location = new System.Drawing.Point(25, 11);
            this.comboBoxPlayers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPlayers.Name = "comboBoxPlayers";
            this.comboBoxPlayers.Size = new System.Drawing.Size(113, 21);
            this.comboBoxPlayers.TabIndex = 36;
            this.comboBoxPlayers.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(568, 530);
            this.Controls.Add(this.comboBoxPlayers);
            this.Controls.Add(this.labelCurrency);
            this.Controls.Add(this.panelFreeze);
            this.Controls.Add(this.panelBoost);
            this.Controls.Add(this.buttonExit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormShop";
            this.Text = "FormShop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormShop_FormClosing);
            this.Load += new System.EventHandler(this.FormShop_Load);
            this.panelBoost.ResumeLayout(false);
            this.panelBoost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panelFreeze.ResumeLayout(false);
            this.panelFreeze.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFreeze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelBoost;
        private System.Windows.Forms.Label labelBoostRemaining;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelDescBoost;
        private System.Windows.Forms.Label labelPriceBoost;
        private System.Windows.Forms.Button buttonBuyBoost;
        private System.Windows.Forms.Label labelNameBoost;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panelFreeze;
        private System.Windows.Forms.Label labelFrRem;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label labelDescFreeze;
        private System.Windows.Forms.Label labelPriceFreeze;
        private System.Windows.Forms.Button buttonBuyFreeze;
        private System.Windows.Forms.Label labelNameFreeze;
        private System.Windows.Forms.PictureBox pictureBoxFreeze;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.ComboBox comboBoxPlayers;
        private System.Windows.Forms.Timer timer1;
    }
}