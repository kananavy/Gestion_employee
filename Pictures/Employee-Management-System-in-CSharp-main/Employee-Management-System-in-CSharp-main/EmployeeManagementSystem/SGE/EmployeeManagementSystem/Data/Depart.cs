using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    internal class Depart
    {
        //public int ID { get; set; }
        public string Nom_Departement { set; get; } // 1
        public string Tache_Departement { set; get; } // 2
        


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KANANAVY\DOCUMENTS\EMPLOYEEE.MDF;Integrated Security=True;Connect Timeout=30");

        public List<Depart> DepartementListData(string name)
        {
            List<Depart> listdata = new List<Depart>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM departement WHERE  delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Depart ed = new Depart();
                            //ed.ID = (int)reader["id"];
                            ed.Nom_Departement = reader["depart_name"].ToString();
                            ed.Tache_Departement = reader["depart_tache"].ToString();

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
