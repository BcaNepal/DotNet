namespace BcaConsoleApp;
private void submitButton_Click(object sender, EventArgs e)
{
    // Replace 'ConnectionString' with your actual connection string
    string connectionString = "ConnectionString";

    // Replace 'TableName' with the name of your database table
    string tableName = "TableName";

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        string query = "INSERT INTO " + tableName + " (FullName, Email, Username, Password) VALUES (@FullName, @Email, @Username, @Password)";
        SqlCommand command = new SqlCommand(query, connection);

        // Assuming you have textboxes named txtFullName, txtEmail, txtUsername, and txtPassword
        command.Parameters.AddWithValue("@FullName", txtFullName.Text);
        command.Parameters.AddWithValue("@Email", txtEmail.Text);
        command.Parameters.AddWithValue("@Username", txtUsername.Text);
        command.Parameters.AddWithValue("@Password", txtPassword.Text);

        try
        {
            connection.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("Registration successful!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Registration failed: " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }
}
