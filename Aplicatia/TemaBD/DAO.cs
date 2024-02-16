using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemaBD
{
    internal class DAO
    {
        string connectionString = "User Id=bd001; Password=bd001; Data Source=bd-dc.cs.tuiasi.ro:1539/orcl; Connection Timeout=60;";

        public List<Info> GetInfo()
        {
            List<Info> infoL = new List<Info>();

            try
            {

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT (SELECT COUNT(*) FROM animale) AS Animals,  (SELECT COUNT(DISTINCT id_animal) FROM adoptatori) AS Numar_Animale_Adoptate, (SELECT AVG(varsta) FROM animale) AS Medie_Varsta, (SELECT COUNT(*) FROM adoptatori) AS Adopters, (SELECT COUNT(*) FROM personal_adapost) AS Employees, (SELECT COUNT(*) FROM vizite_veterinar) AS Vet_Visits FROM dual";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Info info = new Info
                            {
                                Nr_Animals = reader.GetInt32(0),
                                Nr_Animals_Adopted = reader.GetInt32(1),
                                Avg_Age = reader.GetInt32(2),
                                Nr_Adopters = reader.GetInt32(3),
                                Nr_Employees = reader.GetInt32(4),
                                Nr_Visits = reader.GetInt32(5)
                            };
                            infoL.Add(info);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return infoL;
        }
    }
}
