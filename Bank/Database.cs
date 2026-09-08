

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


using Microsoft.Data.SqlClient;

namespace Bank
{
    public class Database
    {
        private readonly string connectionString =
            @"Server=localhost;Database=BankDb;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}