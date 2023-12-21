namespace game_UCMU
{
    partial class Form24
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
            this.btnTeamSeDo4 = new System.Windows.Forms.Button();
            this.btnTeamElTha4 = new System.Windows.Forms.Button();
            this.lblGameName7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTeamSeDo4
            // 
            this.btnTeamSeDo4.BackColor = System.Drawing.Color.Snow;
            this.btnTeamSeDo4.Location = new System.Drawing.Point(494, 293);
            this.btnTeamSeDo4.Name = "btnTeamSeDo4";
            this.btnTeamSeDo4.Size = new System.Drawing.Size(144, 50);
            this.btnTeamSeDo4.TabIndex = 7;
            this.btnTeamSeDo4.Text = "Seraphina ja Dorian";
            this.btnTeamSeDo4.UseVisualStyleBackColor = false;
            this.btnTeamSeDo4.Click += new System.EventHandler(this.btnTeamSeDo4_Click);
            // 
            // btnTeamElTha4
            // 
            this.btnTeamElTha4.BackColor = System.Drawing.Color.Snow;
            this.btnTeamElTha4.Location = new System.Drawing.Point(154, 293);
            this.btnTeamElTha4.Name = "btnTeamElTha4";
            this.btnTeamElTha4.Size = new System.Drawing.Size(143, 50);
            this.btnTeamElTha4.TabIndex = 8;
            this.btnTeamElTha4.Text = "Eldhart and Thalia";
            this.btnTeamElTha4.UseVisualStyleBackColor = false;
            this.btnTeamElTha4.Click += new System.EventHandler(this.btnTeamElTha4_Click);
            // 
            // lblGameName7
            // 
            this.lblGameName7.AutoSize = true;
            this.lblGameName7.BackColor = System.Drawing.Color.Snow;
            this.lblGameName7.Location = new System.Drawing.Point(226, 95);
            this.lblGameName7.Name = "lblGameName7";
            this.lblGameName7.Size = new System.Drawing.Size(322, 13);
            this.lblGameName7.TabIndex = 9;
            this.lblGameName7.Text = "Elemental Conquest: Monsters Unleashed, Choose your characters";
            // 
            // Form24
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGameName7);
            this.Controls.Add(this.btnTeamElTha4);
            this.Controls.Add(this.btnTeamSeDo4);
            this.Name = "Form24";
            this.Text = "Choose characters24";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTeamSeDo4;
        private System.Windows.Forms.Button btnTeamElTha4;
        private System.Windows.Forms.Label lblGameName7;
    }
}