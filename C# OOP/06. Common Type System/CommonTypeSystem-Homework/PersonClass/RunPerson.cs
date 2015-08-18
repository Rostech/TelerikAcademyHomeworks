using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class RunPerson
    {
        static void Main(string[] args)
        {
            Person Pesho = new Person("Pesho", 19);
            Person Gosho = new Person("Gosho");

            Console.WriteLine(Pesho);
            Console.WriteLine(Gosho);
        }
    }
}
