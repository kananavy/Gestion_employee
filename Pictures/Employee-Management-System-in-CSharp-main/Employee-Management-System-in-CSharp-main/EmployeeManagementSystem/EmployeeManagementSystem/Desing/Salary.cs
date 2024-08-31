using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Salary : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KANANAVY\DOCUMENTS\EMPLOYEEE.MDF;Integrated Security=True;Connect Timeout=30");

        public Salary()
        {
            InitializeComponent();

            displayEmployees();
            disableFields();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            displayEmployees();
            disableFields();
        }

        public void disableFields()
        {
            salary_employeeID.Enabled = false;
            salary_name.Enabled = false;
            salary_departement.Enabled = false;
            salary_position.Enabled = false;

        }

        public void displayEmployees()
        {
            SalaryData ed = new SalaryData();
            List<SalaryData> listData = ed.salaryEmployeeListData();

            dataGridView1.DataSource = listData;
        }

        private void salary_updateBtn_Click(object sender, EventArgs e)
        {
            if (salary_employeeID.Text == ""
                || salary_name.Text == ""
                || salary_departement.Text == ""
                || salary_position.Text == ""
                || salary_numCompte.Text == ""
                || salary_code.Text == ""
                || salary_agence.Text == ""
                || salary_salary.Text == "")
            {
                pictureBox6.Visible = false;
                label8.Visible = true;
            }
            else
            {

                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employees SET  number_count = @number_count, code_banking = @code_banking" +
                                            ", agency = @agency, salary = @salary" +
                                            ", update_date = @updateData WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@number_count", salary_numCompte.Text.Trim());
                            cmd.Parameters.AddWithValue("@code_banking", salary_code.Text.Trim());
                            cmd.Parameters.AddWithValue("@agency", salary_agence.Text.Trim());
                            cmd.Parameters.AddWithValue("@salary", salary_salary.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateData", today);
                            cmd.Parameters.AddWithValue("@employeeID", salary_employeeID.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployees();


                            clearFields();
                            pictureBox6.Visible = true;
                            pictureBox1.Visible = false;
                            label8.Visible = false;


                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }


            }
        }

        public void clearFields()
        {
            salary_employeeID.Text = "";
            salary_name.Text = "";
            salary_departement.Text = "";
            salary_position.Text = "";
            salary_numCompte.Text = "";
            salary_code.Text = "";
            salary_agence.Text = "";
            salary_salary.Text = "";
            label8.Visible = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                salary_employeeID.Text = row.Cells[0].Value.ToString();
                salary_name.Text = row.Cells[1].Value.ToString();
                salary_departement.Text = row.Cells[2].Value.ToString(); ;
                salary_position.Text = row.Cells[3].Value.ToString();
                salary_numCompte.Text = row.Cells[4].Value.ToString();
                salary_code.Text = row.Cells[5].Value.ToString();
                salary_agence.Text = row.Cells[6].Value.ToString();
                salary_salary.Text = row.Cells[7].Value.ToString();
            }
        }

        private void salary_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void salary_position_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox6.Visible = false;

        }

        private void salary_salary_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox6.Visible = false;
        }

        private void salary_salary_TextChanged(object sender, EventArgs e)
        {
            label790.Visible = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            p1.Visible = radioButton1.Checked;
            p2.Visible = false;
            p1.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            p2.Visible = radioButton2.Checked;
            p1.Visible = false;
            p2.Visible = true;
        }
    }
}
