namespace CatchBallWinFormsApp
{
    partial class SecondForm
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
            StartButton = new Button();
            label1 = new Label();
            CountBallLabel = new Label();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.Chocolate;
            StartButton.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartButton.Location = new Point(351, 310);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(81, 38);
            StartButton.TabIndex = 0;
            StartButton.Text = "Старт";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(584, 41);
            label1.Name = "label1";
            label1.Size = new Size(192, 18);
            label1.TabIndex = 1;
            label1.Text = "Количество шариков";
            // 
            // CountBallLabel
            // 
            CountBallLabel.AutoSize = true;
            CountBallLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CountBallLabel.Location = new Point(737, 70);
            CountBallLabel.Name = "CountBallLabel";
            CountBallLabel.Size = new Size(18, 18);
            CountBallLabel.TabIndex = 2;
            CountBallLabel.Text = "0";
            // 
            // SecondForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 678);
            Controls.Add(CountBallLabel);
            Controls.Add(label1);
            Controls.Add(StartButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SecondForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SecondForm";
            MouseDown += SecondForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Label label1;
        private Label CountBallLabel;
    }
}