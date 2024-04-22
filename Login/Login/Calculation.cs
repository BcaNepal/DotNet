using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Calculation : Form
    {
        public Calculation()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            { // write code here
                string strNum1 = txtNum1.Text;
                string strNum2 = txtNum2.Text;

                float num1 = Convert.ToSingle(strNum1);
                //num1 int? = 5;

                //int nn1 = 6;
                //float num1 = float.Parse(strNum1);
                float num2 = float.Parse(strNum2);
                float addition = num1 + num2; // Arithemtic operation
                                              // txtResult.Text = Convert.ToString(addition); // addition.ToString();
                txtResult.Text = addition.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Polymorphism
        // Method (functrion) name is same but signature is different 
        // function overloading
        private void add()
        {
            string strNum1 = txtNum1.Text;
            string strNum2 = txtNum2.Text;
            float num1 = Convert.ToSingle(strNum1);
            //float num1 = float.Parse(strNum1);
            float num2 = float.Parse(strNum2);
            float addition = num1 + num2;
            lblResult.Text = Convert.ToString(addition); // addition.ToString();
            //txtResult.Text  = Convert.ToString(addition);

            //float a = Convert.ToSingle(strNum2);
            float number1 = 23.6f;
            float number2 = 45.56F;
            float numAdd = num1 + num2;
            Console.WriteLine(numAdd);

        }

        private void add(float num1, float num2)
        {
            //float addition = num1 + num2;
            //lblResult.Text = Convert.ToString(addition); // addition.ToString();
            // lblResult.Text = (num1 + num2).ToString();
            //lblResult.Text = Convert.ToString(num1 + num2);
            Console.WriteLine(num1 + num2);
        }

        private void add(float num1)
        {
            //string strNum1 = txtNum1.Text;
            string strNum2 = txtNum2.Text;
            // float num1 = Convert.ToSingle(strNum1);
            //float num1 = float.Parse(strNum1);
            float num2 = float.Parse(strNum2);
            float addition = num1 + num2;
            lblResult.Text = Convert.ToString(addition); // addition.ToString();
            //txtResult.Text  = Convert.ToString(addition);

            //float a = Convert.ToSingle(strNum2);
        }

        private void add(int num1, int num2)
        {
            // string strNum1 = txtNum1.Text;
            // string strNum2 = txtNum2.Text;
            /// float num1 = Convert.ToSingle(strNum1);
            //float num1 = float.Parse(strNum1);
            //float num2 = float.Parse(strNum2);
            float addition = num1 + num2;
            lblResult.Text = Convert.ToString(addition); // addition.ToString();
            //txtResult.Text  = Convert.ToString(addition);
            //float a = Convert.ToSingle(strNum2);
        }
        private void add(int num1, float num2)
        {
            //string strNum1 = txtNum1.Text;
            //string strNum2 = txtNum2.Text;
            //float num1 = Convert.ToSingle(strNum1);
            //float num1 = float.Parse(strNum1);
            //float num2 = float.Parse(strNum2);
            float addition = num1 + num2;
            lblResult.Text = Convert.ToString(addition); // addition.ToString();
            //txtResult.Text  = Convert.ToString(addition);

            //float a = Convert.ToSingle(strNum2);
        }


        private void subtract()
        {
            string strNum1 = txtNum1.Text;
            string strNum2 = txtNum2.Text;
            float num1 = Convert.ToSingle(strNum1);
            //float num1 = float.Parse(strNum1);
            float num2 = float.Parse(strNum2);
            float subtarction = num1 - num2;
            lblResult.Text = Convert.ToString(subtarction); // addition.ToString();
            //txtResult.Text  = Convert.ToString(addition);

            //float a = Convert.ToSingle(strNum2);
        }

        private void Calculation_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("hi");
            cmbCalcualtion.Items.Add("Add");
            cmbCalcualtion.Items.Add("Subtract");
            cmbCalcualtion.Items.Add("Multiply");
            cmbCalcualtion.Items.Add("Divide");

            cmbProgram.Items.Add("BCA");
            cmbProgram.Items.Add("BCIT");

            // Date

            //DateTime dt = new DateTime();

            //lblDate.Text = DateTime.Today.ToShortDateString();
            lblDate.Text = DateTime.Now.ToLongDateString();
            DateTime dt1 = DateTime.Today;
            //DateTime dt2 = new DateTime(2000, 12, 23);
            // dt2 = dt2 - dt1;





        }

        private void cmbCalcualtion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // float num1 = float.Parse(txtNum1.Text);
                int idx = cmbCalcualtion.SelectedIndex;
                //string selectedCal = cmbCalcualtion.SelectedItem.ToString();
                switch (idx)
                {
                    case 0:

                        add(float.Parse(txtNum1.Text), float.Parse(txtNum2.Text));
                        break;
                    case 1:
                        subtract();
                        break;
                }
            } // try block
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {           
            
            float num1 = float.Parse(txtNum1.Text);            
            float num2 = float.Parse(txtNum2.Text);
            float subtarction = num1 - num2;
            //txtResult.Text = Convert.ToString(subtarction); 
            txtResult.Text  = subtarction.ToString();
        }
    }
}
