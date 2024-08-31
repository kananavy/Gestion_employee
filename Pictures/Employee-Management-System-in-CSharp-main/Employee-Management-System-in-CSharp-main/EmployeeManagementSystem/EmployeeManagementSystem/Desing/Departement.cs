using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Departement : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KANANAVY\DOCUMENTS\EMPLOYEEE.MDF;Integrated Security=True;Connect Timeout=30");
        public Departement()
        {
            InitializeComponent();

            displayEmployeeData();
        }
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayEmployeeData();


        }
        public void displayEmployeeData()
        {
            Depart ed = new Depart();
            List<Depart> listData = ed.DepartementListData("insert_date");

            dataGridView1.DataSource = listData;
        }
        // BUTTOM ADD
        private void addEmployee_addBtn_Click(object sender, EventArgs e)
        {
            if (AddDepartemt_name.Text == ""
               || AddDepartemt_tache.Text == "")

            {
                Faux.Visible = true;
                Vrais.Visible = false;
            }

            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();


                        string selectDepartName = "SELECT COUNT(id) FROM departement WHERE depart_name = @depart_name";


                        using (SqlCommand selectDepartement = new SqlCommand(selectDepartName, connect))
                        {
                            selectDepartement.Parameters.AddWithValue("@depart_name", AddDepartemt_name.Text.Trim());
                            int count = (int)selectDepartement.ExecuteScalar();

                            if (count >= 1)
                            {
                                label7.Visible = true;


                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO departement " +
                                    "(depart_name, depart_tache, insert_date) " +
                                    "VALUES(@depart_name, @depart_tache, @insert_date)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@depart_name", AddDepartemt_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@depart_tache", AddDepartemt_tache.Text.Trim());
                                    cmd.Parameters.AddWithValue("@insert_date", today);

                                    cmd.ExecuteNonQuery();

                                    displayEmployeeData();

                                    Vrais.Visible = true;
                                    Faux.Visible = false;

                                    clearFields();




                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        // BUTTOM UPDATE
        private void addEmployee_updateBtn_Click(object sender, EventArgs e)
        {
            if (AddDepartemt_name.Text == ""
             || AddDepartemt_tache.Text == "")
            {
                Faux.Visible = true;
                Vrais.Visible = false;
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                   "Departemenet Name: " + AddDepartemt_name.Text.Trim() + "?", "Confirmation Message"
                   , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE departement SET depart_name = @depart_name" +
                            ", depart_tache = @depart_tache, update_date = @update_date " +
                            "WHERE depart_name = @depart_name ";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@depart_name", AddDepartemt_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@depart_tache", AddDepartemt_tache.Text.Trim());
                            cmd.Parameters.AddWithValue("@update_date", today);

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            Vrais.Visible = true;

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        // BUTTOM DELETE
        private void addEmployee_deleteBtn_Click(object sender, EventArgs e)
        {
            if (AddDepartemt_name.Text == ""
               || AddDepartemt_tache.Text == "")


            {
                Faux.Visible = true;
                Vrais.Visible = false;

            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                       "Departement Name: " + AddDepartemt_name.Text.Trim() + "?", "Confirmation Message"
                       , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        // string updateData = "UPDATE departement SET delete_date = @delete_date " +
                        //  "WHERE depart_name = @depart_name";
                        string updateData = "DELETE FROM departement WHERE depart_name = @depart_name";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@delete_date", today);
                            cmd.Parameters.AddWithValue("@depart_name", AddDepartemt_name.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            Vrais.Visible = true;

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // BUTTOM CLEAR
        private void clearFieldss_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void clearFields()
        {
            AddDepartemt_name.Text = "";
            AddDepartemt_tache.Text = "";

        }

        // DATA GRID VIEW
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                AddDepartemt_name.Text = row.Cells[0].Value.ToString();
                AddDepartemt_tache.Text = row.Cells[1].Value.ToString();

            }
        }

        // SETTING
        private void AddDepartemt_name_Click(object sender, EventArgs e)
        {

            Faux.Visible = false;
            label7.Visible = false;
            Vrais.Visible = false;

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
