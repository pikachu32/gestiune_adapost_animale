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
    public partial class StaffManagement : Form
    {
        BindingSource employeesBindingSource = new BindingSource();
        EmployeeDAO employeeDAO = new EmployeeDAO();
        public StaffManagement()
        {
            InitializeComponent();
        }

        private void StaffManagement_Load(object sender, EventArgs e)
        {
            employeesBindingSource.DataSource = employeeDAO.GetAllEmployees();
            List<Employee> employeesList = employeesBindingSource.DataSource as List<Employee>;
            List<int> employeeIds = employeesList.Select(employee => employee.ID).ToList();

            cb_ID.DataSource = employeeIds;
            cb_ID.DisplayMember = "ToString";

            bt_load_Click(sender, e);
        }

        private void bt_load_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            employeesBindingSource.DataSource = employeeDAO.GetAllEmployees();
            dataGridView1.DataSource = employeesBindingSource;
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee
            {
                Name = tb_name_2.Text,
                Function = tb_function.Text,
                PhoneNumber = tb_phone.Text,
            };
            employeeDAO.AddEmployee(newEmployee);

            employeesBindingSource.DataSource = employeeDAO.GetAllEmployees();
            dataGridView1.DataSource = employeesBindingSource;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (cb_ID.Items.Count > 0)
            {
                int selectedEmployeeId = int.Parse(cb_ID.Text);
                employeeDAO.DeleteEmployee(selectedEmployeeId);
                employeesBindingSource.DataSource = employeeDAO.GetAllEmployees();
                dataGridView1.DataSource = employeesBindingSource;
            }
        }

        private void cb_ID_Click(object sender, EventArgs e)
        {
            List<Employee> employeesList = employeesBindingSource.DataSource as List<Employee>;
            List<int> employeeIds = employeesList.Select(employee => employee.ID).ToList();

            cb_ID.DataSource = employeeIds;
            cb_ID.DisplayMember = "Tostring";

        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee
            {
                ID = int.Parse(cb_ID.Text),
                Name = tb_name_2.Text,
                Function=tb_function.Text,
                PhoneNumber = tb_phone.Text
            };
            employeeDAO.EditEmployee(newEmployee);

            employeesBindingSource.DataSource = employeeDAO.GetAllEmployees();
            dataGridView1.DataSource = employeesBindingSource;
        }
    }
}
