namespace DiffusionWinFormsApp
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
            topBlueLabel = new Label();
            leftBlueLabel = new Label();
            rightBlueLabel = new Label();
            downBlueLabel = new Label();
            procentLabel = new Label();
            leftPinkLabel = new Label();
            topPinkLabel = new Label();
            rightPinkLabel = new Label();
            downPinkLabel = new Label();
            SuspendLayout();
            // 
            // topBlueLabel
            // 
            topBlueLabel.AutoSize = true;
            topBlueLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            topBlueLabel.ForeColor = Color.DodgerBlue;
            topBlueLabel.Location = new Point(380, 9);
            topBlueLabel.Name = "topBlueLabel";
            topBlueLabel.Size = new Size(18, 18);
            topBlueLabel.TabIndex = 0;
            topBlueLabel.Text = "0";
            // 
            // leftBlueLabel
            // 
            leftBlueLabel.AutoSize = true;
            leftBlueLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            leftBlueLabel.ForeColor = Color.DodgerBlue;
            leftBlueLabel.Location = new Point(12, 305);
            leftBlueLabel.Name = "leftBlueLabel";
            leftBlueLabel.Size = new Size(18, 18);
            leftBlueLabel.TabIndex = 1;
            leftBlueLabel.Text = "0";
            // 
            // rightBlueLabel
            // 
            rightBlueLabel.AutoSize = true;
            rightBlueLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rightBlueLabel.ForeColor = Color.DodgerBlue;
            rightBlueLabel.Location = new Point(761, 305);
            rightBlueLabel.Name = "rightBlueLabel";
            rightBlueLabel.Size = new Size(18, 18);
            rightBlueLabel.TabIndex = 2;
            rightBlueLabel.Text = "0";
            // 
            // downBlueLabel
            // 
            downBlueLabel.AutoSize = true;
            downBlueLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            downBlueLabel.ForeColor = Color.DodgerBlue;
            downBlueLabel.Location = new Point(380, 651);
            downBlueLabel.Name = "downBlueLabel";
            downBlueLabel.Size = new Size(18, 18);
            downBlueLabel.TabIndex = 3;
            downBlueLabel.Text = "0";
            // 
            // procentLabel
            // 
            procentLabel.AutoSize = true;
            procentLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            procentLabel.Location = new Point(661, 42);
            procentLabel.Name = "procentLabel";
            procentLabel.Size = new Size(18, 18);
            procentLabel.TabIndex = 4;
            procentLabel.Text = "0";
            // 
            // leftPinkLabel
            // 
            leftPinkLabel.AutoSize = true;
            leftPinkLabel.BackColor = Color.LightYellow;
            leftPinkLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            leftPinkLabel.ForeColor = Color.HotPink;
            leftPinkLabel.Location = new Point(12, 334);
            leftPinkLabel.Name = "leftPinkLabel";
            leftPinkLabel.Size = new Size(18, 18);
            leftPinkLabel.TabIndex = 5;
            leftPinkLabel.Text = "0";
            // 
            // topPinkLabel
            // 
            topPinkLabel.AutoSize = true;
            topPinkLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            topPinkLabel.ForeColor = Color.HotPink;
            topPinkLabel.Location = new Point(415, 9);
            topPinkLabel.Name = "topPinkLabel";
            topPinkLabel.Size = new Size(18, 18);
            topPinkLabel.TabIndex = 6;
            topPinkLabel.Text = "0";
            // 
            // rightPinkLabel
            // 
            rightPinkLabel.AutoSize = true;
            rightPinkLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rightPinkLabel.ForeColor = Color.HotPink;
            rightPinkLabel.Location = new Point(761, 334);
            rightPinkLabel.Name = "rightPinkLabel";
            rightPinkLabel.Size = new Size(18, 18);
            rightPinkLabel.TabIndex = 7;
            rightPinkLabel.Text = "0";
            // 
            // downPinkLabel
            // 
            downPinkLabel.AutoSize = true;
            downPinkLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            downPinkLabel.ForeColor = Color.HotPink;
            downPinkLabel.Location = new Point(415, 651);
            downPinkLabel.Name = "downPinkLabel";
            downPinkLabel.Size = new Size(18, 18);
            downPinkLabel.TabIndex = 8;
            downPinkLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(800, 678);
            Controls.Add(downPinkLabel);
            Controls.Add(rightPinkLabel);
            Controls.Add(topPinkLabel);
            Controls.Add(leftPinkLabel);
            Controls.Add(procentLabel);
            Controls.Add(downBlueLabel);
            Controls.Add(rightBlueLabel);
            Controls.Add(leftBlueLabel);
            Controls.Add(topBlueLabel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Диффузия!";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label topBlueLabel;
        private Label leftBlueLabel;
        private Label rightBlueLabel;
        private Label downBlueLabel;
        private Label procentLabel;
        private Label leftPinkLabel;
        private Label topPinkLabel;
        private Label rightPinkLabel;
        private Label downPinkLabel;
    }
}
