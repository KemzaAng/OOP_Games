namespace _2048WinFormsApp
{
    partial class RulesOfTheGameForm
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
            Label rulesTextLabel;
            textRulesGameLabel = new Label();
            backButton = new Button();
            rulesTextLabel = new Label();
            SuspendLayout();
            // 
            // rulesTextLabel
            // 
            rulesTextLabel.AutoSize = true;
            rulesTextLabel.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rulesTextLabel.Location = new Point(255, 54);
            rulesTextLabel.Name = "rulesTextLabel";
            rulesTextLabel.Size = new Size(176, 30);
            rulesTextLabel.TabIndex = 0;
            rulesTextLabel.Text = "Правила игры";
            rulesTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            rulesTextLabel.UseCompatibleTextRendering = true;
            // 
            // textRulesGameLabel
            // 
            textRulesGameLabel.AutoSize = true;
            textRulesGameLabel.Location = new Point(51, 134);
            textRulesGameLabel.Name = "textRulesGameLabel";
            textRulesGameLabel.Size = new Size(0, 15);
            textRulesGameLabel.TabIndex = 1;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Peru;
            backButton.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.Location = new Point(12, 23);
            backButton.Name = "backButton";
            backButton.Size = new Size(126, 36);
            backButton.TabIndex = 2;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // RulesOfTheGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(700, 546);
            Controls.Add(backButton);
            Controls.Add(textRulesGameLabel);
            Controls.Add(rulesTextLabel);
            Name = "RulesOfTheGameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RulesOfTheGameForm";
            Load += RulesOfTheGameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label rulesTextLabel;
        private Label textRulesGameLabel;
        private Button backButton;
    }
}