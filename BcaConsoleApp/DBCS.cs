namespace Quanta
{
   public class demodb 
   {
     const string ConString = "Server=.\\SQLEXPRESS; Integrated Security=True; Database=bca;"
       public void addStudents()
       {
         try{
           SqlConnection sqlcon = new SqlConnection(ConString);
           SqlCommand sqlCmd = new SqlCommand("INSERT INTO Student VALUES(21, 'Ram', 'Thapa', 12)", sqlcon);
          sqlcon.Open();
          int row_num = sqlCmd.ExecuteNonQuery();
          sqlcon.Close();
         }
         catch(SqlException ex)
         {
           Console.WriteLine(ex.Message);
         }
       }
   }
}
