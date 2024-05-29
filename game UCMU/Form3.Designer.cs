namespace game_UCMU
{
    partial class Form3
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
            this.btnWater = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.lblGameName3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWater
            // 
            this.btnWater.BackColor = System.Drawing.Color.Snow;
            this.btnWater.Location = new System.Drawing.Point(69, 494);
            this.btnWater.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(380, 57);
            this.btnWater.TabIndex = 2;
            this.btnWater.Text = "Water";
            this.btnWater.UseVisualStyleBackColor = false;
            this.btnWater.Click += new System.EventHandler(this.btnWater_Click);
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.Snow;
            this.btnFire.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFire.Location = new System.Drawing.Point(656, 494);
            this.btnFire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(416, 57);
            this.btnFire.TabIndex = 3;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // lblGameName3
            // 
            this.lblGameName3.BackColor = System.Drawing.Color.Snow;
            this.lblGameName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblGameName3.Location = new System.Drawing.Point(294, 45);
            this.lblGameName3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameName3.Name = "lblGameName3";
            this.lblGameName3.Size = new System.Drawing.Size(622, 38);
            this.lblGameName3.TabIndex = 4;
            this.lblGameName3.Text = "Elemental Conquest: Monsters Unleashed\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::game_UCMU.Properties.Resources.firemonster;
            this.pictureBox2.Location = new System.Drawing.Point(669, 123);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(381, 285);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::game_UCMU.Properties.Resources.watermonster;
            this.pictureBox1.Location = new System.Drawing.Point(122, 123);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 285);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lblGameName3);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnWater);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Elemental Conquest: Monsters Unleashed, Choose the monster";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnWater;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Label lblGameName3;
    }
}