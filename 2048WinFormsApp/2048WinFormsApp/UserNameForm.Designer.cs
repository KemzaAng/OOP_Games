namespace _2048WinFormsApp
{
    partial class UserNameForm
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
        public void InitializeComponent()
        {
            label1 = new Label();
            UserNameTextBox = new TextBox();
            button1 = new Button();
            label2 = new Label();
            FourRadioButton = new RadioButton();
            SixRadioButton = new RadioButton();
            NineRadioButton = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 48);
            label1.Name = "label1";
            label1.Size = new Size(116, 18);
            label1.TabIndex = 0;
            label1.Text = "Введите имя";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.BackColor = SystemColors.Info;
            UserNameTextBox.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameTextBox.Location = new Point(37, 92);
            UserNameTextBox.Multiline = true;
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(337, 41);
            UserNameTextBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.LavenderBlush;
            button1.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(147, 412);
            button1.Name = "button1";
            button1.Size = new Size(152, 84);
            button1.TabIndex = 2;
            button1.Text = "Начать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(123, 224);
            label2.Name = "label2";
            label2.Size = new Size(212, 18);
            label2.TabIndex = 3;
            label2.Text = "Выберите игровое поле";
            // 
            // FourRadioButton
            // 
            FourRadioButton.AutoSize = true;
            FourRadioButton.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FourRadioButton.Location = new Point(47, 319);
            FourRadioButton.Name = "FourRadioButton";
            FourRadioButton.Size = new Size(70, 29);
            FourRadioButton.TabIndex = 7;
            FourRadioButton.TabStop = true;
            FourRadioButton.Text = "4x4";
            FourRadioButton.UseVisualStyleBackColor = true;
            FourRadioButton.CheckedChanged += FourRadioButton_CheckedChanged;
            // 
            // SixRadioButton
            // 
            SixRadioButton.AutoSize = true;
            SixRadioButton.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SixRadioButton.Location = new Point(178, 271);
            SixRadioButton.Name = "SixRadioButton";
            SixRadioButton.Size = new Size(70, 29);
            SixRadioButton.TabIndex = 8;
            SixRadioButton.TabStop = true;
            SixRadioButton.Text = "6x6";
            SixRadioButton.UseVisualStyleBackColor = true;
            SixRadioButton.CheckedChanged += SixRadioButton_CheckedChanged;
            // 
            // NineRadioButton
            // 
            NineRadioButton.AutoSize = true;
            NineRadioButton.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NineRadioButton.Location = new Point(314, 319);
            NineRadioButton.Name = "NineRadioButton";
            NineRadioButton.Size = new Size(70, 29);
            NineRadioButton.TabIndex = 9;
            NineRadioButton.TabStop = true;
            NineRadioButton.Text = "9x9";
            NineRadioButton.UseVisualStyleBackColor = true;
            NineRadioButton.CheckedChanged += NineRadioButton_CheckedChanged;
            // 
            // UserNameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(442, 546);
            Controls.Add(NineRadioButton);
            Controls.Add(SixRadioButton);
            Controls.Add(FourRadioButton);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(UserNameTextBox);
            Controls.Add(label1);
            Name = "UserNameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserNameForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox UserNameTextBox;
        private Button button1;
        private Label label2;
        private RadioButton FourRadioButton;
        private RadioButton SixRadioButton;
        private RadioButton NineRadioButton;
    }
}