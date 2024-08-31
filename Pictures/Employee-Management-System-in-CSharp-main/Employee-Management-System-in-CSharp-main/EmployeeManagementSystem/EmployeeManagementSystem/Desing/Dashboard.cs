using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Dashboard : UserControl
    {
        private SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KANANAVY\DOCUMENTS\EMPLOYEEE.MDF;Integrated Security=True;Connect Timeout=30");
        private Timer refreshTimer; // Déclaration du Timer

        public Dashboard()
        {
            InitializeComponent();

            // Initialisation et configuration du Timer
            refreshTimer = new Timer();
            refreshTimer.Interval = 5000; // 5000 millisecondes = 5 secondes
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();

            // Initialisation des affichages
            displayTE();
            displayAE();
            displayIE();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            displayTE();
            displayAE();
            displayIE();
        }

        // DISPLAY EMPLOYE TOTAL
        public void displayTE()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT(id) FROM employees WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_TE.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        // DISPLAY EMPLOYE ACTIVE
        public void displayAE()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT(id) FROM employees WHERE status = @status AND delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_AE.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        // DISPLAY EMPLOYE INACTIVE
        public void displayIE()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT(id) FROM employees WHERE status = @status AND delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Inactive");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_IE.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        // LOAD EMPLOYEE DATA
        public void LoadEmployeeData(string employeeID)
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string query = "SELECT * FROM employees WHERE employee_id = @employeeID";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@employeeID", employeeID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Display employee information in the controls
                            lblEmployeeID.Text = reader["employee_id"].ToString();
                            lblFullName.Text = reader["full_name"].ToString();
                            lblGender.Text = reader["gender"].ToString();
                            lblContactNumber.Text = reader["contact_number"].ToString();
                            lblAdresse.Text = reader["adresse"].ToString();
                            lblCIN.Text = reader["cin"].ToString();
                            lblBirthDay.Text = reader["birth_day"].ToString();
                            lblBirthPlace.Text = reader["birth_place"].ToString();
                            lblNationality.Text = reader["nationality"].ToString();
                            lblDiploma.Text = reader["diploma"].ToString();
                            lblDepartement.Text = reader["departement"].ToString();
                            lblPosition.Text = reader["position"].ToString();
                            lblGrade.Text = reader["grade"].ToString();
                            lblDateRecrute.Text = reader["date_recrute"].ToString();

                            // Load the employee image
                            string imagePath = reader["image"].ToString();
                            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                            {
                                pbEmployeeImage.Image = Image.FromFile(imagePath);
                            }
                            else
                            {
                                pbEmployeeImage.Image = null;
                            }
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        // CLEAR FIELDS
        public void ClearFields()
        {
            lblEmployeeID.Text = "";
            lblFullName.Text = "";
            lblGender.Text = "";
            lblContactNumber.Text = "";
            lblAdresse.Text = "";
            lblCIN.Text = "";
            lblBirthDay.Text = "";
            lblBirthPlace.Text = "";
            lblNationality.Text = "";
            lblDiploma.Text = "";
            lblDepartement.Text = "";
            lblPosition.Text = "";
            lblGrade.Text = "";
            lblDateRecrute.Text = "";
            pbEmployeeImage.Image = null;
        }
    }
}
