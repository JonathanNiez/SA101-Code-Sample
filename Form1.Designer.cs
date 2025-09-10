namespace SA101
{
    partial class Form1
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
            createTableBtn = new Button();
            dropTableBtn = new Button();
            firstNameTB = new TextBox();
            lastNameTB = new TextBox();
            ageTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            addButton = new Button();
            goToForm2Btn = new Button();
            checkConnectionBtn = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // createTableBtn
            // 
            createTableBtn.Location = new Point(199, 12);
            createTableBtn.Name = "createTableBtn";
            createTableBtn.Size = new Size(144, 36);
            createTableBtn.TabIndex = 0;
            createTableBtn.Text = "Create Table";
            createTableBtn.UseVisualStyleBackColor = true;
            createTableBtn.Click += loadBtn_Click;
            // 
            // dropTableBtn
            // 
            dropTableBtn.Location = new Point(199, 54);
            dropTableBtn.Name = "dropTableBtn";
            dropTableBtn.Size = new Size(144, 36);
            dropTableBtn.TabIndex = 1;
            dropTableBtn.Text = "Drop Table";
            dropTableBtn.UseVisualStyleBackColor = true;
            dropTableBtn.Click += button1_Click;
            // 
            // firstNameTB
            // 
            firstNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameTB.Location = new Point(12, 199);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.Size = new Size(161, 29);
            firstNameTB.TabIndex = 2;
            // 
            // lastNameTB
            // 
            lastNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameTB.Location = new Point(12, 266);
            lastNameTB.Name = "lastNameTB";
            lastNameTB.Size = new Size(161, 29);
            lastNameTB.TabIndex = 2;
            // 
            // ageTB
            // 
            ageTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ageTB.Location = new Point(12, 328);
            ageTB.Name = "ageTB";
            ageTB.Size = new Size(161, 29);
            ageTB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 181);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 248);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 310);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 3;
            label3.Text = "Age";
            // 
            // addButton
            // 
            addButton.Location = new Point(54, 372);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // goToForm2Btn
            // 
            goToForm2Btn.Location = new Point(697, 12);
            goToForm2Btn.Name = "goToForm2Btn";
            goToForm2Btn.Size = new Size(91, 40);
            goToForm2Btn.TabIndex = 5;
            goToForm2Btn.Text = "Go to Form 2";
            goToForm2Btn.UseVisualStyleBackColor = true;
            goToForm2Btn.Click += goToForm2Btn_Click;
            // 
            // checkConnectionBtn
            // 
            checkConnectionBtn.Location = new Point(12, 12);
            checkConnectionBtn.Name = "checkConnectionBtn";
            checkConnectionBtn.Size = new Size(117, 40);
            checkConnectionBtn.TabIndex = 1;
            checkConnectionBtn.Text = "Check Connection";
            checkConnectionBtn.UseVisualStyleBackColor = true;
            checkConnectionBtn.Click += checkConnectionBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(697, 395);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(97, 43);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitBtn);
            Controls.Add(goToForm2Btn);
            Controls.Add(addButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ageTB);
            Controls.Add(lastNameTB);
            Controls.Add(firstNameTB);
            Controls.Add(checkConnectionBtn);
            Controls.Add(dropTableBtn);
            Controls.Add(createTableBtn);
            Name = "Form1";
            Text = "Form 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createTableBtn;
        private Button dropTableBtn;
        private TextBox firstNameTB;
        private TextBox lastNameTB;
        private TextBox ageTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button addButton;
        private Button goToForm2Btn;
        private Button checkConnectionBtn;
        private Button exitBtn;
    }
}
