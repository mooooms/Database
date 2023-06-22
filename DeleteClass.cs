using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Database_2
{
    public class DeleteClass
    {
        public void DeleteMethod(Person p)
        {
            Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection("Server=localhost;Port=5432; Database=Employees; UserId=postgres;Password=1234");
            try
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    var cmd = "DELETE FROM \"Employees\"" +
                       $"WHERE\"name\"='{p.Name}'";
                    MessageBox.Show(cmd);
                    command.CommandText = cmd;
                    var result = command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }
        }
    }
}
