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
            this.lblTeamElThaInfo = new System.Windows.Forms.Label();
            this.lblTeamSeDoInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGameName5
            // 
            this.lblGameName5.BackColor = System.Drawing.Color.Snow;
            this.lblGameName5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblGameName5.Location = new System.Drawing.Point(196, 29);
            this.lblGameName5.Name = "lblGameName5";
            this.lblGameName5.Size = new System.Drawing.Size(415, 25);
            this.lblGameName5.TabIndex = 0;
            this.lblGameName5.Text = "Elemental Conquest: Monsters Unleashed";
            // 
            // btnTeamElTha
            // 
            this.btnTeamElTha.BackColor = System.Drawing.Color.Snow;
            this.btnTeamElTha.Location = new System.Drawing.Point(131, 320);
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
            this.btnTeamSerDor.Location = new System.Drawing.Point(513, 320);
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
            this.lblElTha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblElTha.Location = new System.Drawing.Point(127, 129);
            this.lblElTha.Name = "lblElTha";
            this.lblElTha.Size = new System.Drawing.Size(181, 20);
            this.lblElTha.TabIndex = 3;
            this.lblElTha.Text = "Team Eldhart and Thalia";
            // 
            // lblSeDo
            // 
            this.lblSeDo.AutoSize = true;
            this.lblSeDo.BackColor = System.Drawing.Color.Snow;
            this.lblSeDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSeDo.Location = new System.Drawing.Point(456, 129);
            this.lblSeDo.Name = "lblSeDo";
            this.lblSeDo.Size = new System.Drawing.Size(208, 20);
            this.lblSeDo.TabIndex = 4;
            this.lblSeDo.Text = "Team Seraphina and Dorian";
            // 
            // lblChooseTeam
            // 
            this.lblChooseTeam.AutoSize = true;
            this.lblChooseTeam.BackColor = System.Drawing.Color.Snow;
            this.lblChooseTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblChooseTeam.Location = new System.Drawing.Point(308, 263);
            this.lblChooseTeam.Name = "lblChooseTeam";
            this.lblChooseTeam.Size = new System.Drawing.Size(142, 20);
            this.lblChooseTeam.TabIndex = 5;
            this.lblChooseTeam.Text = "Choose your team:";
            // 
            // lblTeamElThaInfo
            // 
            this.lblTeamElThaInfo.AutoSize = true;
            this.lblTeamElThaInfo.BackColor = System.Drawing.Color.Snow;
            this.lblTeamElThaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTeamElThaInfo.Location = new System.Drawing.Point(65, 175);
            this.lblTeamElThaInfo.Name = "lblTeamElThaInfo";
            this.lblTeamElThaInfo.Size = new System.Drawing.Size(315, 15);
            this.lblTeamElThaInfo.TabIndex = 6;
            this.lblTeamElThaInfo.Text = "Eldhart\'s power is water and Thalia\'s power is electricity. ";
            // 
            // lblTeamSeDoInfo
            // 
            this.lblTeamSeDoInfo.AutoSize = true;
            this.lblTeamSeDoInfo.BackColor = System.Drawing.Color.Snow;
            this.lblTeamSeDoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTeamSeDoInfo.Location = new System.Drawing.Point(411, 175);
            this.lblTeamSeDoInfo.Name = "lblTeamSeDoInfo";
            this.lblTeamSeDoInfo.Size = new System.Drawing.Size(298, 15);
            this.lblTeamSeDoInfo.TabIndex = 7;
            this.lblTeamSeDoInfo.Text = "Seraphina\'s power is fire and Dorian\'s power is earth.";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTeamSeDoInfo);
            this.Controls.Add(this.lblTeamElThaInfo);
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
        private System.Windows.Forms.Label lblTeamElThaInfo;
        private System.Windows.Forms.Label lblTeamSeDoInfo;
    }
}