using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Addprint : Form
    {
        public Addprint()
        {
            InitializeComponent();
        }

        private void Addprint_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                
            }
            else
            {
                while (progressBar1.Visible)
                {
                    timer1.Stop();
                    Form1 loginForm = new Form1();
                    loginForm.Show();
                    this.Hide();
                }

            }
            
        }
    }
}
