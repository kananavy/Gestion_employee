using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    internal class CongeData1
    {
        //public int ID { set; get; } // 0
        public string EmployeeID { set; get; } // 1
        public string Nom { set; get; } // 2
        public string Adresse { set; get; } // 7
        public string Departement { set; get; } // 3
        public string Poste { set; get; } // 4
        public string nature { set; get; } // 5
        public string Motif { set; get; } // 6
        public DateTime Periode_debut { set; get; }
        public DateTime Periode_fin { set; get; }
        public int reliquat { set; get; } // 10
        
  
         


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KANANAVY\DOCUMENTS\EMPLOYEEE.MDF;Integrated Security=True;Connect Timeout=30");
        public List<CongeData1> congeEmployeeListData(string name)

        {
            List<CongeData1> listdata = new List<CongeData1>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM conge WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CongeData1 cd = new CongeData1();
                            cd.EmployeeID = reader["employee_id"].ToString();
                            cd.Nom = reader["full_name"].ToString();
                            cd.Adresse = reader["adresse"].ToString();
                            cd.Departement = reader["departement"].ToString();
                            cd.Poste = reader["position"].ToString();
                            cd.nature = reader["nature_conge"].ToString();
                            cd.Motif = reader["motif"].ToString();
                            cd.Periode_debut = (DateTime)reader["periode_debut"];
                            cd.Periode_fin = (DateTime)reader["periode_fin"];
                            cd.reliquat = (int)reader["reliquat"];

                            listdata.Add(cd);
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
