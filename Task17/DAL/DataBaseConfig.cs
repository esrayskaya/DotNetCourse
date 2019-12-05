using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DAL
{
    public class DataBaseConfig
    {
        public static string GetConnectionString()
        {
            return @"Data Source=.\SQLEXPRESS;Initial Catalog=Users_and_award;Integrated Security=True";
        }
        
    }
}
