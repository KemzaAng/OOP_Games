namespace WinFormsApp
{
    partial class AddNewQustionForm
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
            textAddQuestionLabel = new Label();
            textAddQuestionBox = new TextBox();
            requestTextLabel = new Label();
            textAnswertBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textAddQuestionLabel
            // 
            textAddQuestionLabel.AutoSize = true;
            textAddQuestionLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textAddQuestionLabel.Location = new Point(36, 86);
            textAddQuestionLabel.Name = "textAddQuestionLabel";
            textAddQuestionLabel.Size = new Size(183, 20);
            textAddQuestionLabel.TabIndex = 0;
            textAddQuestionLabel.Text = "Напишите текст вопроса";
            // 
            // textAddQuestionBox
            // 
            textAddQuestionBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textAddQuestionBox.Location = new Point(36, 109);
            textAddQuestionBox.Name = "textAddQuestionBox";
            textAddQuestionBox.Size = new Size(617, 29);
            textAddQuestionBox.TabIndex = 1;            
            // 
            // requestTextLabel
            // 
            requestTextLabel.AutoSize = true;
            requestTextLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            requestTextLabel.Location = new Point(36, 193);
            requestTextLabel.Name = "requestTextLabel";
            requestTextLabel.Size = new Size(235, 20);
            requestTextLabel.TabIndex = 2;
            requestTextLabel.Text = "Напишите число, ответ вопроса";
            // 
            // textAnswertBox
            // 
            textAnswertBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textAnswertBox.Location = new Point(36, 221);
            textAnswertBox.Name = "textAnswertBox";
            textAnswertBox.Size = new Size(617, 29);
            textAnswertBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(236, 307);
            button1.Name = "button1";
            button1.Size = new Size(270, 95);
            button1.TabIndex = 4;
            button1.Text = "Далее";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddNewQustionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textAnswertBox);
            Controls.Add(requestTextLabel);
            Controls.Add(textAddQuestionBox);
            Controls.Add(textAddQuestionLabel);
            Name = "AddNewQustionForm";
            Text = "AddNewQustionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textAddQuestionLabel;
        private TextBox textAddQuestionBox;
        private Label requestTextLabel;
        private TextBox textAnswertBox;
        private Button button1;
    }
}