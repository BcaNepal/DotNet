namespace StudentForm
{
    partial class RegistrationForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtFname = new TextBox();
            txtLname = new TextBox();
            txtAge = new TextBox();
            btnAddStudent = new Button();
            btnFind = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 93);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 122);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // txtId
            // 
            txtId.Location = new Point(100, 32);
            txtId.Name = "txtId";
            txtId.Size = new Size(129, 23);
            txtId.TabIndex = 4;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(100, 61);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(129, 23);
            txtFname.TabIndex = 5;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(100, 90);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(129, 23);
            txtLname.TabIndex = 6;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(100, 119);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(129, 23);
            txtAge.TabIndex = 7;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(16, 159);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(112, 35);
            btnAddStudent.TabIndex = 8;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnFind
            // 
            btnFind.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFind.Location = new Point(235, 32);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(47, 23);
            btnFind.TabIndex = 9;
            btnFind.Text = "...";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFind);
            Controls.Add(btnAddStudent);
            Controls.Add(txtAge);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "Student Registration Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtFname;
        private TextBox txtLname;
        private TextBox txtAge;
        private Button btnAddStudent;
        private Button btnFind;
    }
}
