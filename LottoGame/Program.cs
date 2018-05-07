using System;

namespace LottoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 6 numbers between 1 and 40.");
            int[] userNums = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                userNums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Now enter the multiplier number.");
            int pb = Convert.ToInt32(Console.ReadLine());

            RandNums rnd = new RandNums();
            Console.WriteLine("You got {0} out of 6 right!", NumChecker.CorrectNums(userNums, rnd.WinNums()));
            if (PowerBall.PBall(pb) == true)
            {
                Console.WriteLine("And you got the powerball ({0}) correct!", pb);
            }
            else Console.WriteLine("The PowerBall did not match.");


            Console.ReadLine();
        }
    }
}
