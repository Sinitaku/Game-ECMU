namespace game_UCMU
{
    partial class Form10
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
            this.btnTeamElTha3 = new System.Windows.Forms.Button();
            this.btnTeamSeDo3 = new System.Windows.Forms.Button();
            this.lblGameName7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTeamElTha3
            // 
            this.btnTeamElTha3.BackColor = System.Drawing.Color.Snow;
            this.btnTeamElTha3.Location = new System.Drawing.Point(124, 286);
            this.btnTeamElTha3.Name = "btnTeamElTha3";
            this.btnTeamElTha3.Size = new System.Drawing.Size(143, 50);
            this.btnTeamElTha3.TabIndex = 1;
            this.btnTeamElTha3.Text = "Eldhart and Thalia";
            this.btnTeamElTha3.UseVisualStyleBackColor = false;
            this.btnTeamElTha3.Click += new System.EventHandler(this.btnTeamElTha3_Click);
            // 
            // btnTeamSeDo3
            // 
            this.btnTeamSeDo3.BackColor = System.Drawing.Color.Snow;
            this.btnTeamSeDo3.Location = new System.Drawing.Point(488, 286);
            this.btnTeamSeDo3.Name = "btnTeamSeDo3";
            this.btnTeamSeDo3.Size = new System.Drawing.Size(144, 50);
            this.btnTeamSeDo3.TabIndex = 2;
            this.btnTeamSeDo3.Text = "Seraphina ja Dorian";
            this.btnTeamSeDo3.UseVisualStyleBackColor = false;
            this.btnTeamSeDo3.Click += new System.EventHandler(this.btnTeamSeDo3_Click);
            // 
            // lblGameName7
            // 
            this.lblGameName7.AutoSize = true;
            this.lblGameName7.BackColor = System.Drawing.Color.Snow;
            this.lblGameName7.Location = new System.Drawing.Point(215, 77);
            this.lblGameName7.Name = "lblGameName7";
            this.lblGameName7.Size = new System.Drawing.Size(322, 13);
            this.lblGameName7.TabIndex = 3;
            this.lblGameName7.Text = "Elemental Conquest: Monsters Unleashed, Choose your characters";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGameName7);
            this.Controls.Add(this.btnTeamSeDo3);
            this.Controls.Add(this.btnTeamElTha3);
            this.Name = "Form10";
            this.Text = "Choose characters10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTeamElTha3;
        private System.Windows.Forms.Button btnTeamSeDo3;
        private System.Windows.Forms.Label lblGameName7;
    }
}