using DataAccessLayer;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormDeleteUser : Form
    {
        User _user = new User();
        FormUsers _formUser = new FormUsers();

        private UserRepository _userRepository = new UserRepository();

        public FormDeleteUser(User user, FormUsers formUser)
        {
            _user = user;
            _formUser = formUser;

            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            _userRepository.DeleteUser(_user);
            this.Hide();
            _formUser._tableBindingSource.DataSource = _userRepository.GetUsers();
        }
    }
}
