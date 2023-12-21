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
            this.btn50pt = new System.Windows.Forms.Button();
            this.btn100pt = new System.Windows.Forms.Button();
            this.btn150pt = new System.Windows.Forms.Button();
            this.lblTextChooseMnstr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ldlGameName4
            // 
            this.ldlGameName4.AutoSize = true;
            this.ldlGameName4.BackColor = System.Drawing.Color.Snow;
            this.ldlGameName4.Location = new System.Drawing.Point(218, 52);
            this.ldlGameName4.Name = "ldlGameName4";
            this.ldlGameName4.Size = new System.Drawing.Size(312, 13);
            this.ldlGameName4.TabIndex = 0;
            this.ldlGameName4.Text = "Elemental Conquest: Monsters Unleashed, Choosing the monster";
            // 
            // btn50pt
            // 
            this.btn50pt.BackColor = System.Drawing.Color.Snow;
            this.btn50pt.Location = new System.Drawing.Point(81, 255);
            this.btn50pt.Name = "btn50pt";
            this.btn50pt.Size = new System.Drawing.Size(126, 59);
            this.btn50pt.TabIndex = 1;
            this.btn50pt.Text = "50 points";
            this.btn50pt.UseVisualStyleBackColor = false;
            this.btn50pt.Click += new System.EventHandler(this.btn50pt_Click);
            // 
            // btn100pt
            // 
            this.btn100pt.BackColor = System.Drawing.Color.Snow;
            this.btn100pt.Location = new System.Drawing.Point(304, 255);
            this.btn100pt.Name = "btn100pt";
            this.btn100pt.Size = new System.Drawing.Size(124, 59);
            this.btn100pt.TabIndex = 2;
            this.btn100pt.Text = "100 points";
            this.btn100pt.UseVisualStyleBackColor = false;
            this.btn100pt.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn150pt
            // 
            this.btn150pt.BackColor = System.Drawing.Color.Snow;
            this.btn150pt.Location = new System.Drawing.Point(528, 255);
            this.btn150pt.Name = "btn150pt";
            this.btn150pt.Size = new System.Drawing.Size(121, 59);
            this.btn150pt.TabIndex = 3;
            this.btn150pt.Text = "150 points";
            this.btn150pt.UseVisualStyleBackColor = false;
            this.btn150pt.Click += new System.EventHandler(this.btn150pt_Click);
            // 
            // lblTextChooseMnstr
            // 
            this.lblTextChooseMnstr.AutoSize = true;
            this.lblTextChooseMnstr.BackColor = System.Drawing.Color.Snow;
            this.lblTextChooseMnstr.Location = new System.Drawing.Point(218, 148);
            this.lblTextChooseMnstr.Name = "lblTextChooseMnstr";
            this.lblTextChooseMnstr.Size = new System.Drawing.Size(282, 13);
            this.lblTextChooseMnstr.TabIndex = 4;
            this.lblTextChooseMnstr.Text = "Choose points for your monsterfight by pressing the button:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTextChooseMnstr);
            this.Controls.Add(this.btn150pt);
            this.Controls.Add(this.btn100pt);
            this.Controls.Add(this.btn50pt);
            this.Controls.Add(this.ldlGameName4);
            this.Name = "Form4";
            this.Text = "Points4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ldlGameName4;
        private System.Windows.Forms.Button btn50pt;
        private System.Windows.Forms.Button btn100pt;
        private System.Windows.Forms.Button btn150pt;
        private System.Windows.Forms.Label lblTextChooseMnstr;
    }
}