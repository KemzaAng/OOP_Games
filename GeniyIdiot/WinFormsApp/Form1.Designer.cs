namespace WinFormsApp
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
            menuLabel = new Label();
            nextGameButton = new Button();
            resultGameButton = new Button();
            addNewQuestionButton = new Button();
            removeQuestionButton = new Button();
            getOutGameButton = new Button();
            SuspendLayout();
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuLabel.Location = new Point(357, 60);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(120, 45);
            menuLabel.TabIndex = 0;
            menuLabel.Text = "Меню";
            // 
            // nextGameButton
            // 
            nextGameButton.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextGameButton.Location = new Point(108, 154);
            nextGameButton.Name = "nextGameButton";
            nextGameButton.Size = new Size(190, 53);
            nextGameButton.TabIndex = 1;
            nextGameButton.Text = "Играть";
            nextGameButton.UseVisualStyleBackColor = true;
            nextGameButton.Click += nextGameButton_Click;
            // 
            // resultGameButton
            // 
            resultGameButton.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultGameButton.Location = new Point(108, 220);
            resultGameButton.Name = "resultGameButton";
            resultGameButton.Size = new Size(190, 56);
            resultGameButton.TabIndex = 2;
            resultGameButton.Text = "Результаты игры";
            resultGameButton.UseVisualStyleBackColor = true;
            resultGameButton.Click += resultGameButton_Click;
            // 
            // addNewQuestionButton
            // 
            addNewQuestionButton.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addNewQuestionButton.Location = new Point(108, 291);
            addNewQuestionButton.Name = "addNewQuestionButton";
            addNewQuestionButton.Size = new Size(190, 64);
            addNewQuestionButton.TabIndex = 3;
            addNewQuestionButton.Text = "Добавить новый вопрос";
            addNewQuestionButton.UseVisualStyleBackColor = true;
            addNewQuestionButton.Click += addNewQuestionButton_Click;
            // 
            // removeQuestionButton
            // 
            removeQuestionButton.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeQuestionButton.Location = new Point(108, 370);
            removeQuestionButton.Name = "removeQuestionButton";
            removeQuestionButton.Size = new Size(190, 64);
            removeQuestionButton.TabIndex = 4;
            removeQuestionButton.Text = "Удалить вопрос";
            removeQuestionButton.UseVisualStyleBackColor = true;
            removeQuestionButton.Click += removeQuestionButton_Click;
            // 
            // getOutGameButton
            // 
            getOutGameButton.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            getOutGameButton.Location = new Point(108, 448);
            getOutGameButton.Name = "getOutGameButton";
            getOutGameButton.Size = new Size(190, 62);
            getOutGameButton.TabIndex = 5;
            getOutGameButton.Text = "Выйти из игры";
            getOutGameButton.UseVisualStyleBackColor = true;
            getOutGameButton.Click += getOutGameButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 575);
            Controls.Add(getOutGameButton);
            Controls.Add(removeQuestionButton);
            Controls.Add(addNewQuestionButton);
            Controls.Add(resultGameButton);
            Controls.Add(nextGameButton);
            Controls.Add(menuLabel);
            Name = "MainForm";
            Text = "Geniy&Idiot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label menuLabel;
        private Button nextGameButton;
        private Button resultGameButton;
        private Button addNewQuestionButton;
        private Button removeQuestionButton;
        private Button getOutGameButton;
    }
}
