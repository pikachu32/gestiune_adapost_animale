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
    public partial class AnimalsForm : Form
    {
        BindingSource animalsBindingSource = new BindingSource();
        BindingSource employeeBindingSource = new BindingSource();
        BindingSource vetBindingSource = new BindingSource();
        AnimalsDAO animalsDAO= new AnimalsDAO();
        EmployeeDAO employeeDAO= new EmployeeDAO();
        VetVisitsDAO vetVisitsDAO= new VetVisitsDAO();
        public AnimalsForm()
        {
            InitializeComponent();
        }

        private void AnimalsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            animalsBindingSource.DataSource = animalsDAO.GetAllAnimals();
            dataGridView1.DataSource = animalsBindingSource;
        }

        private void bt_load_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            animalsBindingSource.DataSource = animalsDAO.GetAllAnimals();
            dataGridView1.DataSource = animalsBindingSource;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (cb_ID.Items.Count > 0)
            {
                int selectedAnimalId = int.Parse(cb_ID.Text);
                animalsDAO.DeleteAnimal(selectedAnimalId);
                animalsBindingSource.DataSource = animalsDAO.GetAllAnimals();
                dataGridView1.DataSource = animalsBindingSource;
            }
        }
        private void cb_ID_Click(object sender, EventArgs e)
        {
            animalsBindingSource.DataSource = animalsDAO.GetAllAnimals();
            List<Animal> animalsList = animalsBindingSource.DataSource as List<Animal>;
            List<int> animalsIds = animalsList.Select(animal => animal.ID).ToList();

            cb_ID.DataSource = animalsIds;
            cb_ID.DisplayMember = "Tostring";
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            AnimalVetVisit newAnimal = new AnimalVetVisit
            {
                Name_Animal = tb_name_2.Text,
                Species = tb_species.Text,
                Age = int.TryParse(tb_age.Text, out int age) ? age : 0,
                Sex =cb_sex.Text,
                State=tb_status.Text,
                ID_Employee = int.Parse(cb_emp_id.Text),
                Name_Vet=cb_vet.Text,
                //Date=DateTime.Parse(dt_date.Text)
            };
            DateTime.TryParse(dt_date.Text, out DateTime date);
            newAnimal.Date = date;

            animalsDAO.AddAnimal(newAnimal, cb_vet.Text);

            animalsBindingSource.DataSource = animalsDAO.GetAllAnimals();
            dataGridView1.DataSource = animalsBindingSource;
        }
        private void cb_emp_id_Click(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource = employeeDAO.GetAllEmployees();
            List<Employee> employeeList = employeeBindingSource.DataSource as List<Employee>;
            List<int> employeeIds = employeeList.Select(employee => employee.ID).ToList();

            cb_emp_id.DataSource = employeeIds;
            cb_emp_id.DisplayMember = "Tostring";
        }
        private void cb_vet_Click(object sender, EventArgs e)
        {
            vetBindingSource.DataSource = vetVisitsDAO.GetAllVetNames();
            List<String> vets = vetBindingSource.DataSource as List<String>;

            cb_vet.DataSource = vets;
            cb_vet.DisplayMember = "Tostring";
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            Animal newAnimal = new Animal
            {
                ID = int.Parse(cb_ID.Text),
                Name = tb_name_2.Text,
                Species = tb_species.Text,
                Age = int.Parse(tb_age.Text),
                Sex =cb_sex.Text,
                State=tb_status.Text,
                ID_Employee = int.Parse(cb_emp_id.Text)
            };
            animalsDAO.EditAnimal(newAnimal);

            animalsBindingSource.DataSource = animalsDAO.GetAllAnimals();
            dataGridView1.DataSource = animalsBindingSource;
        }
    }
}
