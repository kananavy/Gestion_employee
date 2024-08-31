using EmployeeManagementSystem.Resources;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Form1 : Form
    {
        private Timer _timer;

        SqlConnection connect
            = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KANANAVY\DOCUMENTS\EMPLOYEEE.MDF;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
            InitialiserTimer();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();

          
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            if (login_username.Text == ""
                || login_password.Text == "")
            {
                label1.Visible = true;
                label7.Visible = true;
           

                return;

            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM users WHERE username = @username " +
                            "AND password = @password";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);


                            if (table.Rows.Count >= 1)
                            {
                              

                                MainForm mForm = new MainForm();
                                mForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                label1.Visible = true;
                                label7.Visible = true;
                                return;
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

        private void PictureBox2_Move(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {
            login_username.ForeColor = Color.Black;
            label1.Visible = false;
            label1.Focus();
        }
        private void login_password_TextChanged(object sender, EventArgs e)
        {
            login_password.ForeColor = Color.Black;
           
            label7.Visible = false;
            label7.Focus();
        }

        private void login_username_BorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void login_username_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label1.Focus();
     

        }

        private void login_password_Click(object sender, EventArgs e)
        {
           
         

            label7.Visible = false;
            //label1.Focus();
            
        }

        private void login_btn_MouseEnter(object sender, EventArgs e)
        {
            login_btn.ForeColor = Color.Black;
        }

        private void login_btn_MouseLeave(object sender, EventArgs e)
        {
            login_btn.ForeColor = Color.Black;
        }

        private void login_username_AcceptsTabChanged(object sender, EventArgs e)
        {
           

        }

        private void login_username_TextAlignChanged(object sender, EventArgs e)
        {
           

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void login_username_CursorChanged(object sender, EventArgs e)
        {
            
        }

        private void login_username_MouseEnter(object sender, EventArgs e)
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

        private void login_signupBtn_MouseEnter(object sender, EventArgs e)
        {
            login_signupBtn.ForeColor = Color.Gold;
        }

        private void login_signupBtn_MouseLeave(object sender, EventArgs e)
        {
            login_signupBtn.ForeColor = Color.Gold;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
