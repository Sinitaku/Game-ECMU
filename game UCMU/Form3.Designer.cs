﻿namespace game_UCMU
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnWater = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.lblGameName3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 185);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(416, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(349, 185);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnWater
            // 
            this.btnWater.BackColor = System.Drawing.Color.Snow;
            this.btnWater.Location = new System.Drawing.Point(46, 321);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(253, 37);
            this.btnWater.TabIndex = 2;
            this.btnWater.Text = "Water";
            this.btnWater.UseVisualStyleBackColor = false;
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.Snow;
            this.btnFire.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFire.Location = new System.Drawing.Point(433, 310);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(281, 48);
            this.btnFire.TabIndex = 3;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = false;
            // 
            // lblGameName3
            // 
            this.lblGameName3.AutoSize = true;
            this.lblGameName3.BackColor = System.Drawing.Color.Snow;
            this.lblGameName3.Location = new System.Drawing.Point(218, 29);
            this.lblGameName3.Name = "lblGameName3";
            this.lblGameName3.Size = new System.Drawing.Size(311, 13);
            this.lblGameName3.TabIndex = 4;
            this.lblGameName3.Text = "Elemental Conquest: Monsters Unleashed, choosing the monster";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGameName3);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnWater);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Choose the monster";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnWater;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Label lblGameName3;
    }
}