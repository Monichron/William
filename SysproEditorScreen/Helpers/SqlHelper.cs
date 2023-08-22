using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysproEditorScreen.Helpers
{
    public static class SqlHelper
    {
       public static string Con;
       public static DataTable OriginalDataTable;
        static SqlHelper()
        {
            Con = JsonConfig.Appsettings["SqlCon"];
            OriginalDataTable = GetTable();
        }
        static DataTable GetTable()
        {
            DataTable dataTable = new DataTable();
            string tableName = JsonConfig.Appsettings["TableName"];

            using (SqlConnection connection = new SqlConnection(Con))
            {
                string query = $"SELECT * FROM {tableName}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;

        }
    }
}
