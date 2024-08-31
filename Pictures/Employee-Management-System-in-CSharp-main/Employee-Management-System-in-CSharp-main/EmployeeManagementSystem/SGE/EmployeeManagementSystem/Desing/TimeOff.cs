using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class TimeOff : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KANANAVY\DOCUMENTS\EMPLOYEEE.MDF;Integrated Security=True;Connect Timeout=30");

        public TimeOff()
        {
            InitializeComponent();

// ============================================TO DISPLAY THE DATA FROM DATABASE TO YOUR DATA GRID VIEW=================//
            displayEmployeeData();


// ============================================TO DISPLAY THE DATA FROM DATABASE TO YOUR DEPARTEMENT=================//

            displayDEP();
 
 // ============================================TO DISPLAY THE DATA FROM DATABASE TO YOUR DEPARTEMENT=================//

            displayPOST();
            addEmployee_departement.SelectedIndexChanged += addEmployee_departement_SelectedIndexChanged;

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

            displayPOST();
            
        }
        private void addEmployee_departement_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vérifiez si un élément est sélectionné avant d'essayer de l'utiliser
            if (addEmployee_departement.SelectedItem != null)
            {
                // Obtenir le département sélectionné
                string selectedDepartment = addEmployee_departement.SelectedItem.ToString();

                // Charger les postes pour ce département
                LoadPositionsByDepartment(selectedDepartment);
            }

        }
        public void LoadPositionsByDepartment(string departmentName)
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    // Requête pour sélectionner les postes associés au département
                    string selectData = "SELECT poste_name FROM poste WHERE liste_dep = @depart_name";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@depart_name", departmentName);

                        SqlDataReader reader = cmd.ExecuteReader();

                        // Nettoyer les éléments existants avant d'ajouter les nouveaux postes
                        addEmployee_position.Items.Clear();


                        while (reader.Read())
                        {
                            string posteName = reader["poste_name"].ToString();

                            // Ajouter chaque poste associé au département sélectionné
                            if (!addEmployee_position.Items.Contains(posteName))
                            {
                                addEmployee_position.Items.Add(posteName);

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

        public void displayDEP()
        {
            string query = "SELECT depart_name FROM departement";
            DisplayData(query, addEmployee_departement);
        }

        public void displayPOST()
        {
            string query = "SELECT poste_name FROM poste";
            DisplayData(query, addEmployee_position);
        }


        //============================================= ADD TO EMPLOYEE DATA DISPLAY============================//
        public void displayEmployeeData()
        {
            CongeData1 ed = new CongeData1();
            List<CongeData1> listData = ed.congeEmployeeListData("insert_date");

            dataGridView1.DataSource = listData;
        }

//============================================= BUTTOM_CLICK ADD============================//
        private void addEmployee_addBtn_Click_1(object sender, EventArgs e)
        {
            if (addEmployee_id.Text == ""
                           || addEmployee_fullName.Text == ""
                           || addEmployee_departement.Text == ""
                           || addEmployee_position.Text == ""
                           || addEmployee_nature.Text == ""
                           || addEmployee_motifs.Text == ""
                           || addEmployee_adresse.Text == ""
                           || addEmployee_reliquat.Text == "")
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
                pictureBox8.Visible = false;
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmID = "SELECT COUNT(*) FROM conge WHERE employee_id = @emID AND delete_date IS NULL";

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            checkEm.Parameters.AddWithValue("@emID", addEmployee_id.Text.Trim());
                            int count = (int)checkEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                pictureBox7.Visible = false;
                                pictureBox6.Visible = false;
                                pictureBox8.Visible = true;
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO conge " +
                                    "(employee_id, full_name, departement, position" +
                                    ", nature_conge, motif, adresse, reliquat,insert_date, periode_debut,periode_fin) " +
                                    "VALUES(@employeeID, @fullName, @departement, @position" +
                                    ", @nature_conge, @motif, @adresse, @reliquat, @insert_date, @periode_debut, @periode_fin)";


                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeID", addEmployee_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullName", addEmployee_fullName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@departement", addEmployee_departement.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", addEmployee_position.Text.Trim());
                                    cmd.Parameters.AddWithValue("@nature_conge", addEmployee_nature.Text.Trim());
                                    cmd.Parameters.AddWithValue("@motif", addEmployee_motifs.Text.Trim());
                                    cmd.Parameters.AddWithValue("@adresse", addEmployee_adresse.Text.Trim());
                                    cmd.Parameters.AddWithValue("@periode_debut", DateTime.Parse(addEmployee_debut.Text.Trim()));
                                    cmd.Parameters.AddWithValue("@periode_fin", DateTime.Parse(addEmployee_fin.Text.Trim()));
                                    cmd.Parameters.AddWithValue("@reliquat", addEmployee_reliquat.Text.Trim());
                                    cmd.Parameters.AddWithValue("@insert_date", today);

                                   // Méthode à définir pour obtenir l'ID de l'employé sélectionné
                                string employeeId = addEmployee_id.Text.Trim(); 
                                    if (string.IsNullOrEmpty(employeeId))
                                    {
                                        MessageBox.Show("Please select an employee.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }

                                    // Mettre à jour le statut de l'employé en fonction de la demande de congés
                                    UpdateEmployeeStatus(employeeId, false); // Passer à `false` pour inactif

                                
                                    cmd.ExecuteNonQuery();

                                        displayEmployeeData();

                                        pictureBox6.Visible = true;
                                        pictureBox7.Visible = false;
                                        pictureBox8.Visible = false;

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


//============================================= UPDATE STATUS ACTIF TO INACTIF ============================//

        private void UpdateEmployeeStatus(string employeeId, bool isActive)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KANANAVY\DOCUMENTS\EMPLOYEEE.MDF;Integrated Security=True;Connect Timeout=30"))
            {
                if (connection.State == ConnectionState.Closed)
                {
                    try
                    {
                        connection.Open();
                        string updateStatusQuery = "UPDATE employees SET status = @status WHERE employee_id = @employeeId";

                        using (SqlCommand cmd = new SqlCommand(updateStatusQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@status", isActive ? "Active" : "Inactive");
                            cmd.Parameters.AddWithValue("@employeeId", employeeId);

                            cmd.ExecuteNonQuery();
                            displayEmployeeData();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }


        //============================================= UPDATE STATUS INACTIF TO ACTIF============================//

        private void UpdateEmployeeStatus3(string employeeId, bool isActive)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KANANAVY\DOCUMENTS\EMPLOYEEE.MDF;Integrated Security=True;Connect Timeout=30"))
            {
                if (connection.State == ConnectionState.Closed)
                {
                    try
                    {
                        connection.Open();
                        string updateStatusQuery = "UPDATE employees SET status = @status WHERE employee_id = @employeeId";

                        using (SqlCommand cmd = new SqlCommand(updateStatusQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@status", isActive ? "Active" : "Inactive");
                            cmd.Parameters.AddWithValue("@employeeId", employeeId);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }



        //====================================POST GRIDVIEW============================================//
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addEmployee_id.Text = row.Cells[0].Value.ToString();
                addEmployee_fullName.Text = row.Cells[1].Value.ToString();
                addEmployee_adresse.Text = row.Cells[2].Value.ToString();
                addEmployee_departement.Text = row.Cells[3].Value.ToString();
                addEmployee_position.Text = row.Cells[4].Value.ToString();
                addEmployee_nature.Text = row.Cells[5].Value.ToString();
                addEmployee_motifs.Text = row.Cells[6].Value.ToString();
                addEmployee_debut.Text = row.Cells[7].Value.ToString();
                addEmployee_fin.Text = row.Cells[8].Value.ToString();
                addEmployee_reliquat.Text = row.Cells[9].Value.ToString();
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;


            }
        }

//============================================= BUTTOM_CLICK CLEAR============================//

        public void clearFields()
        {
            addEmployee_id.Text = "";
            addEmployee_fullName.Text = "";
            addEmployee_departement.SelectedIndex = -1;
            addEmployee_position.SelectedIndex = -1;
            addEmployee_nature.SelectedIndex = -1;
            addEmployee_motifs.Text = "";
            addEmployee_adresse.Text = "";
            addEmployee_debut.Text = "";
            addEmployee_fin.Text = "";
            addEmployee_reliquat.Text = "";

        }

        //============================================= BUTTOM_CLICK DELETE============================//


        private void addEmployee_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addEmployee_id.Text == ""
                || addEmployee_fullName.Text == ""
                || addEmployee_departement.Text == ""
                || addEmployee_position.Text == ""
                || addEmployee_nature.Text == ""
                || addEmployee_motifs.Text == ""
                || addEmployee_adresse.Text == ""
                || addEmployee_reliquat.Text == "")
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
                pictureBox8.Visible = false;
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                    "Employee ID: " + addEmployee_id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        // Supprimer le congé de la base de données
                        string deleteData = "DELETE FROM conge WHERE employee_id = @employeeID";
                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@employeeID", addEmployee_id.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }

                        string employeeId = addEmployee_id.Text.Trim(); // Obtenez l'ID de l'employé sélectionné
                        if (string.IsNullOrEmpty(employeeId))
                        {
                            MessageBox.Show("Please select an employee.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        // Mettre à jour le statut de l'employé en fonction de la suppression du congé
                        UpdateEmployeeStatus3(employeeId, true); // Passer à `true` pour actif

                        pictureBox6.Visible = true;
                        pictureBox7.Visible = false;
                        pictureBox8.Visible = false;

                        displayEmployeeData();
                        clearFields();
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
                else
                {
                    MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
     

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
        }

        private void addEmployee_id_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
        }

        private void TimeOff_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }





    }
}
