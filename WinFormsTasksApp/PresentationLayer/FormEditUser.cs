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
    public partial class FormEditUser : Form
    {
        User _user = new User();
        FormUsers _formUser;
        private UserRepository _userRepository = new UserRepository();
        public FormEditUser(User user, FormUsers formUser)
        {
            _user = user;
            _formUser = formUser;
            InitializeComponent();
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            lblEditUserID.Text = _user.nId.ToString();
            lblEditUserName.Text = _user.sUsername;
            inptEditName.Text = _user.sName;
            inptEditSurname.Text = _user.sSurname;
            inptEditPassword.Text = _user.sPassword;

        }

        private void btnEditancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            _user.nId = Int32.Parse(lblEditUserID.Text);
            _user.sUsername = lblEditUserName.Text;
            _user.sName = inptEditName.Text;
            _user.sSurname = inptEditSurname.Text;
            _user.sPassword = inptEditPassword.Text;

            _userRepository.UpdateUser(_user);
            this.Hide();
            _formUser._tableBindingSource.DataSource = _userRepository.GetUsers();
        }
    }
}
