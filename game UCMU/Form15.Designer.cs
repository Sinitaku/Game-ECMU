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
            this.btn50pt2 = new System.Windows.Forms.Button();
            this.btn100pt2 = new System.Windows.Forms.Button();
            this.btn150pt2 = new System.Windows.Forms.Button();
            this.ldlGameName7 = new System.Windows.Forms.Label();
            this.lblTextChooseMnstr2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn50pt2
            // 
            this.btn50pt2.BackColor = System.Drawing.Color.Snow;
            this.btn50pt2.Location = new System.Drawing.Point(78, 278);
            this.btn50pt2.Name = "btn50pt2";
            this.btn50pt2.Size = new System.Drawing.Size(126, 59);
            this.btn50pt2.TabIndex = 2;
            this.btn50pt2.Text = "50 points";
            this.btn50pt2.UseVisualStyleBackColor = false;
            this.btn50pt2.Click += new System.EventHandler(this.btn50pt2_Click);
            // 
            // btn100pt2
            // 
            this.btn100pt2.BackColor = System.Drawing.Color.Snow;
            this.btn100pt2.Location = new System.Drawing.Point(289, 278);
            this.btn100pt2.Name = "btn100pt2";
            this.btn100pt2.Size = new System.Drawing.Size(124, 59);
            this.btn100pt2.TabIndex = 3;
            this.btn100pt2.Text = "100 points";
            this.btn100pt2.UseVisualStyleBackColor = false;
            this.btn100pt2.Click += new System.EventHandler(this.btn100pt2_Click);
            // 
            // btn150pt2
            // 
            this.btn150pt2.BackColor = System.Drawing.Color.Snow;
            this.btn150pt2.Location = new System.Drawing.Point(513, 278);
            this.btn150pt2.Name = "btn150pt2";
            this.btn150pt2.Size = new System.Drawing.Size(121, 59);
            this.btn150pt2.TabIndex = 4;
            this.btn150pt2.Text = "150 points";
            this.btn150pt2.UseVisualStyleBackColor = false;
            this.btn150pt2.Click += new System.EventHandler(this.btn150pt2_Click);
            // 
            // ldlGameName7
            // 
            this.ldlGameName7.AutoSize = true;
            this.ldlGameName7.BackColor = System.Drawing.Color.Snow;
            this.ldlGameName7.Location = new System.Drawing.Point(215, 58);
            this.ldlGameName7.Name = "ldlGameName7";
            this.ldlGameName7.Size = new System.Drawing.Size(312, 13);
            this.ldlGameName7.TabIndex = 5;
            this.ldlGameName7.Text = "Elemental Conquest: Monsters Unleashed, Choosing the monster";
            // 
            // lblTextChooseMnstr2
            // 
            this.lblTextChooseMnstr2.AutoSize = true;
            this.lblTextChooseMnstr2.BackColor = System.Drawing.Color.Snow;
            this.lblTextChooseMnstr2.Location = new System.Drawing.Point(245, 183);
            this.lblTextChooseMnstr2.Name = "lblTextChooseMnstr2";
            this.lblTextChooseMnstr2.Size = new System.Drawing.Size(282, 13);
            this.lblTextChooseMnstr2.TabIndex = 6;
            this.lblTextChooseMnstr2.Text = "Choose points for your monsterfight by pressing the button:";
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTextChooseMnstr2);
            this.Controls.Add(this.ldlGameName7);
            this.Controls.Add(this.btn150pt2);
            this.Controls.Add(this.btn100pt2);
            this.Controls.Add(this.btn50pt2);
            this.Name = "Form15";
            this.Text = "Points15";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn50pt2;
        private System.Windows.Forms.Button btn100pt2;
        private System.Windows.Forms.Button btn150pt2;
        private System.Windows.Forms.Label ldlGameName7;
        private System.Windows.Forms.Label lblTextChooseMnstr2;
    }
}