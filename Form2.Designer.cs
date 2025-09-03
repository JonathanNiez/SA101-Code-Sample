namespace SA101
{
    partial class Form2
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
            studentsDGV = new DataGridView();
            backBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)studentsDGV).BeginInit();
            SuspendLayout();
            // 
            // studentsDGV
            // 
            studentsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsDGV.Location = new Point(12, 63);
            studentsDGV.Name = "studentsDGV";
            studentsDGV.Size = new Size(776, 375);
            studentsDGV.TabIndex = 0;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(697, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(91, 40);
            backBtn.TabIndex = 6;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backBtn);
            Controls.Add(studentsDGV);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)studentsDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView studentsDGV;
        private Button backBtn;
    }
}