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
    public partial class TasksForm : Form
    {
        BindingSource tasksBindingSource = new BindingSource();
        BindingSource employeeBindingSource = new BindingSource();
        TasksDAO tasksDAO = new TasksDAO();
        EmployeeDAO employeeDAO = new EmployeeDAO();
        public TasksForm()
        {
            InitializeComponent();
        }

        private void TasksForm_Load(object sender, EventArgs e)
        {
            bt_load_Click(sender, e);
        }

        private void bt_load_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            tasksBindingSource.DataSource = tasksDAO.GetAllTasks();
            dataGridView1.DataSource = tasksBindingSource;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (cb_ID.Items.Count > 0)
            {
                int selectedTaskId = int.Parse(cb_ID.Text);
                tasksDAO.DeleteTask(selectedTaskId);

                tasksBindingSource.DataSource = tasksDAO.GetAllTasks();
                dataGridView1.DataSource = tasksBindingSource;
            }
        }
        private void cb_ID_Click(object sender, EventArgs e)
        {
            List<Task> taskList = tasksBindingSource.DataSource as List<Task>;
            List<int> tasksIds = taskList.Select(task => task.ID).ToList();

            cb_ID.DataSource = tasksIds;
            cb_ID.DisplayMember = "Tostring";
        }
        private void cb_emp_Click(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource = employeeDAO.GetAllEmployees();
            List<Employee> employeeList = employeeBindingSource.DataSource as List<Employee>;
            List<String> employeeNames = employeeList.Select(employee => employee.Name).ToList();

            cb_emp.DataSource = employeeNames;
            cb_emp.DisplayMember = "Tostring";
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Task newTask = new Task
            {
                Description=tb_description.Text,
                Assignment_Date=DateTime.Now,
                Deadline_Date=DateTime.Parse(dt_deadline.Text)                
            };
            tasksDAO.AddTask(newTask, cb_emp.Text);

            tasksBindingSource.DataSource = tasksDAO.GetAllTasks();
            dataGridView1.DataSource = tasksBindingSource;
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            Task newTask = new Task
            {
                ID = int.Parse(cb_ID.Text),
                Description = tb_description.Text,
                Deadline_Date=DateTime.Parse(dt_deadline.Text)
            };
            tasksDAO.EditTask(newTask);

            tasksBindingSource.DataSource = tasksDAO.GetAllTasks();
            dataGridView1.DataSource = tasksBindingSource;
        }
    }
}
