using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
            var total = 0;
            var userId = 0;
            using (DbConnection connection = new SqlConnection(("Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe")))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT COUNT (*) AS TOTAL, ID From Tasks_Users Where USERNAME='" + textBoxUserName.Text + "' and PASSWORD='" + textBoxUserPassword.Text + "' GROUP BY ID";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        total = (int)reader["TOTAL"];
                        userId = (int)reader["ID"];                      
                    }
                }
            }

            if (total == 1)
            {
                this.Hide();
                FormUsers formUsers = new FormUsers(userId);
                formUsers.Show();

            }
            else
            {
                MessageBox.Show("Prijava nije uspjela!");
            }

           /* SqlConnection con = new SqlConnection("Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT (*) AS TOTAL, ID From Tasks_Users Where USERNAME='" + textBoxUserName.Text + "' and PASSWORD='" + textBoxUserPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if ((int)dt.Rows[0][0] == 1)
            {
                this.Hide();
                var userId = (int)(int)dt.Rows[0][1];
                FormUsers formUsers = new FormUsers(userId);
                formUsers.Show();
              
            }
            else
            {
                MessageBox.Show("Prijava nije uspjela!");
            }*/
        }
    }
}
