using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Database_2
{
    public class UpdateClass
    {
        public void UpdateMethod(Person p)
        {
            Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection("Server=localhost;Port=5432; Database=Employees; UserId=postgres;Password=1234");
            try
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    var cmd = "UPDATE \"Employees\"" +
                    $"(SET \"name\"='{p.Name}'," +
                    $" \"surname\" ='{p.Surname}'," +
                    $" \" middle_name\"='{p.Middle_name}'," +
                    $" \"age\" ='{p.Age}')" +
                    "WHERE" +
                    $"(\"name\"='{p.Name}')";
                    MessageBox.Show(cmd);
                    command.CommandText = cmd;
                    var result = command.ExecuteNonQuery();
                    MessageBox.Show($"Изменено строк: {result}");
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
