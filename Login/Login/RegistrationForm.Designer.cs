namespace Login
{
    partial class RegistrationForm
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            rbBCIT = new RadioButton();
            rbBCA = new RadioButton();
            btnLogin = new Button();
            txtDetails = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(106, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(31, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(205, 65);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton8);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(rbBCIT);
            groupBox2.Controls.Add(rbBCA);
            groupBox2.Location = new Point(47, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(226, 101);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Program";
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(106, 72);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(94, 19);
            radioButton7.TabIndex = 7;
            radioButton7.TabStop = true;
            radioButton7.Text = "radioButton7";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(6, 72);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(94, 19);
            radioButton8.TabIndex = 6;
            radioButton8.TabStop = true;
            radioButton8.Text = "radioButton8";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(100, 47);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(94, 19);
            radioButton5.TabIndex = 5;
            radioButton5.TabStop = true;
            radioButton5.Text = "radioButton5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(0, 47);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(94, 19);
            radioButton6.TabIndex = 4;
            radioButton6.TabStop = true;
            radioButton6.Text = "radioButton6";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // rbBCIT
            // 
            rbBCIT.AutoSize = true;
            rbBCIT.Location = new Point(106, 22);
            rbBCIT.Name = "rbBCIT";
            rbBCIT.Size = new Size(49, 19);
            rbBCIT.TabIndex = 3;
            rbBCIT.TabStop = true;
            rbBCIT.Text = "BCIT";
            rbBCIT.UseVisualStyleBackColor = true;
            // 
            // rbBCA
            // 
            rbBCA.AutoSize = true;
            rbBCA.Location = new Point(6, 22);
            rbBCA.Name = "rbBCA";
            rbBCA.Size = new Size(48, 19);
            rbBCA.TabIndex = 2;
            rbBCA.TabStop = true;
            rbBCA.Text = "BCA";
            rbBCA.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(66, 271);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Submit";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtDetails
            // 
            txtDetails.Location = new Point(323, 63);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.Size = new Size(265, 251);
            txtDetails.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(111, 97);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 100);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtDetails);
            Controls.Add(btnLogin);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton rbBCIT;
        private RadioButton rbBCA;
        private Button btnLogin;
        private TextBox txtDetails;
        private TextBox txtName;
        private Label label1;
    }
}