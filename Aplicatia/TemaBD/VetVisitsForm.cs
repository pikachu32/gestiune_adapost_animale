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
    public partial class VetVisitsForm : Form
    {
        BindingSource visitsBindingSource = new BindingSource();
        BindingSource animalsBindingSource = new BindingSource();
        BindingSource vetBindingSource = new BindingSource();
        VetVisitsDAO vetVisitsDAO = new VetVisitsDAO();
        AnimalsDAO animalsDAO = new AnimalsDAO();
        public VetVisitsForm()
        {
            InitializeComponent();
        }

        private void bt_load_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            visitsBindingSource.DataSource = vetVisitsDAO.GetAllAnimalsAndVetVisits();
            dataGridView1.DataSource = visitsBindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VetVisitsForm_Load(object sender, EventArgs e)
        {
            bt_load_Click(sender, e);
        }
        private void cb_ID_Click(object sender, EventArgs e)
        {
            visitsBindingSource.DataSource = vetVisitsDAO.GetAllAnimalsAndVetVisits();
            List<AnimalVetVisit> visitsList = visitsBindingSource.DataSource as List<AnimalVetVisit>;
            List<Int32> visitIds = visitsList.Select(animalvetvisit => animalvetvisit.ID_Visit).ToList();

            cb_ID.DataSource = visitIds;
            cb_ID.DisplayMember = "Tostring";
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (cb_ID.Items.Count > 0)
            {
                int selectedVisitId = int.Parse(cb_ID.Text);
                vetVisitsDAO.DeleteVisit(selectedVisitId);

                visitsBindingSource.DataSource = vetVisitsDAO.GetAllAnimalsAndVetVisits();
                dataGridView1.DataSource = visitsBindingSource;
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            AnimalVetVisit newvisit = new AnimalVetVisit
            {
                Name_Animal=cb_animal.Text,
                Name_Vet=cb_vet.Text,
                Date=DateTime.Parse(dt_date.Text),
                Diagnostic=tb_diagnostic.Text,
                Treatment=tb_tratament.Text
            };
            vetVisitsDAO.AddVisit(newvisit);

            visitsBindingSource.DataSource = vetVisitsDAO.GetAllAnimalsAndVetVisits();
            dataGridView1.DataSource = visitsBindingSource;
        }
        private void cb_vet_Click(object sender, EventArgs e)
        {
            vetBindingSource.DataSource = vetVisitsDAO.GetAllVetNames();
            List<String> vets = vetBindingSource.DataSource as List<String>;

            cb_vet.DataSource = vets;
            cb_vet.DisplayMember = "Tostring";
        }
        private void cb_animal_Click(object sender, EventArgs e)
        {
            animalsBindingSource.DataSource = animalsDAO.GetAllAnimals();
            List<Animal> animalList = animalsBindingSource.DataSource as List<Animal>;
            List<String> animalNames = animalList.Select(animal => animal.Name).ToList();

            cb_animal.DataSource = animalNames;
            cb_animal.DisplayMember = "Tostring";
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            AnimalVetVisit newVisit = new AnimalVetVisit
            {
                ID_Visit=int.Parse(cb_ID.Text),
                Name_Animal = cb_animal.Text,
                Name_Vet=cb_vet.Text,
                Date=DateTime.Parse(dt_date.Text),
                Diagnostic = tb_diagnostic.Text,
                Treatment = tb_tratament.Text
            };
            vetVisitsDAO.EditVisit(newVisit);

            visitsBindingSource.DataSource = vetVisitsDAO.GetAllAnimalsAndVetVisits();
            dataGridView1.DataSource = visitsBindingSource;
        }
    }
}
