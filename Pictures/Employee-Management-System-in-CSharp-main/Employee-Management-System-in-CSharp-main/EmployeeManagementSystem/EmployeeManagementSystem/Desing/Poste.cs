using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Emit;

namespace EmployeeManagementSystem
{
    public partial class Poste : UserControl

    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KANANAVY\DOCUMENTS\EMPLOYEEE.MDF;Integrated Security=True;Connect Timeout=30");
        public Poste()
        {
            InitializeComponent();
            displayDEP();
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
            displayDEP();

        }
        public void displayEmployeeData()
        {
            PosteData ed = new PosteData();
            List<PosteData> listData = ed.PosteListData("insert_date");

            dataGridView1.DataSource = listData;
        }

        // DISPLAY DEPARTEMENT
        public void displayDEP()
        {
            string query = "SELECT depart_name FROM departement";
            DisplayData(query, addEmployee_departement);
        }

        public void DisplayData(string query, ComboBox comboBox)
        {
            comboBox.Items.Clear();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string item = reader[0].ToString();
                            if (!comboBox.Items.Contains(item))
                            {
                                comboBox.Items.Add(item);
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

        // BUTTOM ADD
        private void addEmployee_addBtn_Click(object sender, EventArgs e)
        {
            if (AddPoste_name.Text == ""
               || addEmployee_departement.Text == "")
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

                        string selectPosteName = "SELECT COUNT(id) FROM poste WHERE poste_name = @poste_name";


                        using (SqlCommand selectPoste = new SqlCommand(selectPosteName, connect))
                        {
                            selectPoste.Parameters.AddWithValue("@poste_name", AddPoste_name.Text.Trim());
                            int count = (int)selectPoste.ExecuteScalar();

                            if (count >= 1)
                            {
                                label7.Visible = true;

                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO poste " +
                                    "(poste_name, liste_dep, insert_date) " +
                                "VALUES(@poste_name, @liste_dep, @insert_date)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@poste_name", AddPoste_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@liste_dep", addEmployee_departement.Text.Trim());
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
        private void addEmployee_updateBtn_Click_1(object sender, EventArgs e)
        {
            if (AddPoste_name.Text == ""
             || addEmployee_departement.Text == "")
            {
                Faux.Visible = true;
                Vrais.Visible = false;
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "Poste Name: " + AddPoste_name.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE poste SET poste_name = @poste_name" +
                            ", liste_dep = @liste_dep, update_date = @update_date " +
                            "WHERE poste_name = @poste_name";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@poste_name", AddPoste_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@liste_dep", addEmployee_departement.Text.Trim());
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
        private void addEmployee_deleteBtn_Click_1(object sender, EventArgs e)
        {
            if (AddPoste_name.Text == ""
              || addEmployee_departement.Text == "")


            {
                Faux.Visible = true;
                Vrais.Visible = false;
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                    "Poste Name: " + AddPoste_name.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "DELETE FROM poste WHERE poste_name = @poste_name";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@delete_date", today);
                            cmd.Parameters.AddWithValue("@poste_name", AddPoste_name.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();
                            Vrais.Visible = true;
                            Faux.Visible = false;



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
        private void clearFieldss_Click_1(object sender, EventArgs e)
        {
            clearFields();
        }
        public void clearFields()
        {
            AddPoste_name.Text = "";
            addEmployee_departement.Text = "";

        }

        // DISPLAY DATA GRID VIEW
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addEmployee_departement.Text = row.Cells[0].Value.ToString();
                AddPoste_name.Text = row.Cells[1].Value.ToString();

            }
        }

        // SETTING
        private void AddPoste_name_Click(object sender, EventArgs e)
        {
            Faux.Visible = false;
            label7.Visible = false;
            Vrais.Visible = false;

        }
    }
}
