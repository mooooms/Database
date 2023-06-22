using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_2
{
    public class Person
    {
        public Person(string name, string surname, string middle_name, byte age)
        {
            Name = name;
            Surname = surname;
            Middle_name = middle_name;
            Age = age;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middle_name { get; set; }
        private byte _age = 0;
        public byte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 100 || value < 0) return;
                _age = value;
            }
        }
    }
}
