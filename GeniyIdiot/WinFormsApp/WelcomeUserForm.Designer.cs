namespace WinFormsApp
{
    partial class welcomeUserForm
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
            textHelloLabel = new Label();
            nameUserLabel = new Label();
            textUserNameBox = new TextBox();
            intoGameButton = new Button();
            SuspendLayout();
            // 
            // textHelloLabel
            // 
            textHelloLabel.AutoSize = true;
            textHelloLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textHelloLabel.Location = new Point(293, 77);
            textHelloLabel.Name = "textHelloLabel";
            textHelloLabel.Size = new Size(189, 25);
            textHelloLabel.TabIndex = 0;
            textHelloLabel.Text = "Добро пожаловать!";
            // 
            // nameUserLabel
            // 
            nameUserLabel.AutoSize = true;
            nameUserLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameUserLabel.Location = new Point(182, 152);
            nameUserLabel.Name = "nameUserLabel";
            nameUserLabel.Size = new Size(108, 21);
            nameUserLabel.TabIndex = 1;
            nameUserLabel.Text = "Введите имя";
            // 
            // textUserNameBox
            // 
            textUserNameBox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textUserNameBox.Location = new Point(182, 176);
            textUserNameBox.Name = "textUserNameBox";
            textUserNameBox.Size = new Size(399, 35);
            textUserNameBox.TabIndex = 2;
            // 
            // intoGameButton
            // 
            intoGameButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            intoGameButton.Location = new Point(261, 278);
            intoGameButton.Name = "intoGameButton";
            intoGameButton.Size = new Size(257, 78);
            intoGameButton.TabIndex = 3;
            intoGameButton.Text = "Далее";
            intoGameButton.UseVisualStyleBackColor = true;
            intoGameButton.Click += intoGameButton_Click;
            // 
            // welcomeUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(intoGameButton);
            Controls.Add(textUserNameBox);
            Controls.Add(nameUserLabel);
            Controls.Add(textHelloLabel);
            Name = "welcomeUserForm";
            Text = "WelcomeUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textHelloLabel;
        private Label nameUserLabel;
        public TextBox textUserNameBox;
        private Button intoGameButton;
    }
}