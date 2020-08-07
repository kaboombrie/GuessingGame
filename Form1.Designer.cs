namespace Assignment9_Prater
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
            this.introLabel = new System.Windows.Forms.Label();
            this.guessOne = new System.Windows.Forms.Button();
            this.guessTwo = new System.Windows.Forms.Button();
            this.nxtButton = new System.Windows.Forms.Button();
            this.instructLabel = new System.Windows.Forms.Label();
            this.correctPanel = new System.Windows.Forms.Panel();
            this.correctCnt = new System.Windows.Forms.Label();
            this.correct = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ncorrectCnt = new System.Windows.Forms.Label();
            this.ncorrect = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.correctPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // introLabel
            // 
            this.introLabel.AutoSize = true;
            this.introLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel.Location = new System.Drawing.Point(100, 40);
            this.introLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(404, 22);
            this.introLabel.TabIndex = 0;
            this.introLabel.Text = "Which one will contain the higher number?";
            // 
            // guessOne
            // 
            this.guessOne.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessOne.Location = new System.Drawing.Point(175, 200);
            this.guessOne.Margin = new System.Windows.Forms.Padding(4);
            this.guessOne.Name = "guessOne";
            this.guessOne.Size = new System.Drawing.Size(100, 30);
            this.guessOne.TabIndex = 3;
            this.guessOne.Text = "1";
            this.guessOne.UseVisualStyleBackColor = true;
            this.guessOne.Click += new System.EventHandler(this.guessOne_Click);
            // 
            // guessTwo
            // 
            this.guessTwo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessTwo.Location = new System.Drawing.Point(325, 200);
            this.guessTwo.Margin = new System.Windows.Forms.Padding(4);
            this.guessTwo.Name = "guessTwo";
            this.guessTwo.Size = new System.Drawing.Size(100, 30);
            this.guessTwo.TabIndex = 4;
            this.guessTwo.Text = "2";
            this.guessTwo.UseVisualStyleBackColor = true;
            this.guessTwo.Click += new System.EventHandler(this.guessTwo_Click);
            // 
            // nxtButton
            // 
            this.nxtButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxtButton.Location = new System.Drawing.Point(436, 370);
            this.nxtButton.Margin = new System.Windows.Forms.Padding(4);
            this.nxtButton.Name = "nxtButton";
            this.nxtButton.Size = new System.Drawing.Size(94, 30);
            this.nxtButton.TabIndex = 5;
            this.nxtButton.Text = "Next";
            this.nxtButton.UseVisualStyleBackColor = true;
            this.nxtButton.Click += new System.EventHandler(this.nxtButton_Click);
            // 
            // instructLabel
            // 
            this.instructLabel.AutoSize = true;
            this.instructLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructLabel.Location = new System.Drawing.Point(81, 70);
            this.instructLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructLabel.Name = "instructLabel";
            this.instructLabel.Size = new System.Drawing.Size(438, 22);
            this.instructLabel.TabIndex = 6;
            this.instructLabel.Text = "Make your choice, View your score, then click Next.";
            // 
            // correctPanel
            // 
            this.correctPanel.Controls.Add(this.correctCnt);
            this.correctPanel.Controls.Add(this.correct);
            this.correctPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctPanel.Location = new System.Drawing.Point(65, 260);
            this.correctPanel.Name = "correctPanel";
            this.correctPanel.Size = new System.Drawing.Size(200, 75);
            this.correctPanel.TabIndex = 7;
            // 
            // correctCnt
            // 
            this.correctCnt.AutoSize = true;
            this.correctCnt.Location = new System.Drawing.Point(75, 45);
            this.correctCnt.Name = "correctCnt";
            this.correctCnt.Size = new System.Drawing.Size(0, 18);
            this.correctCnt.TabIndex = 1;
            this.correctCnt.Click += new System.EventHandler(this.correctCnt_Click);
            // 
            // correct
            // 
            this.correct.AutoSize = true;
            this.correct.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correct.Location = new System.Drawing.Point(20, 4);
            this.correct.Name = "correct";
            this.correct.Size = new System.Drawing.Size(160, 22);
            this.correct.TabIndex = 0;
            this.correct.Text = "Correct Guesses:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ncorrectCnt);
            this.panel2.Controls.Add(this.ncorrect);
            this.panel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(330, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 75);
            this.panel2.TabIndex = 8;
            // 
            // ncorrectCnt
            // 
            this.ncorrectCnt.AutoSize = true;
            this.ncorrectCnt.Location = new System.Drawing.Point(75, 45);
            this.ncorrectCnt.Name = "ncorrectCnt";
            this.ncorrectCnt.Size = new System.Drawing.Size(0, 18);
            this.ncorrectCnt.TabIndex = 1;
            this.ncorrectCnt.Click += new System.EventHandler(this.ncorrectCnt_Click);
            // 
            // ncorrect
            // 
            this.ncorrect.AutoSize = true;
            this.ncorrect.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncorrect.Location = new System.Drawing.Point(14, 4);
            this.ncorrect.Name = "ncorrect";
            this.ncorrect.Size = new System.Drawing.Size(172, 22);
            this.ncorrect.TabIndex = 0;
            this.ncorrect.Text = "Incorrect Guesses:";
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(200, 135);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(0, 56);
            this.num1.TabIndex = 9;
            this.num1.Click += new System.EventHandler(this.num1_Click_1);
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(350, 135);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(0, 56);
            this.num2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.correctPanel);
            this.Controls.Add(this.instructLabel);
            this.Controls.Add(this.nxtButton);
            this.Controls.Add(this.guessTwo);
            this.Controls.Add(this.guessOne);
            this.Controls.Add(this.introLabel);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Guessing Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.correctPanel.ResumeLayout(false);
            this.correctPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Button guessOne;
        private System.Windows.Forms.Button guessTwo;
        private System.Windows.Forms.Button nxtButton;
        private System.Windows.Forms.Label instructLabel;
        private System.Windows.Forms.Panel correctPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label correctCnt;
        private System.Windows.Forms.Label correct;
        private System.Windows.Forms.Label ncorrectCnt;
        private System.Windows.Forms.Label ncorrect;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
    }
}

