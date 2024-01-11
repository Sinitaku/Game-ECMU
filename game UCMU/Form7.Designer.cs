namespace game_UCMU
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.lblGameName8 = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblCredits2 = new System.Windows.Forms.Label();
            this.lblCredits3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGameName8
            // 
            this.lblGameName8.BackColor = System.Drawing.Color.Snow;
            this.lblGameName8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblGameName8.Location = new System.Drawing.Point(196, 29);
            this.lblGameName8.Name = "lblGameName8";
            this.lblGameName8.Size = new System.Drawing.Size(415, 25);
            this.lblGameName8.TabIndex = 0;
            this.lblGameName8.Text = "Elemental Conquest: Monsters Unleashed";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.BackColor = System.Drawing.Color.Snow;
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCredits.Location = new System.Drawing.Point(151, 91);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(497, 140);
            this.lblCredits.TabIndex = 1;
            this.lblCredits.Text = resources.GetString("lblCredits.Text");
            // 
            // lblCredits2
            // 
            this.lblCredits2.AutoSize = true;
            this.lblCredits2.BackColor = System.Drawing.Color.Snow;
            this.lblCredits2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCredits2.Location = new System.Drawing.Point(267, 318);
            this.lblCredits2.Name = "lblCredits2";
            this.lblCredits2.Size = new System.Drawing.Size(276, 20);
            this.lblCredits2.TabIndex = 2;
            this.lblCredits2.Text = "This game was made by Sini Takkinen\r\n";
            // 
            // lblCredits3
            // 
            this.lblCredits3.AutoSize = true;
            this.lblCredits3.BackColor = System.Drawing.Color.Snow;
            this.lblCredits3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCredits3.Location = new System.Drawing.Point(325, 354);
            this.lblCredits3.Name = "lblCredits3";
            this.lblCredits3.Size = new System.Drawing.Size(165, 20);
            this.lblCredits3.TabIndex = 3;
            this.lblCredits3.Text = "Thank you for gaming!";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCredits3);
            this.Controls.Add(this.lblCredits2);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblGameName8);
            this.Name = "Form7";
            this.Text = "Credits7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameName8;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblCredits2;
        private System.Windows.Forms.Label lblCredits3;
    }
}