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
        static void ReRoll()
        {
            Console.WriteLine("Would You Like TO Try YOur Luck Again?(Y/N)");
            string userChoice =Console.ReadLine();

            while(!Regex.IsMatch(userChoice,@"^[yYnN]$"))
            {
                Console.WriteLine("Please Enter Y to ReRoll or N to End Program");
                userChoice = Console.ReadLine();
            }
            if (Regex.IsMatch(userChoice, @"^[yY]$"))
            {
                Main();
            }
            else if (Regex.IsMatch(userChoice, @"^[nN]$"))
            {
                return;
            }
               
        }
        static void Main()
        {
            Console.WriteLine("Enter the number of sided dice you would like to use:");
            int diceSide = int.Parse(Console.ReadLine());
            Console.WriteLine("Press enter to roll the dice");
            Console.ReadKey();

            int randnum1 =RandomNumber.Randomness.getNextInt(1, diceSide);
            System.Threading.Thread.Sleep(1500);
            int randnum2 = RandomNumber.Randomness.getNextInt(1, diceSide);
            Console.WriteLine(randnum1);
            Console.WriteLine(randnum2);
            ReRoll();
            


        }
    }
}
