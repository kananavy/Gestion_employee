using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    class SalaryData
    {

        public string EmployeeID { set; get; } // 0
        public string Nom { set; get; } // 1
        public string Departement { set; get; } // 4
        public string Poste { set; get; } // 5
        public string Numero_compte { set; get; } // 5
        public string Code_Bancaire { set; get; } // 5
        public string Agence { set; get; } // 5
        public int Salaire { set; get; } // 6

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KANANAVY\DOCUMENTS\EMPLOYEEE.MDF;Integrated Security=True;Connect Timeout=30");

        public List<SalaryData> salaryEmployeeListData()
        {
            List<SalaryData> listdata = new List<SalaryData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM employees WHERE status = 'Active' " +
                        "AND delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            SalaryData sd = new SalaryData();
                            sd.EmployeeID = reader["employee_id"].ToString();
                            sd.Nom = reader["full_name"].ToString();
                            sd.Departement = reader["departement"].ToString();
                            sd.Poste = reader["position"].ToString();
                            sd.Numero_compte = reader["number_count"].ToString();
                            sd.Code_Bancaire = reader["code_banking"].ToString();
                            sd.Agence = reader["agency"].ToString();
                            sd.Salaire = (int)reader["salary"];

                            listdata.Add(sd);
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
