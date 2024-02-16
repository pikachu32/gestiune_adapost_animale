using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemaBD
{
    internal class VetVisitsDAO
    {
        string connectionString = "User Id=bd001; Password=bd001; Data Source=bd-dc.cs.tuiasi.ro:1539/orcl; Connection Timeout=60;";

        public List<AnimalVetVisit> GetAllAnimalsAndVetVisits()
        {
            List<AnimalVetVisit> visits = new List<AnimalVetVisit>();

            try
            {

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = "select vv.id_vizita, a.id_animal, a.nume_animal, a.specie, a.varsta, a.sex, a.stare_animal, " +
                        "v.id_veterinar, v.nume_veterinar, v.specializare, v.experienta, v.telefon, " +
                        "vv.data_vizitei, vv.diagnostic, vv.tratament, a.id_angajat " +
                        "from animale a, veterinari v, vizite_veterinar vv " +
                        "where vv.animale_id_animal = a.id_animal " +
                        "and vv.veterinari_id_veterinar=v.id_veterinar";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AnimalVetVisit v = new AnimalVetVisit
                            {
                                ID_Visit= reader.GetInt32(0),
                                ID_Animal = reader.GetInt32(1),
                                Name_Animal = reader.GetString(2),
                                Species = reader.GetString(3),
                                Age = reader.GetInt32(4),
                                Sex = reader.GetString(5),
                                State = reader.GetString(6),

                                ID_Vet = reader.GetInt32(7),
                                Name_Vet = reader.GetString(8),
                                Specialization = reader.GetString(9),
                                Experience = reader.GetString(10),
                                PhoneNumber = reader.GetString(11),

                                Date = reader.GetDateTime(12),
                                Diagnostic = reader.IsDBNull(13) ? null : reader.GetString(13),
                                Treatment = reader.IsDBNull(14) ? null : reader.GetString(14),

                                ID_Employee = reader.GetInt32(15),
                            };
                            Console.WriteLine(v);
                            visits.Add(v);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return visits;
        }
        public List<String> GetAllVetNames()
        {
            List<String> vets = new List<String>();

            try
            {

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = "select nume_veterinar from veterinari";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String vetName = reader.GetString(0);
                            Console.WriteLine(vetName);
                            vets.Add(vetName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return vets;
        }
        public void AddVisit(AnimalVetVisit visit)
        {
            try
            {

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = $"INSERT INTO vizite_veterinar (animale_id_animal, veterinari_id_veterinar, id_vizita, data_vizitei, diagnostic, tratament) " +
                        $"VALUES ((select id_animal from animale where nume_animal = '{visit.Name_Animal}'), " +
                        $"(select id_veterinar from veterinari where nume_veterinar = '{visit.Name_Vet}'), " +
                        $"vizite_veterinar_id_vizita_seq.NEXTVAL, TO_DATE('{visit.Date}', 'MM/DD/YYYY HH:MI:SS AM'), '{visit.Diagnostic}', '{visit.Treatment}')";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    { 
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteVisit(int vizitaId)
        {
            try
            {

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM vizite_veterinar WHERE ID_VIZITA = :vizitaId";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter(":vizitaId", OracleDbType.Int32)).Value = vizitaId;

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EditVisit(AnimalVetVisit visit)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    StringBuilder queryBuider = new StringBuilder("UPDATE vizite_veterinar SET ");
                    if (!string.IsNullOrEmpty(visit.Name_Animal))
                        queryBuider.Append($"animale_id_animal = (select id_animal from animale where nume_animal = '{visit.Name_Animal}'), ");
                    if (!string.IsNullOrEmpty(visit.Name_Vet))
                        queryBuider.Append($"veterinari_id_veterinar= (select id_veterinar from veterinari where nume_veterinar ='{visit.Name_Vet}'), ");
                    if (visit.Date != null && visit.Date > DateTime.Now)
                        queryBuider.Append($"data_vizitei= TO_DATE('{visit.Date}', 'MM/DD/YYYY HH:MI:SS AM'), ");
                    if (!string.IsNullOrEmpty(visit.Diagnostic))
                        queryBuider.Append($"diagnostic ='{visit.Diagnostic}', ");
                    if (!string.IsNullOrEmpty(visit.Treatment))
                        queryBuider.Append($"tratament ='{visit.Treatment}', ");

                    queryBuider.Length -= 2;
                    queryBuider.Append($" WHERE id_vizita = {visit.ID_Visit}");

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
