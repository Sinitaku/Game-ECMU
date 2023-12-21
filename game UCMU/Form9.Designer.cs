namespace game_UCMU
{
    partial class Form9
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
            this.btnTeamElTha2 = new System.Windows.Forms.Button();
            this.btnTeamSeDo2 = new System.Windows.Forms.Button();
            this.lblGameName6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTeamElTha2
            // 
            this.btnTeamElTha2.BackColor = System.Drawing.Color.Snow;
            this.btnTeamElTha2.Location = new System.Drawing.Point(104, 322);
            this.btnTeamElTha2.Name = "btnTeamElTha2";
            this.btnTeamElTha2.Size = new System.Drawing.Size(143, 50);
            this.btnTeamElTha2.TabIndex = 0;
            this.btnTeamElTha2.Text = "Eldhart and Thalia";
            this.btnTeamElTha2.UseVisualStyleBackColor = false;
            this.btnTeamElTha2.Click += new System.EventHandler(this.btnTeamElTha2_Click);
            // 
            // btnTeamSeDo2
            // 
            this.btnTeamSeDo2.BackColor = System.Drawing.Color.Snow;
            this.btnTeamSeDo2.Location = new System.Drawing.Point(468, 322);
            this.btnTeamSeDo2.Name = "btnTeamSeDo2";
            this.btnTeamSeDo2.Size = new System.Drawing.Size(144, 50);
            this.btnTeamSeDo2.TabIndex = 1;
            this.btnTeamSeDo2.Text = "Seraphina ja Dorian";
            this.btnTeamSeDo2.UseVisualStyleBackColor = false;
            this.btnTeamSeDo2.Click += new System.EventHandler(this.btnTeamSeDo2_Click);
            // 
            // lblGameName6
            // 
            this.lblGameName6.AutoSize = true;
            this.lblGameName6.BackColor = System.Drawing.Color.Snow;
            this.lblGameName6.Location = new System.Drawing.Point(219, 87);
            this.lblGameName6.Name = "lblGameName6";
            this.lblGameName6.Size = new System.Drawing.Size(322, 13);
            this.lblGameName6.TabIndex = 2;
            this.lblGameName6.Text = "Elemental Conquest: Monsters Unleashed, Choose your characters";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGameName6);
            this.Controls.Add(this.btnTeamSeDo2);
            this.Controls.Add(this.btnTeamElTha2);
            this.Name = "Form9";
            this.Text = "Choose characters9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTeamElTha2;
        private System.Windows.Forms.Button btnTeamSeDo2;
        private System.Windows.Forms.Label lblGameName6;
    }
}