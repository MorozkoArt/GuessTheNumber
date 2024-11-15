using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Guess the number");
            Console.WriteLine("\n");
            bool verification = false;
            bool play_again = true;
            bool end = false;
            int guessed_number = -1;
            int maxNumber = 101;
            int estimated_number = -1;
            int minNumber = 0;
            int yesORno;
            int numberofsteps = 0;
            while (play_again) 
            {
                Console.WriteLine("/".PadRight(100, '/'));
                while (!verification)
                {
                    Console.WriteLine("Guess the number from 1 to 100");
                    guessed_number = int.Parse(Console.ReadLine());
                    if (guessed_number <= 100 && guessed_number >= 1) verification = true;
                    else Console.WriteLine("Incorrect input, try again");
                }
                Console.WriteLine("The program itself will not know this number, but now let's try to guess it");
                end = false;
                while (!end)
                {
                    estimated_number = (minNumber + maxNumber) / 2;
                    numberofsteps++;
                    Console.WriteLine("Your number  " + estimated_number + "? ( 1 - yes | 2 - No)");
                    yesORno = int.Parse(Console.ReadLine());
                    if (yesORno != 1)
                    {
                        Console.WriteLine("Your number is higher " + estimated_number + "? ( 1 - yes | 2 - No)");
                        yesORno = int.Parse(Console.ReadLine());
                        if (yesORno == 1) minNumber = estimated_number;                       
                        else maxNumber = estimated_number;                       
                    }
                    else
                    {
                        Console.WriteLine(" Wow, I guessed your number in " + numberofsteps + " tries. Your number: " + estimated_number);
                        end = true;
                        Console.WriteLine("Do you want to play again? ( 1 - yes | 2 - No)");
                        yesORno = int.Parse(Console.ReadLine());
                        if (yesORno == 1) 
                        {
                            Console.WriteLine("\n");
                            play_again = true;
                            verification = false;
                            maxNumber = 101;
                            minNumber = 0;
                            numberofsteps = 0;
                        }
                        else Environment.Exit(0);
                    }
                }
            }
            Console.ReadKey();           
        }
    }
}
