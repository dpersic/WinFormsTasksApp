using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT (*) From Tasks_Users Where USERNAME='" + textBoxUserName.Text + "' and PASSWORD='" + textBoxUserPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                FormUsers formUsers = new FormUsers();
                formUsers.Show();
              
            }
            else
            {
                MessageBox.Show("Prijava nije uspjela!");
            }
        }
    }
}
