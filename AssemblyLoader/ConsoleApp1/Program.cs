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
            //Carico Assembly 
            Assembly loadedAssembly = Assembly.LoadFrom("MyDll.dll");
            //Ottengo tipo della classe Customer
            Type customerType = loadedAssembly.GetType("MyDll.Customer");
            //Creo istanza del tipo Customer
            var customerInstance = Activator.CreateInstance(customerType);

            //Ottengo array dei metodi nella classe
            MethodInfo[] methods = customerType.GetMethods();

            //Stampo metodi nella classe
            Console.WriteLine("Metodi nella classe {0}:\n", customerType.FullName);
            foreach (var met in methods)
            {
                Console.WriteLine(met.Name);
            }

            var parameters = new object[1];
            parameters[0] = "Pietro";
            //Invoco il setter nome
            MethodInfo setName = customerType.GetMethod("set_Name");
            if (setName != null) setName.Invoke(customerInstance, parameters);

            parameters[0] = "Cattaneo";
            //Invoco il setter cognome
            MethodInfo setSurname = customerType.GetMethod("set_Surname");
            if (setName != null) setSurname.Invoke(customerInstance, parameters);
            
            //Invoco metodo d'istanza per stampa nome e eta'
            MethodInfo getFullName = customerType.GetMethod("getFullNameAndAge");
            parameters[0] = 23;
            if (getFullName != null)
            {
                string nameAndAge = (string)getFullName.Invoke(customerInstance, parameters);
                //Stampo
                Console.WriteLine("\n" + nameAndAge);
            }
            Console.ReadLine();
        }
    }
}
