namespace game_UCMU
{
    partial class Form5
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
            this.lblGameName5 = new System.Windows.Forms.Label();
            this.btnTeamElTha = new System.Windows.Forms.Button();
            this.btnTeamSerDor = new System.Windows.Forms.Button();
            this.lblElTha = new System.Windows.Forms.Label();
            this.lblSeDo = new System.Windows.Forms.Label();
            this.lblChooseTeam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGameName5
            // 
            this.lblGameName5.AutoSize = true;
            this.lblGameName5.BackColor = System.Drawing.Color.Snow;
            this.lblGameName5.Location = new System.Drawing.Point(222, 51);
            this.lblGameName5.Name = "lblGameName5";
            this.lblGameName5.Size = new System.Drawing.Size(322, 13);
            this.lblGameName5.TabIndex = 0;
            this.lblGameName5.Text = "Elemental Conquest: Monsters Unleashed, Choose your characters";
            // 
            // btnTeamElTha
            // 
            this.btnTeamElTha.BackColor = System.Drawing.Color.Snow;
            this.btnTeamElTha.Location = new System.Drawing.Point(130, 347);
            this.btnTeamElTha.Name = "btnTeamElTha";
            this.btnTeamElTha.Size = new System.Drawing.Size(149, 49);
            this.btnTeamElTha.TabIndex = 1;
            this.btnTeamElTha.Text = "Team Eldhart and Thalia";
            this.btnTeamElTha.UseVisualStyleBackColor = false;
            this.btnTeamElTha.Click += new System.EventHandler(this.btnTeamElTha_Click);
            // 
            // btnTeamSerDor
            // 
            this.btnTeamSerDor.BackColor = System.Drawing.Color.Snow;
            this.btnTeamSerDor.Location = new System.Drawing.Point(477, 347);
            this.btnTeamSerDor.Name = "btnTeamSerDor";
            this.btnTeamSerDor.Size = new System.Drawing.Size(151, 49);
            this.btnTeamSerDor.TabIndex = 2;
            this.btnTeamSerDor.Text = "Team Seraphina and Dorian";
            this.btnTeamSerDor.UseVisualStyleBackColor = false;
            this.btnTeamSerDor.Click += new System.EventHandler(this.btnTeamSerDor_Click);
            // 
            // lblElTha
            // 
            this.lblElTha.AutoSize = true;
            this.lblElTha.BackColor = System.Drawing.Color.Snow;
            this.lblElTha.Location = new System.Drawing.Point(150, 170);
            this.lblElTha.Name = "lblElTha";
            this.lblElTha.Size = new System.Drawing.Size(74, 13);
            this.lblElTha.TabIndex = 3;
            this.lblElTha.Text = "Team el ja tha";
            // 
            // lblSeDo
            // 
            this.lblSeDo.AutoSize = true;
            this.lblSeDo.BackColor = System.Drawing.Color.Snow;
            this.lblSeDo.Location = new System.Drawing.Point(537, 170);
            this.lblSeDo.Name = "lblSeDo";
            this.lblSeDo.Size = new System.Drawing.Size(74, 13);
            this.lblSeDo.TabIndex = 4;
            this.lblSeDo.Text = "Team se ja do";
            // 
            // lblChooseTeam
            // 
            this.lblChooseTeam.AutoSize = true;
            this.lblChooseTeam.BackColor = System.Drawing.Color.Snow;
            this.lblChooseTeam.Location = new System.Drawing.Point(330, 256);
            this.lblChooseTeam.Name = "lblChooseTeam";
            this.lblChooseTeam.Size = new System.Drawing.Size(95, 13);
            this.lblChooseTeam.TabIndex = 5;
            this.lblChooseTeam.Text = "Choose your team:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChooseTeam);
            this.Controls.Add(this.lblSeDo);
            this.Controls.Add(this.lblElTha);
            this.Controls.Add(this.btnTeamSerDor);
            this.Controls.Add(this.btnTeamElTha);
            this.Controls.Add(this.lblGameName5);
            this.Name = "Form5";
            this.Text = "Choose characters5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameName5;
        private System.Windows.Forms.Button btnTeamElTha;
        private System.Windows.Forms.Button btnTeamSerDor;
        private System.Windows.Forms.Label lblElTha;
        private System.Windows.Forms.Label lblSeDo;
        private System.Windows.Forms.Label lblChooseTeam;
    }
}