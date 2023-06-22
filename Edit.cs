using System;
using System.Windows.Forms;

namespace Database_2
{
    public partial class Edit : Form
    {
        public Edit() => InitializeComponent();
        public void create_Click(object sender, EventArgs e)
        {
            CreateClass create_class = new CreateClass();
            create_class.CreateMethod(new Person(name.Text, surname.Text, middle_name.Text, byte.Parse(age.Text)));
        }
        private void delete_Click(object sender, EventArgs e)
        {
            DeleteClass delete_class = new DeleteClass();
            delete_class.DeleteMethod(new Person(name.Text, surname.Text, middle_name.Text, byte.Parse(age.Text)));
        }
        private void update_Click(object sender, EventArgs e)
        {
            UpdateClass update_class = new UpdateClass();
            update_class.UpdateMethod(new Person(name.Text, surname.Text, middle_name.Text, byte.Parse(age.Text)));
        }
    }
}

