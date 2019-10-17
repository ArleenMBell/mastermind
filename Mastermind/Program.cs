using System;
using System.Linq;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            var result = string.Empty;
            var youWin = false;
            var tryNum = 0;

            var first = rand.Next(1, 6);
            var second = rand.Next(1, 6);
            var third = rand.Next(1, 6);
            var fourth = rand.Next(1, 6);

            var gameNumber = $"{first}{second}{third}{fourth}".ToCharArray();


            while (tryNum < 10)
            {
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input) || input.Length != 4)
                {
                    ++tryNum;
                    continue;
                }

                var inputChars = input.ToCharArray();

                for (var index = 0; index < gameNumber.Length; ++index)
                {
                    if (gameNumber[index] == inputChars[index])
                    {
                        result += "+";
                    }
                    else
                    {
                        if (gameNumber.Contains(inputChars[index]))
                        {
                            result += "-";
                        }
                        else
                        {
                            result += " ";
                        }
                    }
                }

                Console.WriteLine(result);

                if (result == "++++")
                {
                    youWin = true;
                    break;
                }

                ++tryNum;
            }

            Console.WriteLine(youWin ? "You Win!!!" : "You lose!!!");


            Console.ReadKey();
        }
    }
}
