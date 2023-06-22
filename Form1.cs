using System;
using System.Windows.Forms;

namespace Database_2
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        
        private void button1_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection("Server=localhost;Port=5432; Database=Employees; UserId=postgres;Password=1234");
            try
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM \"Employees\"";
                    var result = command.ExecuteReader();
                    while (result.Read())
                    {
                        dataGridView1.Rows.Add(result[0], result[1], result[2], result[3], result[4]);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }
        }
    }
}
