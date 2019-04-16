namespace Judah_s_Bible_Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.choiceOne = new System.Windows.Forms.RadioButton();
            this.choiceTwo = new System.Windows.Forms.RadioButton();
            this.choiceThree = new System.Windows.Forms.RadioButton();
            this.choiceFour = new System.Windows.Forms.RadioButton();
            this.decideButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.startLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNumberLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.questionNumberLabel.Location = new System.Drawing.Point(534, 179);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(70, 26);
            this.questionNumberLabel.TabIndex = 0;
            this.questionNumberLabel.Text = "label1";
            this.questionNumberLabel.Visible = false;
            this.questionNumberLabel.Click += new System.EventHandler(this.questionNumberLabel_Click);
            // 
            // choiceOne
            // 
            this.choiceOne.Checked = true;
            this.choiceOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceOne.ForeColor = System.Drawing.Color.MidnightBlue;
            this.choiceOne.Location = new System.Drawing.Point(397, 223);
            this.choiceOne.Name = "choiceOne";
            this.choiceOne.Size = new System.Drawing.Size(559, 36);
            this.choiceOne.TabIndex = 1;
            this.choiceOne.TabStop = true;
            this.choiceOne.Text = "radioButton1";
            this.choiceOne.UseVisualStyleBackColor = true;
            this.choiceOne.Visible = false;
            this.choiceOne.CheckedChanged += new System.EventHandler(this.choiceOne_CheckedChanged);
            // 
            // choiceTwo
            // 
            this.choiceTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceTwo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.choiceTwo.Location = new System.Drawing.Point(397, 277);
            this.choiceTwo.Name = "choiceTwo";
            this.choiceTwo.Size = new System.Drawing.Size(559, 36);
            this.choiceTwo.TabIndex = 2;
            this.choiceTwo.Text = "radiobutton2";
            this.choiceTwo.UseVisualStyleBackColor = true;
            this.choiceTwo.Visible = false;
            this.choiceTwo.CheckedChanged += new System.EventHandler(this.choiceTwo_CheckedChanged);
            // 
            // choiceThree
            // 
            this.choiceThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceThree.ForeColor = System.Drawing.Color.MidnightBlue;
            this.choiceThree.Location = new System.Drawing.Point(397, 331);
            this.choiceThree.Name = "choiceThree";
            this.choiceThree.Size = new System.Drawing.Size(559, 36);
            this.choiceThree.TabIndex = 3;
            this.choiceThree.Text = "radioButton3";
            this.choiceThree.UseVisualStyleBackColor = true;
            this.choiceThree.Visible = false;
            // 
            // choiceFour
            // 
            this.choiceFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceFour.ForeColor = System.Drawing.Color.MidnightBlue;
            this.choiceFour.Location = new System.Drawing.Point(397, 385);
            this.choiceFour.Name = "choiceFour";
            this.choiceFour.Size = new System.Drawing.Size(559, 36);
            this.choiceFour.TabIndex = 4;
            this.choiceFour.Text = "radioButton4";
            this.choiceFour.UseVisualStyleBackColor = true;
            this.choiceFour.Visible = false;
            this.choiceFour.CheckedChanged += new System.EventHandler(this.choiceFour_CheckedChanged);
            // 
            // decideButton
            // 
            this.decideButton.BackColor = System.Drawing.Color.Honeydew;
            this.decideButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decideButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.decideButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.decideButton.Location = new System.Drawing.Point(465, 453);
            this.decideButton.Name = "decideButton";
            this.decideButton.Size = new System.Drawing.Size(227, 69);
            this.decideButton.TabIndex = 5;
            this.decideButton.Text = "Decide";
            this.decideButton.UseVisualStyleBackColor = false;
            this.decideButton.Visible = false;
            this.decideButton.Click += new System.EventHandler(this.decideButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.nextButton.Location = new System.Drawing.Point(465, 541);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(227, 69);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Start Quiz";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // answerTextBox
            // 
            this.answerTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.answerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.answerTextBox.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTextBox.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.answerTextBox.Location = new System.Drawing.Point(344, 80);
            this.answerTextBox.Multiline = true;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.ReadOnly = true;
            this.answerTextBox.Size = new System.Drawing.Size(455, 96);
            this.answerTextBox.TabIndex = 7;
            this.answerTextBox.Visible = false;
            this.answerTextBox.TextChanged += new System.EventHandler(this.answerTextBox_TextChanged);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.startLabel.Location = new System.Drawing.Point(288, 32);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(571, 36);
            this.startLabel.TabIndex = 8;
            this.startLabel.Text = "Welcome to Judah\'s Bible Quiz";
            this.startLabel.Click += new System.EventHandler(this.startLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(832, 448);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 175);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.restartButton.Location = new System.Drawing.Point(48, 448);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(227, 69);
            this.restartButton.TabIndex = 10;
            this.restartButton.Text = "Restart Quiz";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Visible = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 32);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 629);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1123, 32);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(27, 597);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1098, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(25, 597);
            this.panel5.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(1005, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1123, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.decideButton);
            this.Controls.Add(this.choiceFour);
            this.Controls.Add(this.choiceThree);
            this.Controls.Add(this.choiceTwo);
            this.Controls.Add(this.choiceOne);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Judah\'s Bible Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.RadioButton choiceOne;
        private System.Windows.Forms.RadioButton choiceTwo;
        private System.Windows.Forms.RadioButton choiceThree;
        private System.Windows.Forms.RadioButton choiceFour;
        private System.Windows.Forms.Button decideButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
    }
}

