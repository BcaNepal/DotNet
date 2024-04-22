using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BcaConsoleApp
{
    public class DbDemo
    {

        //inset into database 
        //const string  CONSTRING = "Data Source=.\\SQLEXPRESS; Integrated Security=True; Database=bca";
        const string CONSTRING = "Server=.\\SQLEXPRESS; Integrated Security=True; Database=bca";
        public void addStudent()
        {
            try
            {

                SqlConnection sqlCon = new SqlConnection(CONSTRING);
                //SQlCommand sqlCmd;

                SqlCommand sqlCmd = new SqlCommand("INSERT INTO Student VALUES(21, 'Ram', 'Thapa', 21) ", sqlCon);

                //open the database connection
                // connected architecture

                sqlCon.Open();

                int row_num = sqlCmd.ExecuteNonQuery();
                // command is executed
                sqlCon.Close();

                Console.WriteLine($"{row_num} Row(s) Added");
                //Console.WriteLine(row_num + " Row(s) Added");
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void deleteStudent(int std_id)
        {
            try
            {

                SqlConnection sqlCon = new SqlConnection(CONSTRING);
                //SQlCommand sqlCmd;

                SqlCommand sqlCmd = new SqlCommand("DELETE FROM Student WHERE id = " + std_id, sqlCon);

                //open the database connection
                // connected architecture

                sqlCon.Open();

                int row_num = sqlCmd.ExecuteNonQuery();
                // command is executed
                sqlCon.Close();

                Console.WriteLine($"{row_num} Student(s) deleted");
                //Console.WriteLine(row_num + " Student(s) Deleted");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void updateStudent(int stdId, string fname, string lname, int age)
        {
            try
            {

                SqlConnection sqlCon = new SqlConnection(CONSTRING);
                //SQlCommand sqlCmd;

                //SqlCommand sqlCmd = new SqlCommand("UPDATE Student SET fname ='" + fname +"' ,lname ='" + lname + "' ,age=" + age + " Where id="+ stdId , sqlCon);
                //SqlCommand sqlCmd = new SqlCommand($"UPDATE Student SET fname='{fname}', lname='{lname}', age={age} " , sqlCon);
                SqlCommand sqlCmd = new SqlCommand("UPDATE Student SET fname=@fname, lname=@lname, age=@age WHERE id=@id", sqlCon);
                sqlCmd.Parameters.AddWithValue("@fname", fname);
                sqlCmd.Parameters.AddWithValue("@lname", lname);
                sqlCmd.Parameters.AddWithValue("@age", age);
                sqlCmd.Parameters.AddWithValue("@id", stdId);
                //open the database connection
                // connected architecture
                sqlCmd.CommandType = CommandType.Text;
                sqlCon.Open();

                int row_num = sqlCmd.ExecuteNonQuery();
                // command is executed
                sqlCon.Close();

                Console.WriteLine($"{row_num} Student(s) Updated");
                //Console.WriteLine(row_num + " Student(s) Deleted");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
