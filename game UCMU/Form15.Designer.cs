namespace game_UCMU
{
    partial class Form15
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
            this.btn30pt2 = new System.Windows.Forms.Button();
            this.btn60pt2 = new System.Windows.Forms.Button();
            this.btn100pt2 = new System.Windows.Forms.Button();
            this.ldlGameName7 = new System.Windows.Forms.Label();
            this.lblTextChooseMnstr2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn30pt2
            // 
            this.btn30pt2.BackColor = System.Drawing.Color.Snow;
            this.btn30pt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn30pt2.Location = new System.Drawing.Point(94, 271);
            this.btn30pt2.Name = "btn30pt2";
            this.btn30pt2.Size = new System.Drawing.Size(126, 59);
            this.btn30pt2.TabIndex = 2;
            this.btn30pt2.Text = "30 points";
            this.btn30pt2.UseVisualStyleBackColor = false;
            this.btn30pt2.Click += new System.EventHandler(this.btn50pt2_Click);
            // 
            // btn60pt2
            // 
            this.btn60pt2.BackColor = System.Drawing.Color.Snow;
            this.btn60pt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn60pt2.Location = new System.Drawing.Point(337, 271);
            this.btn60pt2.Name = "btn60pt2";
            this.btn60pt2.Size = new System.Drawing.Size(126, 59);
            this.btn60pt2.TabIndex = 3;
            this.btn60pt2.Text = "60 points";
            this.btn60pt2.UseVisualStyleBackColor = false;
            this.btn60pt2.Click += new System.EventHandler(this.btn100pt2_Click);
            // 
            // btn100pt2
            // 
            this.btn100pt2.BackColor = System.Drawing.Color.Snow;
            this.btn100pt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn100pt2.Location = new System.Drawing.Point(572, 271);
            this.btn100pt2.Name = "btn100pt2";
            this.btn100pt2.Size = new System.Drawing.Size(126, 59);
            this.btn100pt2.TabIndex = 4;
            this.btn100pt2.Text = "100 points";
            this.btn100pt2.UseVisualStyleBackColor = false;
            this.btn100pt2.Click += new System.EventHandler(this.btn150pt2_Click);
            // 
            // ldlGameName7
            // 
            this.ldlGameName7.BackColor = System.Drawing.Color.Snow;
            this.ldlGameName7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.ldlGameName7.Location = new System.Drawing.Point(196, 29);
            this.ldlGameName7.Name = "ldlGameName7";
            this.ldlGameName7.Size = new System.Drawing.Size(415, 25);
            this.ldlGameName7.TabIndex = 5;
            this.ldlGameName7.Text = "Elemental Conquest: Monsters Unleashed\r\n";
            // 
            // lblTextChooseMnstr2
            // 
            this.lblTextChooseMnstr2.BackColor = System.Drawing.Color.Snow;
            this.lblTextChooseMnstr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTextChooseMnstr2.Location = new System.Drawing.Point(177, 115);
            this.lblTextChooseMnstr2.Name = "lblTextChooseMnstr2";
            this.lblTextChooseMnstr2.Size = new System.Drawing.Size(447, 69);
            this.lblTextChooseMnstr2.TabIndex = 6;
            this.lblTextChooseMnstr2.Text = "Choose a monster! \r\nThe points you choose will decide how difficult the level is." +
    "\r\n More points= harder level.\r\n";
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTextChooseMnstr2);
            this.Controls.Add(this.ldlGameName7);
            this.Controls.Add(this.btn100pt2);
            this.Controls.Add(this.btn60pt2);
            this.Controls.Add(this.btn30pt2);
            this.Name = "Form15";
            this.Text = "Points15";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn30pt2;
        private System.Windows.Forms.Button btn60pt2;
        private System.Windows.Forms.Button btn100pt2;
        private System.Windows.Forms.Label ldlGameName7;
        private System.Windows.Forms.Label lblTextChooseMnstr2;
    }
}