namespace _2048WinFormsApp
{
    partial class ResultForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView = new DataGridView();
            Column = new DataGridViewTextBoxColumn();
            ScoreTable = new DataGridViewTextBoxColumn();
            BackToMenuButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.BackgroundColor = Color.Bisque;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Column, ScoreTable });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Location = new Point(45, 64);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView.Size = new Size(357, 457);
            dataGridView.TabIndex = 0;
            // 
            // Column
            // 
            Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column.HeaderText = "Имя";
            Column.Name = "Column";
            Column.ReadOnly = true;
            // 
            // ScoreTable
            // 
            ScoreTable.HeaderText = "Счет";
            ScoreTable.Name = "ScoreTable";
            ScoreTable.ReadOnly = true;
            // 
            // BackToMenuButton
            // 
            BackToMenuButton.BackColor = Color.SandyBrown;
            BackToMenuButton.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackToMenuButton.ForeColor = SystemColors.ActiveCaptionText;
            BackToMenuButton.Location = new Point(25, 19);
            BackToMenuButton.Name = "BackToMenuButton";
            BackToMenuButton.Size = new Size(111, 27);
            BackToMenuButton.TabIndex = 1;
            BackToMenuButton.Text = "Назад";
            BackToMenuButton.UseVisualStyleBackColor = false;
            BackToMenuButton.Click += BackToMenuButton_Click;
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(442, 546);
            Controls.Add(BackToMenuButton);
            Controls.Add(dataGridView);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "ResultForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResultForm";
            Load += ResultForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Column;
        private DataGridViewTextBoxColumn ScoreTable;
        private Button BackToMenuButton;
    }
}