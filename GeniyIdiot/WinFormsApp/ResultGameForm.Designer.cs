namespace WinFormsApp
{
    partial class ResultGameForm
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
            textTablLabel = new Label();
            dataGridView = new DataGridView();
            UserNameCoium = new DataGridViewTextBoxColumn();
            CountRightAncwersColumn = new DataGridViewTextBoxColumn();
            DiagnoseColumn = new DataGridViewTextBoxColumn();
            backToMenuButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // textTablLabel
            // 
            textTablLabel.AutoSize = true;
            textTablLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textTablLabel.Location = new Point(138, 37);
            textTablLabel.Name = "textTablLabel";
            textTablLabel.Size = new Size(221, 30);
            textTablLabel.TabIndex = 0;
            textTablLabel.Text = "Таблица результатов";
            // 
            // dataGridView
            // 
            dataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { UserNameCoium, CountRightAncwersColumn, DiagnoseColumn });
            dataGridView.Location = new Point(80, 96);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(345, 374);
            dataGridView.TabIndex = 1;
            // 
            // UserNameCoium
            // 
            UserNameCoium.HeaderText = "Имя";
            UserNameCoium.Name = "UserNameCoium";
            // 
            // CountRightAncwersColumn
            // 
            CountRightAncwersColumn.HeaderText = "Количество правильных ответов";
            CountRightAncwersColumn.Name = "CountRightAncwersColumn";
            // 
            // DiagnoseColumn
            // 
            DiagnoseColumn.HeaderText = "Диагноз";
            DiagnoseColumn.Name = "DiagnoseColumn";
            // 
            // backToMenuButton
            // 
            backToMenuButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backToMenuButton.Location = new Point(138, 476);
            backToMenuButton.Name = "backToMenuButton";
            backToMenuButton.Size = new Size(231, 94);
            backToMenuButton.TabIndex = 2;
            backToMenuButton.Text = "Назад";
            backToMenuButton.UseVisualStyleBackColor = true;
            backToMenuButton.Click += backToMenuButton_Click;
            // 
            // ResultGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 646);
            Controls.Add(backToMenuButton);
            Controls.Add(dataGridView);
            Controls.Add(textTablLabel);
            Name = "ResultGameForm";
            Text = "ResultGameForm";
            Load += resultGameForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textTablLabel;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn UserNameCoium;
        private DataGridViewTextBoxColumn CountRightAncwersColumn;
        private DataGridViewTextBoxColumn DiagnoseColumn;
        private Button backToMenuButton;
    }
}