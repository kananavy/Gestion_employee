using EmployeeManagementSystem.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Formulaire
{
    public partial class Biemvenue : Form
    {
        public Biemvenue()
        {
            InitializeComponent();

        }

        private void Biemvenue_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                //label2.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
              Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
           

            }
        }
    }
}
