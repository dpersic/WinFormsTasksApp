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
    public partial class OwnerTasks : Form
    {
        private OwnerTaskRepository _tasksRepo = new OwnerTaskRepository();
        private BindingSource _tasksBindingSource = new BindingSource();

        public OwnerTasks(int idOwner)
        {
            InitializeComponent();
            //_tasksBindingSource.DataSource = _tasksRepo.GetOwnerTasks(idOwner);
            _tasksBindingSource.DataSource = _tasksRepo.GetAllName();
        }

        private void OwnerTasks_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = _tasksBindingSource;
        }
    }
}
