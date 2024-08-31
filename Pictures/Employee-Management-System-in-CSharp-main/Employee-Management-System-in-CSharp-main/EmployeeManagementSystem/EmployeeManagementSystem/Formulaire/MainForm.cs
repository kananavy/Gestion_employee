using System;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeManagementSystem
{
    public partial class MainForm : Form
    {
        private Timer _timer;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KANANAVY\DOCUMENTS\EMPLOYEEE.MDF;Integrated Security=True;Connect Timeout=30");

        public MainForm()
        {
            InitializeComponent();
            displayUT();
            InitialiserTimer();
            displayIM();
        }

        private void greet_user_Click(object sender, EventArgs e)
        {

        }

        public void displayIM()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT image FROM users";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();


                        addEmployee_picture.ImageLocation = "";
                        while (reader.Read())
                        {
                            string imagePath = reader["image"].ToString();
                             addEmployee_picture.ImageLocation = imagePath;
                           
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        public void displayUT()
        {
            Utilisateur.Text = ""; // Nettoie les éléments avant de les remplir

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT username FROM users";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", Utilisateur.Text.Trim());

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {

                            Utilisateur.Text = reader["username"].ToString();

                            if (!Utilisateur.Text.Contains(Utilisateur.Text))
                            {
                                Utilisateur.Text = reader["username"].ToString();
                            }

                        }


                        reader.Close();
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

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?"
                , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addEmployee1.Visible = false;
            departement1.Visible = false;
            poste1.Visible = false;
            salary1.Visible = false;
            timeOff1.Visible = false;
            dashboard_btn.BackColor = System.Drawing.Color.FromArgb(75, 8, 138);
            addEmployee_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            Departement_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            Poste_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            salary_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            Conge_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
           



            Dashboard dashForm = dashboard1 as Dashboard;

            if (dashForm != null)
            {
                dashForm.RefreshData();
            }

        }

        private void addEmployee_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = true;
            departement1.Visible = false;
            poste1.Visible = false;
            salary1.Visible = false;
            timeOff1.Visible = false; 
            dashboard_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            addEmployee_btn.BackColor = System.Drawing.Color.FromArgb(75, 8, 138);
            Departement_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            Poste_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            salary_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            Conge_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);


            AddEmployee addEmForm = addEmployee1 as AddEmployee;

            if (addEmForm != null)
            {
                addEmForm.RefreshData();
            }

        }

        private void Departement_btn_Click(object sender, EventArgs e)
        {
             dashboard1.Visible = false;
             addEmployee1.Visible = false;
            departement1.Visible = true;
            poste1.Visible = false;
             salary1.Visible = false;
            timeOff1.Visible = false;
            addEmployee_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            dashboard_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            Departement_btn.BackColor = System.Drawing.Color.FromArgb(75, 8, 138);
            Poste_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            salary_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            Conge_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);




            Departement Depart1 = departement1 as Departement;
             if (Depart1 != null)
             {
                 Depart1.RefreshData();

             }
         
            
        }
        private void Poste_btn_Click(object sender, EventArgs e)

        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            departement1.Visible = false;
            poste1.Visible = true;
            salary1.Visible = false;
            timeOff1.Visible = false;
            addEmployee_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            dashboard_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            Departement_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            Poste_btn.BackColor = System.Drawing.Color.FromArgb(75, 8, 138);
            salary_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            Conge_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);


            Poste PosteForm = poste1 as Poste;
            if (PosteForm != null)
            {
                PosteForm.RefreshData();

            }
        }

        private void salary_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            departement1.Visible = false;
            poste1.Visible = false;
            salary1.Visible = true;
            timeOff1.Visible = false;
            addEmployee_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            dashboard_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            Departement_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            Poste_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            salary_btn.BackColor = System.Drawing.Color.FromArgb(75, 8, 138);
            Conge_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);



            Salary salaryForm = salary1 as Salary;

            if (salaryForm != null)
            {
                salaryForm.RefreshData();
            }

        }

        private void Conge_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            departement1.Visible = false;
            poste1.Visible = false;
            salary1.Visible = false;
            timeOff1.Visible = true;
            addEmployee_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            dashboard_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            Departement_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            Poste_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            salary_btn.BackColor = System.Drawing.Color.FromArgb(29, 0, 97);
            Conge_btn.BackColor = System.Drawing.Color.FromArgb(75, 8, 138);

            
            TimeOff conge1Form = timeOff1 as TimeOff;
            if (conge1Form != null)
            {
                conge1Form.RefreshData();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void poste1_Load(object sender, EventArgs e)
        {

        }

        private void departPoste1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }


        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addEmployee1_Load(object sender, EventArgs e)
        {

        }

        private void departement1_Load(object sender, EventArgs e)
        {

        }

        private void salary1_Load(object sender, EventArgs e)
        {

        }

        private void demandeConge1_Load(object sender, EventArgs e)
        {

        }

        private void Utilisateur_Click(object sender, EventArgs e)
        {

        }

        private void InitialiserTimer()
        {
            // Initialisation du timer avec un intervalle de 1 seconde (1000 millisecondes)
            _timer = new Timer();
            _timer.Interval = 1; // Intervalle en millisecondes
            _timer.Tick += MettreAJourHeure; // Associer l'événement Tick à la méthode MettreAJourHeure
            _timer.Start(); // Démarrer le timer
        }

        private void MettreAJourHeure(object sender, EventArgs e)
        {
            // Met à jour le label avec l'heure actuelle
            labelHeure.Text = DateTime.Now.ToString("HH:mm:ss");
            date1.Text = DateTime.Now.ToString("dddd d MMMM yyyy");
        }
    }
}
