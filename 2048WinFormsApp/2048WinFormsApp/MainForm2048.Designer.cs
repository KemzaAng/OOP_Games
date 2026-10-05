namespace _2048WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            scoreLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            RecordLabel = new Label();
            RecordScoreLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(300, 48);
            label1.Name = "label1";
            label1.Size = new Size(52, 18);
            label1.TabIndex = 0;
            label1.Text = "Счет:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreLabel.ForeColor = Color.Maroon;
            scoreLabel.Location = new Point(380, 48);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(18, 18);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(12, 19);
            label2.Name = "label2";
            label2.Size = new Size(58, 18);
            label2.TabIndex = 4;
            label2.Text = "Меню";
            label2.Click += MenuLabel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(12, 48);
            label3.Name = "label3";
            label3.Size = new Size(107, 18);
            label3.TabIndex = 5;
            label3.Text = "Новая игра";
            label3.Click += NewGameLabel_Click;
            // 
            // RecordLabel
            // 
            RecordLabel.AutoSize = true;
            RecordLabel.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecordLabel.ForeColor = Color.Maroon;
            RecordLabel.Location = new Point(282, 19);
            RecordLabel.Name = "RecordLabel";
            RecordLabel.Size = new Size(70, 18);
            RecordLabel.TabIndex = 6;
            RecordLabel.Text = "Рекорд:";
            // 
            // RecordScoreLabel
            // 
            RecordScoreLabel.AutoSize = true;
            RecordScoreLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecordScoreLabel.ForeColor = Color.Maroon;
            RecordScoreLabel.Location = new Point(380, 19);
            RecordScoreLabel.Name = "RecordScoreLabel";
            RecordScoreLabel.Size = new Size(18, 18);
            RecordScoreLabel.TabIndex = 7;
            RecordScoreLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(442, 556);
            Controls.Add(RecordScoreLabel);
            Controls.Add(RecordLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(scoreLabel);
            Controls.Add(label1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2048";
            Load += Form1_Load;
            KeyDown += MainForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label scoreLabel;
        private Label label2;
        private Label label3;
        private Label RecordLabel;
        private Label RecordScoreLabel;
    }
}
