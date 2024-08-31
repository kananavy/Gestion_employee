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

namespace EmployeeManagementSystem.Resources
{
    public partial class RegisterForm : Form
    {
        private Timer _timer;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KANANAVY\DOCUMENTS\EMPLOYEEE.MDF;Integrated Security=True;Connect Timeout=30");

        public RegisterForm()
        {
            InitializeComponent();
            InitialiserTimer();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signup_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (signup_username.Text == ""
               || signup_password.Text == "")
            {
                label3.Visible = true;
                label7.Visible = true;
               // return;
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        // TO CHECK IF THE USER IS EXISTING ALREADY
                        string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @username";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                
                                label1.Visible = true;
                                label7.Visible = false;
                                label3.Visible = false;
                                //return;
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO users " +
                                    "(username, password, image, date_register) " +
                                "VALUES(@username, @password, @image, @dateReg)";

                                string path = Path.Combine(@"C:\Users\kananavy\Images\Employee-Management-System-in-CSharp-main\Employee-Management-System-in-CSharp-main\EmployeeManagementSystem\EmployeeManagementSystem\Directory\"
                                 + signup_username.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(addEmployee_picture.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                  
                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
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

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showPass.Checked ? '\0' : '*';

        }

        private void signup_btn_MouseEnter(object sender, EventArgs e)
        {
            signup_btn.ForeColor = Color.Black;
        }

        private void signup_btn_MouseLeave(object sender, EventArgs e)
        {
            signup_btn.ForeColor = Color.Black;

        }

        private void signup_username_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label3.Visible = false; 
            label1.Focus();
        }

        private void signup_password_Click(object sender, EventArgs e)
        {
            label7.Visible = false;

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void signup_username_TextChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            label3.Visible = false;
            label1.Focus();
        }

        private void signup_password_TextChanged(object sender, EventArgs e)
        {
            label7.Visible = false;

        }

        private void RegisterForm_Load(object sender, EventArgs e)
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

        private void signup_loginBtn_MouseEnter(object sender, EventArgs e)
        {
            signup_loginBtn.ForeColor = Color.Gold;
        }

        private void signup_loginBtn_MouseLeave(object sender, EventArgs e)
        {
            signup_loginBtn.ForeColor = Color.Gold;
        }

        private void addEmployee_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addEmployee_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
