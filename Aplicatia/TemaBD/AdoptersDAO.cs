using System;
using System.Collections.Generic;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace TemaBD
{
    internal class AdoptersDAO
    {
        string connectionString = "User Id=bd001; Password=bd001; " +
            "Data Source=bd-dc.cs.tuiasi.ro:1539/orcl; Connection Timeout=60;";

        public List<Adopter_Animal> GetAllAdoptersAndAnimals()
        {
            List<Adopter_Animal> adopters = new List<Adopter_Animal>();

            try
            {

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT AD.ID_ADOPTATOR, AD.NUME_ADOPTATOR, AD.ADRESA, " +
                        "AD.TELEFON, AD.ID_ANIMAL, A.NUME_ANIMAL, A.SPECIE\r\nFROM ADOPTATORI AD, " +
                        "ANIMALE A WHERE AD.ID_ANIMAL=A.ID_ANIMAL";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Adopter_Animal a = new Adopter_Animal
                            {
                                ID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Address = reader.GetString(2),
                                PhoneNumber = reader.GetString(3),
                                ID_Animal = reader.GetInt32(4),
                                Animal_Name = reader.GetString(5),
                                Species = reader.GetString(6)
                            };
                            Console.WriteLine(a);
                            adopters.Add(a);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return adopters;
        }

        public void AddAdopter(Adopter adopter)
        {
            try
            {

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO adoptatori (id_adoptator, nume_adoptator, adresa, telefon, id_animal) VALUES (adoptatori_id_adoptator_seq.NEXTVAL, :name, :address, :phone, :id_animal)";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("name", OracleDbType.Varchar2).Value = adopter.Name;
                        command.Parameters.Add("address", OracleDbType.Varchar2).Value = adopter.Address;
                        command.Parameters.Add("phone", OracleDbType.Varchar2).Value = adopter.PhoneNumber;
                        command.Parameters.Add("id_animal", OracleDbType.Int32).Value = adopter.ID_Animal;

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<Adopter> GetAllAdopters()
        {
            List<Adopter> adopters = new List<Adopter>();

            try
            {

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM ADOPTATORI";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Adopter a = new Adopter
                            {
                                ID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Address = reader.GetString(2),
                                PhoneNumber = reader.GetString(3),
                                ID_Animal = reader.GetInt32(4)
                            };
                            Console.WriteLine(a);
                            adopters.Add(a);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return adopters;
        }

        
        public void DeleteAdopter(int adopterId)
        {
            try
            {

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM adoptatori WHERE ID_ADOPTATOR = :adopterId";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter(":adopterId", OracleDbType.Int32)).Value = adopterId;

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EditAdopter(Adopter adopter)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    StringBuilder queryBuider = new StringBuilder("UPDATE adoptatori SET ");
                    if (!string.IsNullOrEmpty(adopter.Name))
                        queryBuider.Append($"nume_adoptator='{adopter.Name}', ");
                    if(!string.IsNullOrEmpty(adopter.Address))
                        queryBuider.Append($"adresa='{adopter.Address}', ");
                    if (!string.IsNullOrEmpty(adopter.PhoneNumber))
                        queryBuider.Append($"telefon='{adopter.PhoneNumber}', ");
                    if (adopter.ID_Animal != 0)
                        queryBuider.Append($"id_animal='{adopter.ID_Animal}', ");

                    queryBuider.Length -= 2;
                    queryBuider.Append($" WHERE id_adoptator = {adopter.ID}");

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

