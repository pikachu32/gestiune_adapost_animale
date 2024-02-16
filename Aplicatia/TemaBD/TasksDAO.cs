using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemaBD
{
    internal class TasksDAO
    {
        string connectionString = "User Id=bd001; Password=bd001; Data Source=bd-dc.cs.tuiasi.ro:1539/orcl; Connection Timeout=60;";

        public List<Task> GetAllTasks()
        {
            List<Task> tasks = new List<Task>();

            try
            {

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = "select s.id_sarcina, s.descriere_sarcina, s.data_alocarii, s.deadline, s.id_angajat, p.nume_angajat, p.functie from sarcini_angajati s, personal_adapost p where s.id_angajat = p.id_angajat";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Task t = new Task
                            {
                                ID = reader.GetInt32(0),
                                Description = reader.GetString(1),
                                Assignment_Date = reader.GetDateTime(2),
                                Deadline_Date = reader.GetDateTime(3),
                                ID_Employee = reader.GetInt32(4),
                                Name= reader.GetString(5),
                                Function=reader.GetString(6)
                            };
                            Console.WriteLine(t);
                            tasks.Add(t);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return tasks;
        }

        
        public void AddTask(Task task, String nume)
        {
            try
            {

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO sarcini_angajati (id_sarcina, descriere_sarcina, data_alocarii, deadline, id_angajat) VALUES (sarcini_angajati_id_sarcina.NEXTVAL, :descriere, :data_alocare, :deadline, (select id_angajat from personal_adapost where nume_angajat = :nume))";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("descriere", OracleDbType.Varchar2).Value = task.Description;
                        command.Parameters.Add("data_alocare", OracleDbType.Date).Value = task.Assignment_Date;
                        command.Parameters.Add("deadline", OracleDbType.Date).Value = task.Deadline_Date;
                        command.Parameters.Add("nume", OracleDbType.Varchar2).Value = nume;

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteTask(int sarcinaId)
        {
            try
            {

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM sarcini_angajati WHERE ID_SARCINA = :sarcinaId";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter(":sarcinaId", OracleDbType.Int32)).Value = sarcinaId;

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EditTask(Task task)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    StringBuilder queryBuider = new StringBuilder("UPDATE sarcini_angajati SET ");
                    if (!string.IsNullOrEmpty(task.Description))
                        queryBuider.Append($"descriere_sarcina='{task.Description}', ");
                    if (task.Deadline_Date != null && task.Deadline_Date > DateTime.Now)
                        queryBuider.Append($"deadline= TO_DATE('{task.Deadline_Date}', 'MM/DD/YYYY HH:MI:SS AM'), ");
                    if (task.ID_Employee > 0)
                        queryBuider.Append($"id_angajat ={task.ID_Employee}, ");

                    queryBuider.Length -= 2;
                    queryBuider.Append($" WHERE id_sarcina = {task.ID}");

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
