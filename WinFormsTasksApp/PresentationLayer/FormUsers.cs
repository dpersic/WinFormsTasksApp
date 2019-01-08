﻿using DataAccessLayer;
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
    public partial class FormUsers : Form
    {
        public UserRepository _userRepository = new UserRepository();
        public BindingSource _tableBindingSource = new BindingSource();
        public FormUsers()
        {
            InitializeComponent();
            _tableBindingSource.DataSource = _userRepository.GetUsers();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            dataGridViewUsers.DataSource = _tableBindingSource;

            DataGridViewImageColumn oEditButton = new DataGridViewImageColumn();
            oEditButton.Image = Image.FromFile("C:/Users/Domagoj/Source/Repos/NewRepo/WinFormsTasksApp/update.png");
            oEditButton.Width = 20;
            oEditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewUsers.Columns.Add(oEditButton);

            DataGridViewImageColumn oDeleteButton = new DataGridViewImageColumn();
            oDeleteButton.Image = Image.FromFile("C:/Users/Domagoj/Source/Repos/NewRepo/WinFormsTasksApp/delete.png");
            oDeleteButton.Width = 20;
            oDeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewUsers.Columns.Add(oDeleteButton);

            dataGridViewUsers.AutoGenerateColumns = false;
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUsers.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                var userId = Convert.ToInt32(dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value);
                var userName = dataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                var userPassword = dataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                var userFirstName = dataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                var userLastName = dataGridViewUsers.Rows[e.RowIndex].Cells[4].Value.ToString();

                var user = new User
                {
                    nId = userId,
                    sUsername = userName,
                    sName = userFirstName,
                    sSurname = userLastName,
                    sPassword = userPassword
                };
                FormEditUser formEditUser = new FormEditUser(user, this);
                formEditUser.Show();
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            FormAddUser formAddUser = new FormAddUser(this);
            formAddUser.Show();
        }
    }
}