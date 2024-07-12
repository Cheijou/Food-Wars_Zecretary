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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMerchAvailable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDescMerch = new System.Windows.Forms.Label();
            this.labelPriceMerch = new System.Windows.Forms.Label();
            this.buttonBuyMerch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTumblerAvailable = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelDescTumbler = new System.Windows.Forms.Label();
            this.labelPriceTumbler = new System.Windows.Forms.Label();
            this.buttonBuyTumbler = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panelBoost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panelFreeze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFreeze)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(613, 349);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
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
            this.panelBoost.Location = new System.Drawing.Point(200, 41);
            this.panelBoost.Margin = new System.Windows.Forms.Padding(2);
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
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CalvinFoodWars.Properties.Resources.money;
            this.pictureBox4.Location = new System.Drawing.Point(31, 173);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
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
            this.buttonBuyBoost.Margin = new System.Windows.Forms.Padding(2);
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
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
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
            this.panelFreeze.Margin = new System.Windows.Forms.Padding(2);
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
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
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
            this.buttonBuyFreeze.Margin = new System.Windows.Forms.Padding(2);
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
            this.pictureBoxFreeze.Margin = new System.Windows.Forms.Padding(2);
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
            this.labelCurrency.Location = new System.Drawing.Point(550, 7);
            this.labelCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(113, 23);
            this.labelCurrency.TabIndex = 35;
            this.labelCurrency.Text = "labelCurrency";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.labelMerchAvailable);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelDescMerch);
            this.panel1.Controls.Add(this.labelPriceMerch);
            this.panel1.Controls.Add(this.buttonBuyMerch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(368, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 278);
            this.panel1.TabIndex = 34;
            // 
            // labelMerchAvailable
            // 
            this.labelMerchAvailable.AutoSize = true;
            this.labelMerchAvailable.BackColor = System.Drawing.Color.Transparent;
            this.labelMerchAvailable.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMerchAvailable.Location = new System.Drawing.Point(38, 250);
            this.labelMerchAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMerchAvailable.Name = "labelMerchAvailable";
            this.labelMerchAvailable.Size = new System.Drawing.Size(68, 17);
            this.labelMerchAvailable.TabIndex = 31;
            this.labelMerchAvailable.Text = "labelMerch";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalvinFoodWars.Properties.Resources.money;
            this.pictureBox1.Location = new System.Drawing.Point(31, 173);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // labelDescMerch
            // 
            this.labelDescMerch.AutoSize = true;
            this.labelDescMerch.BackColor = System.Drawing.Color.White;
            this.labelDescMerch.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescMerch.Location = new System.Drawing.Point(7, 200);
            this.labelDescMerch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescMerch.Name = "labelDescMerch";
            this.labelDescMerch.Size = new System.Drawing.Size(66, 17);
            this.labelDescMerch.TabIndex = 5;
            this.labelDescMerch.Text = "labelBoost";
            // 
            // labelPriceMerch
            // 
            this.labelPriceMerch.AutoSize = true;
            this.labelPriceMerch.BackColor = System.Drawing.Color.White;
            this.labelPriceMerch.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceMerch.Location = new System.Drawing.Point(60, 178);
            this.labelPriceMerch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPriceMerch.Name = "labelPriceMerch";
            this.labelPriceMerch.Size = new System.Drawing.Size(48, 17);
            this.labelPriceMerch.TabIndex = 4;
            this.labelPriceMerch.Text = "100000";
            // 
            // buttonBuyMerch
            // 
            this.buttonBuyMerch.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuyMerch.Location = new System.Drawing.Point(24, 152);
            this.buttonBuyMerch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuyMerch.Name = "buttonBuyMerch";
            this.buttonBuyMerch.Size = new System.Drawing.Size(101, 23);
            this.buttonBuyMerch.TabIndex = 3;
            this.buttonBuyMerch.Text = "Buy";
            this.buttonBuyMerch.UseVisualStyleBackColor = true;
            this.buttonBuyMerch.Click += new System.EventHandler(this.buttonBuyMerch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Zeta Merch";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::CalvinFoodWars.Properties.Resources.ZetaMerch;
            this.pictureBox2.Location = new System.Drawing.Point(10, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.labelTumblerAvailable);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.labelDescTumbler);
            this.panel2.Controls.Add(this.labelPriceTumbler);
            this.panel2.Controls.Add(this.buttonBuyTumbler);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Location = new System.Drawing.Point(536, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 278);
            this.panel2.TabIndex = 37;
            // 
            // labelTumblerAvailable
            // 
            this.labelTumblerAvailable.AutoSize = true;
            this.labelTumblerAvailable.BackColor = System.Drawing.Color.Transparent;
            this.labelTumblerAvailable.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTumblerAvailable.Location = new System.Drawing.Point(38, 250);
            this.labelTumblerAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTumblerAvailable.Name = "labelTumblerAvailable";
            this.labelTumblerAvailable.Size = new System.Drawing.Size(78, 17);
            this.labelTumblerAvailable.TabIndex = 31;
            this.labelTumblerAvailable.Text = "labelTumbler";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CalvinFoodWars.Properties.Resources.money;
            this.pictureBox3.Location = new System.Drawing.Point(31, 173);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // labelDescTumbler
            // 
            this.labelDescTumbler.AutoSize = true;
            this.labelDescTumbler.BackColor = System.Drawing.Color.White;
            this.labelDescTumbler.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescTumbler.Location = new System.Drawing.Point(7, 200);
            this.labelDescTumbler.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescTumbler.Name = "labelDescTumbler";
            this.labelDescTumbler.Size = new System.Drawing.Size(66, 17);
            this.labelDescTumbler.TabIndex = 5;
            this.labelDescTumbler.Text = "labelBoost";
            // 
            // labelPriceTumbler
            // 
            this.labelPriceTumbler.AutoSize = true;
            this.labelPriceTumbler.BackColor = System.Drawing.Color.White;
            this.labelPriceTumbler.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceTumbler.Location = new System.Drawing.Point(60, 178);
            this.labelPriceTumbler.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPriceTumbler.Name = "labelPriceTumbler";
            this.labelPriceTumbler.Size = new System.Drawing.Size(48, 17);
            this.labelPriceTumbler.TabIndex = 4;
            this.labelPriceTumbler.Text = "100000";
            // 
            // buttonBuyTumbler
            // 
            this.buttonBuyTumbler.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuyTumbler.Location = new System.Drawing.Point(31, 152);
            this.buttonBuyTumbler.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuyTumbler.Name = "buttonBuyTumbler";
            this.buttonBuyTumbler.Size = new System.Drawing.Size(89, 23);
            this.buttonBuyTumbler.TabIndex = 3;
            this.buttonBuyTumbler.Text = "Buy";
            this.buttonBuyTumbler.UseVisualStyleBackColor = true;
            this.buttonBuyTumbler.Click += new System.EventHandler(this.buttonBuyTumbler_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 127);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Zeta Tumbler";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Image = global::CalvinFoodWars.Properties.Resources.ZetaTumbler;
            this.pictureBox7.Location = new System.Drawing.Point(10, 9);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(133, 129);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(725, 404);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelCurrency);
            this.Controls.Add(this.panelFreeze);
            this.Controls.Add(this.panelBoost);
            this.Controls.Add(this.buttonExit);
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMerchAvailable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDescMerch;
        private System.Windows.Forms.Label labelPriceMerch;
        private System.Windows.Forms.Button buttonBuyMerch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTumblerAvailable;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelDescTumbler;
        private System.Windows.Forms.Label labelPriceTumbler;
        private System.Windows.Forms.Button buttonBuyTumbler;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}