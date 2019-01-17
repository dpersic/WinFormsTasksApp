using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using DataAccessLayer.Entities;

namespace PresentationLayer
{
    public partial class FormAddUser : Form
    {
        User _user = new User();
        FormUsers _formUsers;
        private UserRepository _userRepository = new UserRepository();

        public FormAddUser(FormUsers formUsers)
        {
            _formUsers = formUsers;
            InitializeComponent();
        }

        private void btnCloseNewUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            _user.sUsername = inptNewUserName.Text;
            _user.sPassword = inptNewPassword.Text;
            _user.sName = inptNewName.Text;
            _user.sSurname = inptNewLastName.Text;
            _userRepository.AddUser(_user);
            this.Hide();
            _formUsers._tableBindingSource.DataSource = _userRepository.GetUsers();
        }
    }
}
