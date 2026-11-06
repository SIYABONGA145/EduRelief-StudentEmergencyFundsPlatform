using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.SqlClient;

namespace EduRelief
{
    public static class DbHelper
    {
        public static string ConnectionString = @"Data Source=SERCOSS\SQLEXPRESS01;Initial Catalog=StudentRelieFundDB;Integrated Security=True;Encrypt=False";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static string HashPassword(string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hash = SHA256.HashData(bytes);
            return Convert.ToHexString(hash).ToLower();
        }
    }
}