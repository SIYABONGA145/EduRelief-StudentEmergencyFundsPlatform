using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace EduRelief
{
    internal class AdoConnect
    {
        
        //create a connection object
        SqlConnection conn;
        SqlCommand cmd;

        //create a methos to connect to the database
        public bool GetConnected() 
        {
            bool result = false;
            try
            {
                conn = new SqlConnection("Data Source=SERCOSS\\SQLEXPRESS01;Initial Catalog=RegisteredStudents;" +
                    "Integrated Security=True;Encrypt=False");
                conn.Open();
                result = true;
            }
            catch(Exception ex) 
            {
                result = false;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        //method for adding or registering our user on the database
        //This method should tell us if the user was registerd successfully(yes) or not(no)
        //we user what is required from the user when they register as parameters
        public bool RegisterUsers(string studentNumber, string firstName, string lastName,
                           string passwordHash, bool acceptedTerms)
        {
            bool answer = false;
            try
            {
                string sql = "insert into RegisterStudents values ( @StudentNumber, @FirstName, @LastName, " +
                    "@PasswordHash, @AcceptedTerms)";
                //we use the above parameters that start with an at(@) symbol to try to avoid sql injections,
                //to prevent people from hacking the database 
                //now we use the sqlCommand class to inert,update and delete data in the database
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@studentNumber", studentNumber);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName ", lastName);
                cmd.Parameters.AddWithValue("@passwordHash", passwordHash);
                cmd.Parameters.AddWithValue("@AcceptedTerms", acceptedTerms);
                //open the database, so that all this data can be sent to the database
                conn.Open();
                cmd.ExecuteNonQuery();//takes the sql statement and conn and executes it onto the database
                answer = true;

            }
            catch (Exception ex) 
            {
                answer = false;
            }
            finally
            {
                conn.Close();
            }
            return answer;
        }
        
    }
}
//studentNumberfirstNamelastNameemailpasswordHashtelNumberacademicYearcourseaddressprofilePictureUrl
