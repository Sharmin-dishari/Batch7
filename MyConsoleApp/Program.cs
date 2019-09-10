using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int age;
            string address;
            int contact;
            Console.WriteLine("Enter Your Name");
            name = Console.ReadLine();
            
            Console.WriteLine("Enter Your Age");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your Address");
            address = Console.ReadLine();

            Console.WriteLine("Enter Your Contact");
            contact = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: " + name + "\n" + "Age:" + age + "\n" + "Address:" + address + "\n" + "Contact:" + contact);
            Console.ReadKey();

        }
    }
}
