using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDll
{
    public class Customer
    {
        public string name { get; set; }
        public string surname { get; set; }

        public string getFullNameAndAge(int age)
        {
            return name + surname + age.ToString();
        }
    }
}
