using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Web_Task_Dot_Net.DAL.Gateway
{
    public class Gateway
    {
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataReader Reader { get; set; }
        public string Query { get; set; }

        private string connectionString;

        public Gateway()
        {
            connectionString = WebConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            Connection = new SqlConnection(connectionString);

        }

     
    }
}