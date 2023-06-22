
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

namespace Database_2
{
    public class CreateClass
    {
        public void CreateMethod(Person p)
        {
            Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection("Server=localhost;Port=5432; Database=Employees; UserId=postgres;Password=1234");
            try
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO \"Employees\"" +
                    "(\"name\", \"surname\", middle_name, \"age\")" +
                    "VALUES" +
                    $"('{p.Name}','{p.Surname}','{p.Middle_name}',{p.Age})";

                    var result = command.ExecuteNonQuery();
                    MessageBox.Show($"Добавленно строк: {result}");
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
