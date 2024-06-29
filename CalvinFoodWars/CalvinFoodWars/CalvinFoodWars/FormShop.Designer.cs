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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDisplayFreeze = new System.Windows.Forms.Label();
            this.panelMoney = new System.Windows.Forms.Panel();
            this.labelDisplayBoost = new System.Windows.Forms.Label();
            this.buttonBuyBoost = new System.Windows.Forms.Button();
            this.buttonBuyFreeze = new System.Windows.Forms.Button();
            this.pictureBoxFreeze = new System.Windows.Forms.PictureBox();
            this.pictureBoxBoost = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelMoney.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFreeze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoost)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.buttonBuyFreeze);
            this.panel1.Controls.Add(this.labelDisplayFreeze);
            this.panel1.Controls.Add(this.pictureBoxFreeze);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 228);
            this.panel1.TabIndex = 2;
            // 
            // labelDisplayFreeze
            // 
            this.labelDisplayFreeze.AutoSize = true;
            this.labelDisplayFreeze.BackColor = System.Drawing.Color.Transparent;
            this.labelDisplayFreeze.Location = new System.Drawing.Point(20, 187);
            this.labelDisplayFreeze.Name = "labelDisplayFreeze";
            this.labelDisplayFreeze.Size = new System.Drawing.Size(79, 16);
            this.labelDisplayFreeze.TabIndex = 1;
            this.labelDisplayFreeze.Text = "labelFreeze";
            this.labelDisplayFreeze.Click += new System.EventHandler(this.labelDisplayFreeze_Click);
            // 
            // panelMoney
            // 
            this.panelMoney.BackColor = System.Drawing.Color.Orange;
            this.panelMoney.Controls.Add(this.buttonBuyBoost);
            this.panelMoney.Controls.Add(this.labelDisplayBoost);
            this.panelMoney.Controls.Add(this.pictureBoxBoost);
            this.panelMoney.Location = new System.Drawing.Point(238, 12);
            this.panelMoney.Name = "panelMoney";
            this.panelMoney.Size = new System.Drawing.Size(186, 228);
            this.panelMoney.TabIndex = 3;
            // 
            // labelDisplayBoost
            // 
            this.labelDisplayBoost.AutoSize = true;
            this.labelDisplayBoost.BackColor = System.Drawing.Color.Transparent;
            this.labelDisplayBoost.Location = new System.Drawing.Point(22, 187);
            this.labelDisplayBoost.Name = "labelDisplayBoost";
            this.labelDisplayBoost.Size = new System.Drawing.Size(72, 16);
            this.labelDisplayBoost.TabIndex = 1;
            this.labelDisplayBoost.Text = "labelBoost";
            // 
            // buttonBuyBoost
            // 
            this.buttonBuyBoost.Location = new System.Drawing.Point(51, 153);
            this.buttonBuyBoost.Name = "buttonBuyBoost";
            this.buttonBuyBoost.Size = new System.Drawing.Size(75, 23);
            this.buttonBuyBoost.TabIndex = 2;
            this.buttonBuyBoost.Text = "Buy";
            this.buttonBuyBoost.UseVisualStyleBackColor = true;
            this.buttonBuyBoost.Click += new System.EventHandler(this.buttonBuyBoost_Click);
            // 
            // buttonBuyFreeze
            // 
            this.buttonBuyFreeze.Location = new System.Drawing.Point(51, 153);
            this.buttonBuyFreeze.Name = "buttonBuyFreeze";
            this.buttonBuyFreeze.Size = new System.Drawing.Size(75, 23);
            this.buttonBuyFreeze.TabIndex = 3;
            this.buttonBuyFreeze.Text = "Buy";
            this.buttonBuyFreeze.UseVisualStyleBackColor = true;
            this.buttonBuyFreeze.Click += new System.EventHandler(this.buttonBuyFreeze_Click);
            // 
            // pictureBoxFreeze
            // 
            this.pictureBoxFreeze.BackColor = System.Drawing.Color.Turquoise;
            this.pictureBoxFreeze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFreeze.Image = global::CalvinFoodWars.Properties.Resources.Freeze;
            this.pictureBoxFreeze.Location = new System.Drawing.Point(23, 16);
            this.pictureBoxFreeze.Name = "pictureBoxFreeze";
            this.pictureBoxFreeze.Size = new System.Drawing.Size(133, 127);
            this.pictureBoxFreeze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFreeze.TabIndex = 0;
            this.pictureBoxFreeze.TabStop = false;
            // 
            // pictureBoxBoost
            // 
            this.pictureBoxBoost.BackColor = System.Drawing.Color.White;
            this.pictureBoxBoost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBoost.Image = global::CalvinFoodWars.Properties.Resources.Boost;
            this.pictureBoxBoost.Location = new System.Drawing.Point(25, 16);
            this.pictureBoxBoost.Name = "pictureBoxBoost";
            this.pictureBoxBoost.Size = new System.Drawing.Size(133, 127);
            this.pictureBoxBoost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBoost.TabIndex = 0;
            this.pictureBoxBoost.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(542, 406);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(111, 43);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(682, 461);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMoney);
            this.Name = "FormShop";
            this.Text = "FormShop";
            this.Load += new System.EventHandler(this.FormShop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMoney.ResumeLayout(false);
            this.panelMoney.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFreeze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDisplayFreeze;
        private System.Windows.Forms.PictureBox pictureBoxFreeze;
        private System.Windows.Forms.Panel panelMoney;
        private System.Windows.Forms.Label labelDisplayBoost;
        private System.Windows.Forms.PictureBox pictureBoxBoost;
        private System.Windows.Forms.Button buttonBuyBoost;
        private System.Windows.Forms.Button buttonBuyFreeze;
        private System.Windows.Forms.Button buttonExit;
    }
}