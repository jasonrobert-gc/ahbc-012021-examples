using System;

namespace Exercise21
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = FetchWords();
            PrintOutput(words);
        }

        private static string[] FetchWords()
        {
            var result = new string[1_000];
            var index = 0;
            do
            {
                Console.Write("Enter a word:");
                result[index] = Console.ReadLine();
                index++; // index = index + 1;
            } while (PromptTryAgain());

            return result;
        }

        private static void PrintOutput(string[] words)
        {
            foreach (var word in words)
            {
                if (word == null)
                {
                    break;
                }

                Console.Write($"{word} ");
            }
        }

        private static bool PromptTryAgain()
        {
            Console.Write("Would you like to try again?");
            var response = Console.ReadLine();
            return response.Equals("y", StringComparison.OrdinalIgnoreCase);
        }
    }
}
