namespace game_UCMU
{
    partial class Form4
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
            this.ldlGameName4 = new System.Windows.Forms.Label();
            this.btn30pt = new System.Windows.Forms.Button();
            this.btn60pt = new System.Windows.Forms.Button();
            this.btn100pt = new System.Windows.Forms.Button();
            this.lblTextChooseMnstr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ldlGameName4
            // 
            this.ldlGameName4.BackColor = System.Drawing.Color.Snow;
            this.ldlGameName4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.ldlGameName4.Location = new System.Drawing.Point(294, 45);
            this.ldlGameName4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ldlGameName4.Name = "ldlGameName4";
            this.ldlGameName4.Size = new System.Drawing.Size(622, 38);
            this.ldlGameName4.TabIndex = 0;
            this.ldlGameName4.Text = "Elemental Conquest: Monsters Unleashed\r\n";
            // 
            // btn30pt
            // 
            this.btn30pt.BackColor = System.Drawing.Color.Snow;
            this.btn30pt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn30pt.Location = new System.Drawing.Point(141, 417);
            this.btn30pt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn30pt.Name = "btn30pt";
            this.btn30pt.Size = new System.Drawing.Size(189, 91);
            this.btn30pt.TabIndex = 1;
            this.btn30pt.Text = "30 points";
            this.btn30pt.UseVisualStyleBackColor = false;
            this.btn30pt.Click += new System.EventHandler(this.btn50pt_Click);
            // 
            // btn60pt
            // 
            this.btn60pt.BackColor = System.Drawing.Color.Snow;
            this.btn60pt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn60pt.Location = new System.Drawing.Point(506, 417);
            this.btn60pt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn60pt.Name = "btn60pt";
            this.btn60pt.Size = new System.Drawing.Size(189, 91);
            this.btn60pt.TabIndex = 2;
            this.btn60pt.Text = "60 points";
            this.btn60pt.UseVisualStyleBackColor = false;
            this.btn60pt.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn100pt
            // 
            this.btn100pt.BackColor = System.Drawing.Color.Snow;
            this.btn100pt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn100pt.Location = new System.Drawing.Point(858, 417);
            this.btn100pt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn100pt.Name = "btn100pt";
            this.btn100pt.Size = new System.Drawing.Size(189, 91);
            this.btn100pt.TabIndex = 3;
            this.btn100pt.Text = "100 points";
            this.btn100pt.UseVisualStyleBackColor = false;
            this.btn100pt.Click += new System.EventHandler(this.btn150pt_Click);
            // 
            // lblTextChooseMnstr
            // 
            this.lblTextChooseMnstr.BackColor = System.Drawing.Color.Snow;
            this.lblTextChooseMnstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTextChooseMnstr.Location = new System.Drawing.Point(266, 177);
            this.lblTextChooseMnstr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextChooseMnstr.Name = "lblTextChooseMnstr";
            this.lblTextChooseMnstr.Size = new System.Drawing.Size(670, 106);
            this.lblTextChooseMnstr.TabIndex = 4;
            this.lblTextChooseMnstr.Text = "Choose the points! \r\nThe points you choose will decide how difficult the level is" +
    ".\r\nMore points = harder level.";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lblTextChooseMnstr);
            this.Controls.Add(this.btn100pt);
            this.Controls.Add(this.btn60pt);
            this.Controls.Add(this.btn30pt);
            this.Controls.Add(this.ldlGameName4);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form4";
            this.Text = "Elemental Conquest: Monsters Unleashed, Points for monster";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ldlGameName4;
        private System.Windows.Forms.Button btn30pt;
        private System.Windows.Forms.Button btn60pt;
        private System.Windows.Forms.Button btn100pt;
        private System.Windows.Forms.Label lblTextChooseMnstr;
    }
}