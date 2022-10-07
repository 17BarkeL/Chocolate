using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolate
{
    class ChocolateBar
    {
        public string name;

        /// <summary>
        /// Number of calories per chocolate bar
        /// </summary>
        public int calories;

        /// <summary>
        /// Weight of the chocolate bar in grams
        /// </summary>
        public double weightInGrams;

        public ChocolateBar(string name, int calories, double weightInGrams)
        {
            this.name = name;
            this.calories = calories;
            this.weightInGrams = weightInGrams;
        }

        /// <summary>
        /// Eat the chocolate bar
        /// </summary>
        public void Eat()
        {
            Console.WriteLine($"Yum you ate a {name} which was {calories} calories");
            weightInGrams = 0;
        }

        public void Throw()
        {
            Console.WriteLine("Ouch");
        }
    }
}
