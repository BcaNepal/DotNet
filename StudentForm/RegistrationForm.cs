using System.Data.SqlClient;

namespace StudentForm
{
    public partial class RegistrationForm : Form
    {
        const string CONNECTION_STRING = "SERVER=.\\SQLEXPRESS;Integrated Security=True; DATABASE=bca";
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(CONNECTION_STRING);
                SqlCommand sqlCmd = new SqlCommand("INSERT INTO Student VALUES(@id, @fname, @lname, @age)", sqlCon);
                sqlCmd.Parameters.AddWithValue("@id", txtId.Text);
                sqlCmd.Parameters.AddWithValue("@fname", txtFname.Text);
                sqlCmd.Parameters.AddWithValue("@lname", txtLname.Text);
                sqlCmd.Parameters.AddWithValue("@age", txtAge.Text);

                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {             
                SqlConnection sqlCon = new SqlConnection(CONNECTION_STRING);
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Student WHERE id =@id", sqlCon);
                sqlCmd.Parameters.AddWithValue("@id", txtId.Text);
                sqlCon.Open();
                // command is executed here
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if(reader.Read())
                {
                    txtFname.Text = reader.GetString(1);
                    txtLname.Text = reader.GetString(2);
                    txtAge.Text = reader.GetInt32(3).ToString();
                }
                else
                {
                    MessageBox.Show("Student not found");
                    txtFname.Text = string.Empty;
                    txtLname.Text = "";
                    txtAge.Clear();
                }
                sqlCon.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
