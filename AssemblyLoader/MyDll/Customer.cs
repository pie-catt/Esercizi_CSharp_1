using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDll
{
    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public string getFullNameAndAge(int age)
        {
            return Name + " " + Surname + " " + age.ToString();
        }
    }
}
