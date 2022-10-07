using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBar boost = new ChocolateBar("Boost", 163, 31.5);
            ChocolateBar rolo = new ChocolateBar("Rolo", 200, 41.6);

            boost.Eat();
            rolo.Eat();

            Console.ReadLine();
        }
    }
}
