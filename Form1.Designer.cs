namespace game_x_o
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblturn = new System.Windows.Forms.Label();
            this.lblwinner = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnrestart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(307, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe game";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(85, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turn";
            // 
            // lblturn
            // 
            this.lblturn.AutoSize = true;
            this.lblturn.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblturn.ForeColor = System.Drawing.SystemColors.Window;
            this.lblturn.Location = new System.Drawing.Point(65, 181);
            this.lblturn.Name = "lblturn";
            this.lblturn.Size = new System.Drawing.Size(145, 43);
            this.lblturn.TabIndex = 1;
            this.lblturn.Text = "Player 1";
            this.lblturn.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblwinner
            // 
            this.lblwinner.AutoSize = true;
            this.lblwinner.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwinner.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblwinner.Location = new System.Drawing.Point(39, 274);
            this.lblwinner.Name = "lblwinner";
            this.lblwinner.Size = new System.Drawing.Size(203, 43);
            this.lblwinner.TabIndex = 1;
            this.lblwinner.Text = "In Progress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(65, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 43);
            this.label5.TabIndex = 1;
            this.label5.Text = "Winner";
            // 
            // btnrestart
            // 
            this.btnrestart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnrestart.CausesValidation = false;
            this.btnrestart.Font = new System.Drawing.Font("Harlow Solid Italic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestart.ForeColor = System.Drawing.Color.White;
            this.btnrestart.Location = new System.Drawing.Point(26, 330);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(207, 50);
            this.btnrestart.TabIndex = 2;
            this.btnrestart.Text = "Restart Game";
            this.btnrestart.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Image = global::game_x_o.Properties.Resources._111;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(268, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 109);
            this.button2.TabIndex = 3;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Image = global::game_x_o.Properties.Resources._111;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(268, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 109);
            this.button1.TabIndex = 4;
            this.button1.Tag = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button3.Image = global::game_x_o.Properties.Resources._111;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(268, 472);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 109);
            this.button3.TabIndex = 4;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button4.Image = global::game_x_o.Properties.Resources._111;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(443, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 109);
            this.button4.TabIndex = 3;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button5.Image = global::game_x_o.Properties.Resources._111;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(605, 124);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 109);
            this.button5.TabIndex = 3;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button6.Image = global::game_x_o.Properties.Resources._111;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(443, 307);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 109);
            this.button6.TabIndex = 3;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button8.Image = global::game_x_o.Properties.Resources._111;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(605, 307);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 109);
            this.button8.TabIndex = 3;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button7.Image = global::game_x_o.Properties.Resources._111;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(443, 472);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 109);
            this.button7.TabIndex = 3;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button9.Image = global::game_x_o.Properties.Resources._111;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(605, 472);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(124, 109);
            this.button9.TabIndex = 3;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(800, 733);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnrestart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblturn);
            this.Controls.Add(this.lblwinner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblturn;
        private System.Windows.Forms.Label lblwinner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
    }
}

