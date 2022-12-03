using static System.Net.Mime.MediaTypeNames;
using System;
using DailyEnglish.Models;
using System.Data.SqlClient;
using NuGet.Protocol.Plugins;
using Microsoft.AspNet.SignalR.Infrastructure;

namespace DailyEnglish.Services
{
    public class UsersDAo
    {
        string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog = Test; Integrated Security = True;
            Connect Timeout = 30;
            Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public bool FindUserByNameAndPassword(UserModel user)
        {
            bool success = false;
            string sqlStatement = "SELECT * FROM dbo.Users WHERE username=@username AND password=@password";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 40).Value = user.UserName;
                command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 40).Value = user.Password;
                try
                {
                    connection.Open();
                    // SqlDateReader reader = command.ExecuteReader();

                    if (command.ExecuteReader().HasRows)
                    {
                        success = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            };

            return success;
            // return true if found in the db.
        }
    }
    
}
