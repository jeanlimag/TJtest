using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;


using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace TJTest.Models
{
    public class DbTJTest
    {
        public bool RegisterNewClient(string clientName)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection("Data Source=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=tjtest;Data Source=DESKTOP-2AVPGQ2\\SQLEXPRESS");
            string query = $"insert into dbo.Clients values ('{clientName}')";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Connection.Open();
                result = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }

            return result > 0;


        }
        public bool SearchClient(string clientName)
        {
            bool result = false;

            SqlConnection connection = new SqlConnection("Data Source=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=tjtest;Data Source=DESKTOP-2AVPGQ2\\SQLEXPRESS");

            string query = $"select ID, name from Clients where name like '%{clientName}%'";


            using SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Connection.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        TJTestViewModel viewModel = new TJTestViewModel
                        {
                            IdClient = Convert.ToInt32(dr.GetValue(0)),
                            ClientName = dr.GetValue(1).ToString()
                        };
                        if(viewModel.IdClient != 0 && viewModel.ClientName != string.Empty)
                        {
                            result = true;
                        }
                    }
                }
            }
            cmd.Connection.Close();
            return result;
        }
    }
}
