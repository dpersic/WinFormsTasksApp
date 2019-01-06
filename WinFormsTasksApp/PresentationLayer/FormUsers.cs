using DataAccessLayer;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
