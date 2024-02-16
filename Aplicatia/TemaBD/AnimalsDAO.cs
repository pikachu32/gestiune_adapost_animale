using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.ComponentModel;

namespace TemaBD
{
    internal class AnimalsDAO
    {
        string connectionString = "User Id=bd001; Password=bd001; Data Source=bd-dc.cs.tuiasi.ro:1539/orcl; Connection Timeout=60;";

        public List<Animal> GetAllAnimals()
        {
            List<Animal> animals = new List<Animal>();

            try
            {

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM ANIMALE";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Animal a = new Animal
                            {
                                ID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Species = reader.GetString(2),
                                Age = reader.GetInt32(3),
                                Sex=reader.GetString(4),
                                State= reader.GetString(5),
                                ID_Employee = reader.GetInt32(6)
                            };
                            Console.WriteLine(a);
                            animals.Add(a);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return animals;
        }

        public void AddAnimal(AnimalVetVisit animal, String nume)
        { 

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                OracleTransaction transaction = connection.BeginTransaction();

                try
                {
                    string animalInsertquery = "INSERT INTO animale (id_animal, nume_animal, specie, varsta, sex, stare_animal, id_angajat)" +
                        " VALUES (animale_id_animal_seq.NEXTVAL, :name, :species, :age, :sex, :state, :id_emp)";
                    using (OracleCommand command = new OracleCommand(animalInsertquery, connection))
                    {
                        command.Parameters.Add("name", OracleDbType.Varchar2).Value = animal.Name_Animal;
                        command.Parameters.Add("species", OracleDbType.Varchar2).Value = animal.Species;
                        command.Parameters.Add("age", OracleDbType.Int32).Value = animal.Age;
                        command.Parameters.Add("sex", OracleDbType.Varchar2).Value = animal.Sex;
                        command.Parameters.Add("state", OracleDbType.Varchar2).Value = animal.State;
                        command.Parameters.Add("id_emp", OracleDbType.Int32).Value = animal.ID_Employee;
                        command.ExecuteNonQuery();
                    }
                    int animal_ID = GetLastInsertedAnimalID(connection);

                    string visitInsertquery = "INSERT INTO vizite_veterinar(animale_id_animal, veterinari_id_veterinar, id_vizita, data_vizitei) " +
                        $"VALUES({animal_ID}, (select id_veterinar from veterinari where nume_veterinar='{nume}'), " +
                        $"vizite_veterinar_id_vizita_seq.NEXTVAL, TO_DATE('{animal.Date}', 'MM/DD/YYYY HH:MI:SS AM'))";

                    using (OracleCommand command = new OracleCommand(visitInsertquery, connection))
                    {
                        /*command.Parameters.Add("id_animal", OracleDbType.Int32).Value = animal_ID;

                        command.Parameters.Add("nume", OracleDbType.Varchar2).Value = nume;
                        command.Parameters.Add("date", OracleDbType.Date).Value = animal.Date;*/
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
            
            
        }
        private int GetLastInsertedAnimalID(OracleConnection connection)
        {
            string query = "SELECT MAX(id_animal) FROM animale";
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                object result = command.ExecuteScalar();
                return (result == DBNull.Value) ? 0 : Convert.ToInt32(result);
            }
        }
        public void DeleteAnimal(int animalID)
        {
            try
            {

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM animale WHERE ID_ANIMAL = :animalId";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter(":animalId", OracleDbType.Int32)).Value = animalID;

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EditAnimal(Animal animal)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    StringBuilder queryBuider = new StringBuilder("UPDATE animale SET ");
                    if (!string.IsNullOrEmpty(animal.Name))
                        queryBuider.Append($"nume_animal='{animal.Name}', ");
                    if (!string.IsNullOrEmpty(animal.Species))
                        queryBuider.Append($"specie='{animal.Species}', ");
                    if (animal.Age>=0)
                        queryBuider.Append($"varsta='{animal.Age}', ");
                    if (!string.IsNullOrEmpty(animal.Sex))
                        queryBuider.Append($"sex='{animal.Sex}', ");
                    if (!string.IsNullOrEmpty(animal.State))
                        queryBuider.Append($"stare_animal='{animal.State}', ");
                    if (animal.ID_Employee != 0)
                        queryBuider.Append($"id_angajat='{animal.ID_Employee}', ");

                    queryBuider.Length -= 2;
                    queryBuider.Append($" WHERE id_animal = {animal.ID}");

                    using (OracleCommand command = new OracleCommand(queryBuider.ToString(), connection))
                        command.ExecuteNonQuery();
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Oracle Error {ex.Number}: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
