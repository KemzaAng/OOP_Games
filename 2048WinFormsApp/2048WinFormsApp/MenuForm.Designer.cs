namespace _2048WinFormsApp
{
    partial class MenuForm
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
            gameMenuButton = new Button();
            historyGameButton = new Button();
            rulesGameButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // gameMenuButton
            // 
            gameMenuButton.BackColor = Color.BurlyWood;
            gameMenuButton.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameMenuButton.Location = new Point(136, 39);
            gameMenuButton.Name = "gameMenuButton";
            gameMenuButton.Size = new Size(147, 65);
            gameMenuButton.TabIndex = 0;
            gameMenuButton.Text = "Новая игра";
            gameMenuButton.UseVisualStyleBackColor = false;
            gameMenuButton.Click += gameMenuButton_Click;
            // 
            // historyGameButton
            // 
            historyGameButton.BackColor = Color.DarkKhaki;
            historyGameButton.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            historyGameButton.Location = new Point(136, 159);
            historyGameButton.Name = "historyGameButton";
            historyGameButton.Size = new Size(147, 65);
            historyGameButton.TabIndex = 1;
            historyGameButton.Text = "История игры";
            historyGameButton.UseVisualStyleBackColor = false;
            historyGameButton.Click += HistoryGameButton_Click;
            // 
            // rulesGameButton
            // 
            rulesGameButton.BackColor = Color.Peru;
            rulesGameButton.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rulesGameButton.Location = new Point(136, 288);
            rulesGameButton.Name = "rulesGameButton";
            rulesGameButton.Size = new Size(147, 65);
            rulesGameButton.TabIndex = 2;
            rulesGameButton.Text = "Правила игры";
            rulesGameButton.UseVisualStyleBackColor = false;
            rulesGameButton.Click += RulesGameButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Chocolate;
            exitButton.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(136, 419);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(147, 65);
            exitButton.TabIndex = 4;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += ExitButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(442, 546);
            Controls.Add(exitButton);
            Controls.Add(rulesGameButton);
            Controls.Add(historyGameButton);
            Controls.Add(gameMenuButton);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню";
            ResumeLayout(false);
        }

        #endregion

        private Button gameMenuButton;
        private Button historyGameButton;
        private Button rulesGameButton;
        private Button exitButton;
    }
}