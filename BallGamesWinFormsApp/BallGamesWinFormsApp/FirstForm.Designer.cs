namespace BallGamesWinFormsApp
{
    partial class FirstForm
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
            components = new System.ComponentModel.Container();
            stopButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            StartBallButton = new Button();
            SuspendLayout();
            // 
            // StopButton
            // 
            stopButton.Location = new Point(644, 73);
            stopButton.Name = "StopButton";
            stopButton.Size = new Size(134, 50);
            stopButton.TabIndex = 0;
            stopButton.Text = "Остановить";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += StopButton_Click;
            // 
            // timer
            // 
            timer.Interval = 17;
            // 
            // StartBallButton
            // 
            StartBallButton.Location = new Point(644, 21);
            StartBallButton.Name = "StartBallButton";
            StartBallButton.Size = new Size(134, 46);
            StartBallButton.TabIndex = 2;
            StartBallButton.Text = "Старт";
            StartBallButton.UseVisualStyleBackColor = true;
            StartBallButton.Click += MoreBallButton_Click;
            // 
            // FirstForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 678);
            Controls.Add(StartBallButton);
            Controls.Add(stopButton);
            Name = "FirstForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FirstForm";
            MouseDown += FirstForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private Button stopButton;
        private System.Windows.Forms.Timer timer;
        private Button StartBallButton;
    }
}