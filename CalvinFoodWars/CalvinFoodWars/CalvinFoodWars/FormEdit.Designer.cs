namespace CalvinFoodWars
{
    partial class FormEdit
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
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxPlushie = new System.Windows.Forms.PictureBox();
            this.pictureBoxMerchZeta = new System.Windows.Forms.PictureBox();
            this.pictureBoxTumbler = new System.Windows.Forms.PictureBox();
            this.pictureBoxTumblerZeta = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlushie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMerchZeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTumbler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTumblerZeta)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.Image = global::CalvinFoodWars.Properties.Resources.player;
            this.pictureBoxPlayer.Location = new System.Drawing.Point(354, 77);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(119, 111);
            this.pictureBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer.TabIndex = 27;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.Location = new System.Drawing.Point(219, 110);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(120, 35);
            this.buttonChange.TabIndex = 26;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "Profile picture :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(219, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(156, 20);
            this.textBoxName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Edit username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Select Merchant :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 26);
            this.label4.TabIndex = 29;
            this.label4.Text = "Select Tumbler :";
            // 
            // pictureBoxPlushie
            // 
            this.pictureBoxPlushie.Image = global::CalvinFoodWars.Properties.Resources.plushie;
            this.pictureBoxPlushie.Location = new System.Drawing.Point(219, 210);
            this.pictureBoxPlushie.Name = "pictureBoxPlushie";
            this.pictureBoxPlushie.Size = new System.Drawing.Size(119, 111);
            this.pictureBoxPlushie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlushie.TabIndex = 30;
            this.pictureBoxPlushie.TabStop = false;
            this.pictureBoxPlushie.Click += new System.EventHandler(this.pictureBoxPlushie_Click);
            // 
            // pictureBoxMerchZeta
            // 
            this.pictureBoxMerchZeta.Image = global::CalvinFoodWars.Properties.Resources.ZetaMerch;
            this.pictureBoxMerchZeta.Location = new System.Drawing.Point(365, 210);
            this.pictureBoxMerchZeta.Name = "pictureBoxMerchZeta";
            this.pictureBoxMerchZeta.Size = new System.Drawing.Size(119, 111);
            this.pictureBoxMerchZeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMerchZeta.TabIndex = 31;
            this.pictureBoxMerchZeta.TabStop = false;
            this.pictureBoxMerchZeta.Click += new System.EventHandler(this.pictureBoxMerchZeta_Click);
            // 
            // pictureBoxTumbler
            // 
            this.pictureBoxTumbler.Image = global::CalvinFoodWars.Properties.Resources.tumbler;
            this.pictureBoxTumbler.Location = new System.Drawing.Point(220, 333);
            this.pictureBoxTumbler.Name = "pictureBoxTumbler";
            this.pictureBoxTumbler.Size = new System.Drawing.Size(119, 111);
            this.pictureBoxTumbler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTumbler.TabIndex = 32;
            this.pictureBoxTumbler.TabStop = false;
            this.pictureBoxTumbler.Click += new System.EventHandler(this.pictureBoxTumbler_Click);
            // 
            // pictureBoxTumblerZeta
            // 
            this.pictureBoxTumblerZeta.Image = global::CalvinFoodWars.Properties.Resources.ZetaTumbler;
            this.pictureBoxTumblerZeta.Location = new System.Drawing.Point(365, 333);
            this.pictureBoxTumblerZeta.Name = "pictureBoxTumblerZeta";
            this.pictureBoxTumblerZeta.Size = new System.Drawing.Size(119, 111);
            this.pictureBoxTumblerZeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTumblerZeta.TabIndex = 33;
            this.pictureBoxTumblerZeta.TabStop = false;
            this.pictureBoxTumblerZeta.Click += new System.EventHandler(this.pictureBoxTumblerZeta_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(144, 488);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(166, 35);
            this.buttonSave.TabIndex = 34;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(511, 560);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.pictureBoxTumblerZeta);
            this.Controls.Add(this.pictureBoxTumbler);
            this.Controls.Add(this.pictureBoxMerchZeta);
            this.Controls.Add(this.pictureBoxPlushie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "FormEdit";
            this.Text = "Edit Layout";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlushie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMerchZeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTumbler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTumblerZeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxPlushie;
        private System.Windows.Forms.PictureBox pictureBoxMerchZeta;
        private System.Windows.Forms.PictureBox pictureBoxTumbler;
        private System.Windows.Forms.PictureBox pictureBoxTumblerZeta;
        private System.Windows.Forms.Button buttonSave;
    }
}