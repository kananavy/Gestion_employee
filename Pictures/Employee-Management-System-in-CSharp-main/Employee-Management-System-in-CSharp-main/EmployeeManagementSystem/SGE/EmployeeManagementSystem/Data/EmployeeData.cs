using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    class EmployeeData
    {

        public string EmployeeID { set; get; } // 0
        public string Nom { set; get; } // 1
        public string Genre { set; get; } // 2
        public string Contact { set; get; } // 3
        public string Adresse { set; get; } // 4
        public string CIN { set; get; } // 5
        public DateTime Date_Naissace { set; get; } // 6
        public string Lieu_Naissance { set; get; } // 7
        public string Nationalité { set; get; } // 8
        public string Diplôme { set; get; } // 9
        public string Departement { set; get; } // 10
        public string Poste { set; get; } // 11
        public string Grade { set; get; } // 12
        public string Numero_compte { set; get; } // 13
        public string Code_bancaire { set; get; } // 14
        public string Agence { set; get; } // 15
        public string Image { set; get; } // 16
        public int Salaire_Ar { set; get; } // 17
        public DateTime Date_de_recrutement { set; get; } // 18
        public string Status { set; get; } // 19
    


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KANANAVY\DOCUMENTS\EMPLOYEEE.MDF;Integrated Security=True;Connect Timeout=30");


        public List<EmployeeData> employeeListData(string Name)
        {
            List<EmployeeData> listdata = new List<EmployeeData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM employees WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            EmployeeData ed = new EmployeeData();
                           // ed.ID = (int)reader["id"];
                            ed.EmployeeID = reader["employee_id"].ToString();
                            ed.Nom = reader["full_name"].ToString();
                            ed.Genre = reader["gender"].ToString();
                            ed.Adresse = reader["adresse"].ToString();
                            ed.Contact = reader["contact_number"].ToString();                  
                            ed.CIN = reader["cin"].ToString();
                            ed.Date_Naissace = (DateTime)reader["birth_day"];
                            ed.Lieu_Naissance = reader["birth_place"].ToString();
                            ed.Nationalité = reader["nationality"].ToString();
                            ed.Diplôme = reader["diploma"].ToString();
                            ed.Departement = reader["departement"].ToString();
                            ed.Poste = reader["position"].ToString();
                            ed.Grade = reader["grade"].ToString();
                            ed.Numero_compte = reader["number_count"].ToString();
                            ed.Code_bancaire = reader["code_banking"].ToString();
                            ed.Agence = reader["agency"].ToString();
                            ed.Image = reader["image"].ToString();
                            ed.Salaire_Ar = (int)reader["salary"];
                            ed.Date_de_recrutement = (DateTime)reader["date_recrute"];
                            ed.Status = reader["status"].ToString();
                       
                           


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

        public List<EmployeeData> salaryEmployeeListData()
        {
            List<EmployeeData> listdata = new List<EmployeeData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM employees WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            EmployeeData ed = new EmployeeData();
                            ed.EmployeeID = reader["employee_id"].ToString();
                            ed.Nom = reader["full_name"].ToString();
                            ed.Departement = reader["departement"].ToString();
                            ed.Poste = reader["position"].ToString();
                            ed.Salaire_Ar = (int)reader["salary"];

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
        public List<Depart> DepartementListData()
        {
            List<Depart> listdata = new List<Depart>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM departement WHERE  insert_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Depart ed = new Depart();
                           // ed.ID = (int)reader["id"];
                          //  ed.DepartementID = reader["depart_id"].ToString();
                            ed.Nom_Departement = reader["depart_name"].ToString();
                            ed.Tache_Departement = reader["tache_depart"].ToString();

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
