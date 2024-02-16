using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TemaBD
{
    public partial class AdoptersForm : Form
    {
        BindingSource adoptersBindingSource=new BindingSource();
        BindingSource animalsBindingSource =new BindingSource();
        AdoptersDAO adoptersDAO = new AdoptersDAO();
        AnimalsDAO animalsDAO = new AnimalsDAO();   

        public AdoptersForm()
        {
            InitializeComponent();
        }

        private void AdoptersForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            adoptersBindingSource.DataSource = adoptersDAO.GetAllAdoptersAndAnimals();
            dataGridView1.DataSource = adoptersBindingSource;                
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Adopter newAdopter = new Adopter
            {
                Name = tb_name_2.Text,
                Address = tb_address.Text,
                PhoneNumber = tb_phone.Text,
                ID_Animal = int.Parse(cb_animal_id.Text)
            };
            adoptersDAO.AddAdopter(newAdopter);
        }
        private void cb_animal_id_Click(object sender, EventArgs e)
        {
            animalsBindingSource.DataSource = animalsDAO.GetAllAnimals();
            List<Animal> animalsList = animalsBindingSource.DataSource as List<Animal>;
            List<int> animalIds = animalsList.Select(animal => animal.ID).ToList();

            cb_animal_id.DataSource = animalIds;
            cb_animal_id.DisplayMember = "Tostring";
        }
        private void bt_edit_Click(object sender, EventArgs e)
        {
            Adopter newAdopter = new Adopter
            {
                ID = int.Parse(cb_ID.Text),
                Name = tb_name_2.Text,
                Address = tb_address.Text,
                PhoneNumber = tb_phone.Text,
                ID_Animal = int.Parse(cb_animal_id.Text)
            };
            adoptersDAO.EditAdopter(newAdopter);

            adoptersBindingSource.DataSource = adoptersDAO.GetAllAdoptersAndAnimals();
            dataGridView1.DataSource = adoptersBindingSource;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (cb_ID.Items.Count > 0)
            {
                int selectedAdopterId = int.Parse(cb_ID.Text);
                adoptersDAO.DeleteAdopter(selectedAdopterId);
                adoptersBindingSource.DataSource = adoptersDAO.GetAllAdopters();
                dataGridView1.DataSource = adoptersBindingSource;
            }
        }

        private void cb_ID_Click(object sender, EventArgs e)
        {
            adoptersBindingSource.DataSource = adoptersDAO.GetAllAdoptersAndAnimals();
            List<Adopter_Animal> adoptersList = adoptersBindingSource.DataSource as List<Adopter_Animal>;
            List<int> adoptersIds = adoptersList.Select(adopter_animal => adopter_animal.ID).ToList();

            cb_ID.DataSource = adoptersIds;
            cb_ID.DisplayMember = "Tostring";
        }

        private void bt_load_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            adoptersBindingSource.DataSource = adoptersDAO.GetAllAdoptersAndAnimals();
            dataGridView1.DataSource = adoptersBindingSource;
        }
    }
}
