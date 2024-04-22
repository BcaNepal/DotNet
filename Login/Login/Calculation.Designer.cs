namespace Login
{
    partial class Calculation
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            btnMultiply = new Button();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnDivide = new Button();
            lblResult = new Label();
            cmbCalcualtion = new ComboBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            rbMultiply = new RadioButton();
            rbSubtract = new RadioButton();
            rbAdd = new RadioButton();
            groupBox2 = new GroupBox();
            lstCalculation = new ListBox();
            cmbProgram = new ComboBox();
            lblDate = new Label();
            txtResult = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Number 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 50);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Number 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 76);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Result";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(101, 18);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(101, 47);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 4;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(3, 51);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(99, 23);
            btnMultiply.TabIndex = 6;
            btnMultiply.Text = "Multiply";
            btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(108, 22);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(92, 23);
            btnSubtract.TabIndex = 8;
            btnSubtract.Text = "Subtract";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(108, 51);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(92, 23);
            btnDivide.TabIndex = 9;
            btnDivide.Text = "Divide";
            btnDivide.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(101, 76);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 10;
            // 
            // cmbCalcualtion
            // 
            cmbCalcualtion.FormattingEnabled = true;
            cmbCalcualtion.Location = new Point(126, 194);
            cmbCalcualtion.Name = "cmbCalcualtion";
            cmbCalcualtion.Size = new Size(143, 23);
            cmbCalcualtion.TabIndex = 11;
            cmbCalcualtion.Text = "Choose Calculation";
            cmbCalcualtion.SelectedIndexChanged += cmbCalcualtion_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(rbMultiply);
            groupBox1.Controls.Add(rbSubtract);
            groupBox1.Controls.Add(rbAdd);
            groupBox1.Location = new Point(28, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 56);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculation By Selecting RadioButton";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(222, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(58, 19);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Divide";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // rbMultiply
            // 
            rbMultiply.AutoSize = true;
            rbMultiply.Location = new Point(147, 22);
            rbMultiply.Name = "rbMultiply";
            rbMultiply.Size = new Size(69, 19);
            rbMultiply.TabIndex = 2;
            rbMultiply.TabStop = true;
            rbMultiply.Text = "Multiply";
            rbMultiply.UseVisualStyleBackColor = true;
            // 
            // rbSubtract
            // 
            rbSubtract.AutoSize = true;
            rbSubtract.Location = new Point(72, 22);
            rbSubtract.Name = "rbSubtract";
            rbSubtract.Size = new Size(69, 19);
            rbSubtract.TabIndex = 1;
            rbSubtract.TabStop = true;
            rbSubtract.Text = "Subtract";
            rbSubtract.UseVisualStyleBackColor = true;
            // 
            // rbAdd
            // 
            rbAdd.AutoSize = true;
            rbAdd.Location = new Point(8, 22);
            rbAdd.Name = "rbAdd";
            rbAdd.Size = new Size(47, 19);
            rbAdd.TabIndex = 0;
            rbAdd.TabStop = true;
            rbAdd.Text = "Add";
            rbAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSubtract);
            groupBox2.Controls.Add(btnMultiply);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnDivide);
            groupBox2.Location = new Point(320, 76);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(215, 90);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Calculation By Button Click";
            // 
            // lstCalculation
            // 
            lstCalculation.FormattingEnabled = true;
            lstCalculation.ItemHeight = 15;
            lstCalculation.Items.AddRange(new object[] { "Add", "Subtract", "Multiply", "Divide" });
            lstCalculation.Location = new Point(36, 194);
            lstCalculation.Name = "lstCalculation";
            lstCalculation.Size = new Size(74, 79);
            lstCalculation.TabIndex = 14;
            // 
            // cmbProgram
            // 
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Location = new Point(299, 194);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(121, 23);
            cmbProgram.TabIndex = 15;
            cmbProgram.Text = "Choose Program";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(299, 21);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 16;
            lblDate.Text = "Date";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(100, 76);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 17;
            // 
            // Calculation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 288);
            Controls.Add(txtResult);
            Controls.Add(lblDate);
            Controls.Add(cmbProgram);
            Controls.Add(lstCalculation);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(cmbCalcualtion);
            Controls.Add(lblResult);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Calculation";
            Text = "Calculation";
            Load += Calculation_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button btnMultiply;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnDivide;
        private Label lblResult;
        private ComboBox cmbCalcualtion;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton rbMultiply;
        private RadioButton rbSubtract;
        private RadioButton rbAdd;
        private GroupBox groupBox2;
        private ListBox lstCalculation;
        private ComboBox cmbProgram;
        private Label lblDate;
        private TextBox txtResult;
    }
}