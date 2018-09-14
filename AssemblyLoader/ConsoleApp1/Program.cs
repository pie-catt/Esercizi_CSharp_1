using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Assembly loadedAssembly = Assembly.LoadFrom("MyDll.dll");
            Type customerType = loadedAssembly.GetType("MyDll.Customer");
            var customerInstance = Activator.CreateInstance(customerType);
            MethodInfo getFullName = customerType.GetMethod("getFullNameAndAge");
            var parameters = new object[1];
            parameters[0] = 23;
            string nameAndAge = (string)getFullName.Invoke(customerInstance, parameters);

            Console.WriteLine(nameAndAge);
            Console.ReadLine();
        }
    }
}
