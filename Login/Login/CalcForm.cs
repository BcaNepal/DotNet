namespace Login
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);

            double result = Math.Pow(num1, num2);
            //txtResult.Text = result.ToString();
            txtResult.Text = Convert.ToString(result);
        }

        public void displayArray()
        {
            string[] colors = { "red", "green", "blue"};

            foreach(string color in colors)
            {
                Console.WriteLine(color);
            }

            for(int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }

            int j = 0;
            while(j < colors.Length)
            {
                Console.WriteLine(colors[j]);
                j++;
            }

            int k = 0;

            do
            {
                Console.WriteLine(colors[k]);
                k++;
            }
            while (k < colors.Length);
        }
    }
}
