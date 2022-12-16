using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kyrs
{
    class DataBese
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source = DESKTOP-U66RBEN; Initial Catalog = kyrs; Integrated Security = true");

        public void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed) 
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }


    }
}
