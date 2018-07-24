using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void ReRoll(int input)
        {    
            Console.WriteLine("Would You Like TO Try Your Luck Again?(Y/N)");
            string userChoice =Console.ReadLine();

            while(!Regex.IsMatch(userChoice,@"^[yYnN]$"))
            {
                Console.WriteLine("Please Enter Y to ReRoll or N to End Program");
                userChoice = Console.ReadLine();
            }

            if (Regex.IsMatch(userChoice, @"^[yY]$"))
            {
                RollOutcome(input);
            }

            else if (Regex.IsMatch(userChoice, @"^[nN]$"))
            {
                return;  
            }
                 
        }

        static void RollOutcome(int input)
        {
            int randnum1 = RandomNumber.Randomness.getNextInt(1, input);
            System.Threading.Thread.Sleep(1500);
            int randnum2 = RandomNumber.Randomness.getNextInt(1, input);
            Console.WriteLine(randnum1);
            Console.WriteLine(randnum2);
            
            if (randnum1 == randnum2 && randnum1 == 1)
            {
                Console.WriteLine("SNAKE EYES!!!!!!!!!!!!");
            }
            else if (randnum1 == randnum2 && randnum1 == 6)
            {
                Console.WriteLine("BOXCARS!!!!!!!!");
            }
            else if (randnum1+randnum2 == 11 || randnum1 + randnum2 == 7)
            {
                Console.WriteLine("CRAPS!!!!!!!");
            }
            ReRoll(input);
        }

        static void Main()
        {
            Console.WriteLine("Enter the number of sided dice you would like to use:");
            int diceSide = int.Parse(Console.ReadLine());
            Console.WriteLine("Press enter to roll the dice");
            Console.ReadKey();

            RollOutcome(diceSide);
          //  ReRoll(diceSide);
            


        }
    }
}
