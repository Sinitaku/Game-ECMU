namespace game_UCMU
{
    partial class Form25
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
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblWinText = new System.Windows.Forms.Label();
            this.lblWinText2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGameName
            // 
            this.lblGameName.BackColor = System.Drawing.Color.Snow;
            this.lblGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblGameName.Location = new System.Drawing.Point(196, 29);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(415, 25);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "Elemental Conquest: Monsters Unleashed";
            // 
            // lblWinText
            // 
            this.lblWinText.AutoSize = true;
            this.lblWinText.BackColor = System.Drawing.Color.Snow;
            this.lblWinText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWinText.Location = new System.Drawing.Point(244, 141);
            this.lblWinText.Name = "lblWinText";
            this.lblWinText.Size = new System.Drawing.Size(319, 20);
            this.lblWinText.TabIndex = 1;
            this.lblWinText.Text = "Congratulations! You defeated the monster.";
            // 
            // lblWinText2
            // 
            this.lblWinText2.AutoSize = true;
            this.lblWinText2.BackColor = System.Drawing.Color.Snow;
            this.lblWinText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWinText2.Location = new System.Drawing.Point(323, 203);
            this.lblWinText2.Name = "lblWinText2";
            this.lblWinText2.Size = new System.Drawing.Size(169, 20);
            this.lblWinText2.TabIndex = 2;
            this.lblWinText2.Text = "Click \'next\' to continue.";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Snow;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNext.Location = new System.Drawing.Point(349, 302);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(114, 44);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblWinText2);
            this.Controls.Add(this.lblWinText);
            this.Controls.Add(this.lblGameName);
            this.Name = "Form25";
            this.Text = "Elemental Conquest: Monsters Unleashed, Win";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblWinText;
        private System.Windows.Forms.Label lblWinText2;
        private System.Windows.Forms.Button btnNext;
    }
}