using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoShamBo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] roshambo = { "rock", "paper", "scissors" };

            string userhand;

            Random rnd = new Random();

            int cpuhand = rnd.Next(0, 3);

            do
            {
                Console.WriteLine("Roshambo - Throw your hand...");
                userhand = Console.ReadLine().ToLower();

            } while (!userhand.Equals("rock") && !userhand.Equals("paper") && !userhand.Equals("scissors"));

            string generated = (roshambo[cpuhand]);

            if (generated.Equals(userhand))
            {
                Console.WriteLine("You Both Threw " + generated + " - It's A Draw!");
            }
            else if (generated.Equals("rock") && userhand.Equals("scissors"))
            {
                Console.WriteLine("Computer Threw: " + generated + " - You Lose!");
            }
            else if (generated.Equals("rock") && userhand.Equals("paper"))
            {
                Console.WriteLine("Compter Threw: " + generated + " - You Win!");
            }
            else if (generated.Equals("paper") && userhand.Equals("rock"))
            {
                Console.WriteLine("Computer Threw: " + generated + " - You Lose!");
            }
            else if (generated.Equals("paper") && userhand.Equals("scissors"))
            {
                Console.WriteLine("Compter Threw: " + generated + " - You Win!");
            }
            else if (generated.Equals("scissors") && userhand.Equals("paper"))
            {
                Console.WriteLine("Computer Threw: " + generated + " - You Lose!");
            }
            else { Console.WriteLine("Compter Threw: " + generated + " - You Win!"); }

            Console.ReadLine();

            //pull request test

        }
    }
}
