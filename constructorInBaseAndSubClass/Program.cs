using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorInBaseAndSubClass
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount save = new SavingAccount("SAV-78542", "Jamal Uddin", 4582.12);
            CeckingAccount ceck = new CeckingAccount("CH-74512", "Jomela Khatun", 5632.12);
            Console.ReadKey();
        }
    }
}
