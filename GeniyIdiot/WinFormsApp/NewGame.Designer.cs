namespace WinFormsApp
{
    partial class NewGame
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
            questionNumberLabel = new Label();
            textQuestionLabel = new Label();
            answerQuestionTextBox = new TextBox();
            nextQuestionButton = new Button();
            SuspendLayout();
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            questionNumberLabel.Location = new Point(46, 103);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(82, 19);
            questionNumberLabel.TabIndex = 0;
            questionNumberLabel.Text = "Вопрос №";         
            // 
            // textQuestionLabel
            // 
            textQuestionLabel.AutoSize = true;
            textQuestionLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textQuestionLabel.Location = new Point(46, 132);
            textQuestionLabel.Name = "textQuestionLabel";
            textQuestionLabel.Size = new Size(143, 25);
            textQuestionLabel.TabIndex = 1;
            textQuestionLabel.Text = "Текст вопроса";
            // 
            // answerQuestionTextBox
            // 
            answerQuestionTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answerQuestionTextBox.Location = new Point(46, 176);
            answerQuestionTextBox.Name = "answerQuestionTextBox";
            answerQuestionTextBox.Size = new Size(162, 35);
            answerQuestionTextBox.TabIndex = 2;
            // 
            // nextQuestionButton
            // 
            nextQuestionButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextQuestionButton.Location = new Point(256, 274);
            nextQuestionButton.Name = "nextQuestionButton";
            nextQuestionButton.Size = new Size(242, 112);
            nextQuestionButton.TabIndex = 3;
            nextQuestionButton.Text = "Далее";
            nextQuestionButton.UseVisualStyleBackColor = true;
            nextQuestionButton.Click += nextQuestionButton_Click;
            // 
            // NewGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nextQuestionButton);
            Controls.Add(answerQuestionTextBox);
            Controls.Add(textQuestionLabel);
            Controls.Add(questionNumberLabel);
            Name = "NewGame";
            Text = "NewGame";
            Load += NewGame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questionNumberLabel;
        private Label textQuestionLabel;
        private TextBox answerQuestionTextBox;
        private Button nextQuestionButton;
    }
}