namespace WinFormsApp
{
    partial class RemoveQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveQuestionForm));
            listQuestionLabel = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            continueRemoveQuestionButton = new Button();
            dataGridView1 = new DataGridView();
            NumberQuestionColumn = new DataGridViewTextBoxColumn();
            QuestionsColumn = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listQuestionLabel
            // 
            listQuestionLabel.AutoSize = true;
            listQuestionLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            listQuestionLabel.Location = new Point(25, 25);
            listQuestionLabel.Name = "listQuestionLabel";
            listQuestionLabel.Size = new Size(167, 25);
            listQuestionLabel.TabIndex = 0;
            listQuestionLabel.Text = "Список вопросов";
            // 
            // toolStrip1
            // 
            toolStrip1.AllowClickThrough = true;
            toolStrip1.AllowDrop = true;
            toolStrip1.BackColor = Color.White;
            toolStrip1.ImeMode = ImeMode.Disable;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.ShowItemToolTips = false;
            toolStrip1.Size = new Size(796, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // continueRemoveQuestionButton
            // 
            continueRemoveQuestionButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            continueRemoveQuestionButton.Location = new Point(227, 427);
            continueRemoveQuestionButton.Name = "continueRemoveQuestionButton";
            continueRemoveQuestionButton.Size = new Size(297, 74);
            continueRemoveQuestionButton.TabIndex = 4;
            continueRemoveQuestionButton.Text = "Далее";
            continueRemoveQuestionButton.UseVisualStyleBackColor = true;
            continueRemoveQuestionButton.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NumberQuestionColumn, QuestionsColumn });
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(4, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ScrollBars = ScrollBars.Horizontal;
            dataGridView1.Size = new Size(792, 323);
            dataGridView1.TabIndex = 5;         
            // 
            // NumberQuestionColumn
            // 
            NumberQuestionColumn.FillWeight = 150F;
            NumberQuestionColumn.HeaderText = "Номер вопроса";
            NumberQuestionColumn.Name = "NumberQuestionColumn";
            NumberQuestionColumn.Width = 150;
            // 
            // QuestionsColumn
            // 
            QuestionsColumn.FillWeight = 600F;
            QuestionsColumn.HeaderText = "Вопрос";
            QuestionsColumn.Name = "QuestionsColumn";
            QuestionsColumn.Width = 600;
            // 
            // RemoveQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(796, 598);
            Controls.Add(dataGridView1);
            Controls.Add(continueRemoveQuestionButton);
            Controls.Add(toolStrip1);
            Controls.Add(listQuestionLabel);
            Name = "RemoveQuestionForm";
            Text = "RemoveQuestionForm";
            Load += removeQuestionForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label listQuestionLabel;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private Button continueRemoveQuestionButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NumberQuestionColumn;
        private DataGridViewTextBoxColumn QuestionsColumn;
    }
}