using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace WindowsFormsApp1
{
    internal class DataConnection
    {
        string conn;
        public DataConnection()
        {
            string serverName = Environment.MachineName;
           conn = $"Data Source={serverName};AttachDbFilename=|DataDirectory|\\QuanLy.mdf;Integrated Security=True;User Instance=True";
            //conn = "Data source = DESKTOP-UTCJ4KB\\SQLEXPRESS;Initial Catalog=QuanLy;Integrated Security=true";

        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(conn);
        }
        

        }
 
    }
