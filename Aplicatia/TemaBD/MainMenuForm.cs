using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemaBD
{
    public partial class MainMenuForm : Form
    {
        BindingSource bindingSource = new BindingSource();
        DAO dao= new DAO();
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            bindingSource.DataSource = dao.GetInfo();
            dataGridView1.DataSource = bindingSource;
        }

        private void bt_adopters_Click(object sender, EventArgs e)
        {
            AdoptersForm adoptersForm=new AdoptersForm();
            adoptersForm.Show();
        }

        private void bt_animals_Click(object sender, EventArgs e)
        {
            AnimalsForm animalsForm=new AnimalsForm();
            animalsForm.Show();
        }

        private void bt_staff_Click(object sender, EventArgs e)
        {
            StaffManagement staffForm=new StaffManagement();
            staffForm.Show();
        }

        private void bt_vet_visits_Click(object sender, EventArgs e)
        {
            VetVisitsForm vetVisitsForm =new VetVisitsForm();
            vetVisitsForm.Show();
        }

        private void bt_tasks_Click(object sender, EventArgs e)
        {
            TasksForm tasksForm=new TasksForm();
            tasksForm.Show();
        }
    }
}
