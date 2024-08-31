using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class PosteData
    {
        public string Liste_departement { set; get; } // 2
        public string Nom_Poste { set; get; } // 1

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KANANAVY\DOCUMENTS\EMPLOYEEE.MDF;Integrated Security=True;Connect Timeout=30");

        public List<PosteData> PosteListData(string name)
        {
            List<PosteData> listdata = new List<PosteData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM poste WHERE  delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            PosteData ed = new PosteData();
                            ed.Nom_Poste = reader["poste_name"].ToString();
                            ed.Liste_departement = reader["liste_dep"].ToString();

                            listdata.Add(ed);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }
    }
}
