using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class _15_Guess_Game
    {
        public static void game()
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses=false;

            while (!(guess==secretWord)&&!outOfGuesses)
            {
                if (guessCount<guessLimit)
                {
                    Console.WriteLine("Enter a guess : ");
                    guess=Console.ReadLine();
                    guessCount++;

                }
                else{
                    outOfGuesses = true;
                }

            }
            if (outOfGuesses)
                Console.WriteLine("You Lose!");
            else
                Console.WriteLine("You Win !");
        }
    }
}
