using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemaBD
{
    internal class EmployeeDAO
    {
        string connectionString = "User Id=bd001; Password=bd001; Data Source=bd-dc.cs.tuiasi.ro:1539/orcl; Connection Timeout=60;";

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            try
            {

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM personal_adapost";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee e = new Employee
                            {
                                ID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Function = reader.GetString(2),
                                PhoneNumber = reader.GetString(3)
                            };
                            Console.WriteLine(e);
                            employees.Add(e);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return employees;
        }

        public void AddEmployee(Employee employee)
        {
            try
            {

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO personal_adapost (id_angajat, nume_angajat, functie, telefon) VALUES (personal_adapost_id_angajat.NEXTVAL, :name, :function, :phone)";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("name", OracleDbType.Varchar2).Value = employee.Name;
                        command.Parameters.Add("function", OracleDbType.Varchar2).Value = employee.Function;
                        command.Parameters.Add("phone", OracleDbType.Varchar2).Value = employee.PhoneNumber;

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            try
            {

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM personal_adapost WHERE ID_ANGAJAT = :employeeId";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter(":employeeId", OracleDbType.Int32)).Value = employeeId;

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EditEmployee(Employee employee)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    StringBuilder queryBuider = new StringBuilder("UPDATE personal_adapost SET ");
                    if (!string.IsNullOrEmpty(employee.Name))
                        queryBuider.Append($"nume_angajat='{employee.Name}', ");
                    if (!string.IsNullOrEmpty(employee.Function))
                        queryBuider.Append($"functie='{employee.Function}', ");
                    if (!string.IsNullOrEmpty(employee.PhoneNumber))
                        queryBuider.Append($"telefon='{employee.PhoneNumber}', ");

                    queryBuider.Length -= 2;
                    queryBuider.Append($" WHERE id_angajat = {employee.ID}");

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
