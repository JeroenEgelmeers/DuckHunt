namespace week1_chickenGame_new
{
    partial class Form1
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
            this.startButton = new System.Windows.Forms.Button();
            this.label_PlayerLifes = new System.Windows.Forms.Label();
            this.label_PlayerScore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.levellabel = new System.Windows.Forms.Label();
            this.youWon = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.youWon)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(460, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button_StartGame);
            // 
            // label_PlayerLifes
            // 
            this.label_PlayerLifes.AutoSize = true;
            this.label_PlayerLifes.BackColor = System.Drawing.Color.ForestGreen;
            this.label_PlayerLifes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_PlayerLifes.Location = new System.Drawing.Point(21, 432);
            this.label_PlayerLifes.Name = "label_PlayerLifes";
            this.label_PlayerLifes.Size = new System.Drawing.Size(92, 13);
            this.label_PlayerLifes.TabIndex = 1;
            this.label_PlayerLifes.Text = "Levens: Loading..";
            // 
            // label_PlayerScore
            // 
            this.label_PlayerScore.AutoSize = true;
            this.label_PlayerScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_PlayerScore.Location = new System.Drawing.Point(377, 19);
            this.label_PlayerScore.Name = "label_PlayerScore";
            this.label_PlayerScore.Size = new System.Drawing.Size(85, 13);
            this.label_PlayerScore.TabIndex = 2;
            this.label_PlayerScore.Text = "Score: Loading..";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 50);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.levellabel);
            this.panel2.Controls.Add(this.label_PlayerScore);
            this.panel2.Location = new System.Drawing.Point(0, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 50);
            this.panel2.TabIndex = 4;
            // 
            // levellabel
            // 
            this.levellabel.AutoSize = true;
            this.levellabel.BackColor = System.Drawing.Color.ForestGreen;
            this.levellabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.levellabel.Location = new System.Drawing.Point(223, 20);
            this.levellabel.Name = "levellabel";
            this.levellabel.Size = new System.Drawing.Size(45, 13);
            this.levellabel.TabIndex = 6;
            this.levellabel.Text = "Level: 1";
            this.levellabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // youWon
            // 
            this.youWon.Image = global::week1_chickenGame_new.Properties.Resources.youwon;
            this.youWon.Location = new System.Drawing.Point(0, 1);
            this.youWon.Name = "youWon";
            this.youWon.Size = new System.Drawing.Size(484, 462);
            this.youWon.TabIndex = 5;
            this.youWon.TabStop = false;
            this.youWon.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.youWon);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_PlayerLifes);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Chicken Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.youWon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label_PlayerLifes;
        private System.Windows.Forms.Label label_PlayerScore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox youWon;
        private System.Windows.Forms.Label levellabel;
    }
}

