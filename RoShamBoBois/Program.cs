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
            //our array of choices
            string[] roshambo = { "rock", "paper", "scissors" };
            //declare variable to hold user's input, we initialize this later
            string userhand;

            //copy of Random class
            Random rnd = new Random();
            //generate random number between 0-2, 3 doesnt get included - why do we put it to 3?
            int cpuhand = rnd.Next(0, 3);

            do
            {
                //KEEP ASKING USER FOR THEIR HAND
                Console.WriteLine("Roshambo - Throw your hand...");
                userhand = Console.ReadLine().ToLower();

            } while (!userhand.Equals("rock") && !userhand.Equals("paper") && !userhand.Equals("scissors"));
            //WHILE THEIR INPUT ISNT 1 OF 3 
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
            //ONCE WE ARE DOWN HERE, WE ARE 100% SURE THE USER HAS INPUT 1 OF 3 CHOICES

            Console.ReadLine();



        }
    }
}

//1-r 2-p 3-s

// 1 x 1 - draw
// 1 x 2 - pc win
// 1 x 3 - user win
// 2 x 1 - user win
// 2 x 2 - draw
// 2 x 3 - pc win
// 3 x 1 - pc win
// 3 x 2 - user win
// 3 x 3 - draw


//get input from user
//validate user input (has to be a valid option)
//generate random hand for computer
// if equal moves
//draw
// if player has rock, computer has paper
// computer wins
// else if player has scissors, computer has paper
// player wins

//            if (userhand == "Rock")
//        {
//                return = 0;
//            } else if (userhand == "Paper")
//            {
//                return = 1;
//            } else if (userhand == "Scissors")
//            {
//               return = 2
//            }

