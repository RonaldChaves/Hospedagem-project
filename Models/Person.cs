using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem_project.Models
{
    public class Person
    {
        private string _name;
        private string _lastName;
        public Person(string name) => Name = name;

        public string Name
        {
            get => _name.ToUpper();
            set
            {
                if (value == " " || value == null)
                {
                    throw new ArgumentException("The 'name' is empty or null.");
                }
                _name = value;
            }
        }
        public string LastName
        {
            get => _lastName.ToUpper();
            set
            {
                if (value == " " || value == null)
                {
                    throw new ArgumentException("The 'last name' is empty or null.");
                }
                _lastName = value;
            }
        }

    }
}