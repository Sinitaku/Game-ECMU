﻿namespace game_UCMU
{
    partial class Form6
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
            this.picBowWater = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBowWater)).BeginInit();
            this.SuspendLayout();
            // 
            // picBowWater
            // 
            this.picBowWater.Location = new System.Drawing.Point(196, 58);
            this.picBowWater.Name = "picBowWater";
            this.picBowWater.Size = new System.Drawing.Size(390, 163);
            this.picBowWater.TabIndex = 0;
            this.picBowWater.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBowWater);
            this.Name = "Form6";
            this.Text = "Fight";
            ((System.ComponentModel.ISupportInitialize)(this.picBowWater)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBowWater;
    }
}