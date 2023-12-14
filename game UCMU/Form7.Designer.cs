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
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblCredits2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.BackColor = System.Drawing.Color.Snow;
            this.lblCredits.Location = new System.Drawing.Point(164, 70);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(312, 26);
            this.lblCredits.TabIndex = 0;
            this.lblCredits.Text = "Gongrats, you win! \r\nThank you for playing Elemental Conquest: Monsters Unleashed" +
    ".\r\n";
            // 
            // lblCredits2
            // 
            this.lblCredits2.AutoSize = true;
            this.lblCredits2.BackColor = System.Drawing.Color.Snow;
            this.lblCredits2.Location = new System.Drawing.Point(273, 202);
            this.lblCredits2.Name = "lblCredits2";
            this.lblCredits2.Size = new System.Drawing.Size(101, 13);
            this.lblCredits2.TabIndex = 1;
            this.lblCredits2.Text = "ja jotain muuta shittii";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCredits2);
            this.Controls.Add(this.lblCredits);
            this.Name = "Form7";
            this.Text = "Credits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblCredits2;
    }
}