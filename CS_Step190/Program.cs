using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step190
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string>()
            { "OneThing", "TwoThing", "ThreeThing", "FourThing" };

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>()
            { 80085, 69420, 12345, 8675309};

            for (int i = 0; i < employee1.Things.Count(); i++)
            {
                Console.WriteLine("\n" + employee1.Things[i]);
            }

            for (int i = 0; i < employee2.Things.Count(); i++)
            {
                Console.WriteLine("\n" + employee2.Things[i]);
            }

            Console.ReadLine();
        }
    }
}
