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
            deleteBtn = new Button();
            updateBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            firstNameTB = new TextBox();
            lastNameTB = new TextBox();
            ageTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)studentsDGV).BeginInit();
            SuspendLayout();
            // 
            // studentsDGV
            // 
            studentsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsDGV.Location = new Point(12, 63);
            studentsDGV.Name = "studentsDGV";
            studentsDGV.Size = new Size(632, 375);
            studentsDGV.TabIndex = 0;
            studentsDGV.SelectionChanged += studentsDGV_SelectionChanged;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(794, 9);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(91, 40);
            backBtn.TabIndex = 6;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(569, 34);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 9;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(742, 351);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 23);
            updateBtn.TabIndex = 16;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(700, 289);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 13;
            label3.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(700, 227);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 14;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(700, 160);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 15;
            label1.Text = "First Name";
            // 
            // firstNameTB
            // 
            firstNameTB.Location = new Point(700, 178);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.Size = new Size(147, 23);
            firstNameTB.TabIndex = 17;
            // 
            // lastNameTB
            // 
            lastNameTB.Location = new Point(700, 245);
            lastNameTB.Name = "lastNameTB";
            lastNameTB.Size = new Size(147, 23);
            lastNameTB.TabIndex = 18;
            // 
            // ageTB
            // 
            ageTB.Location = new Point(700, 307);
            ageTB.Name = "ageTB";
            ageTB.Size = new Size(147, 23);
            ageTB.TabIndex = 19;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 450);
            Controls.Add(ageTB);
            Controls.Add(lastNameTB);
            Controls.Add(firstNameTB);
            Controls.Add(updateBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deleteBtn);
            Controls.Add(backBtn);
            Controls.Add(studentsDGV);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)studentsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView studentsDGV;
        private Button backBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox firstNameTB;
        private TextBox lastNameTB;
        private TextBox ageTB;
    }
}