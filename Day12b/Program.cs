using System;

namespace Day12b
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveData(new EmptyDataRepository());
        }

        private static void SaveData(IDataRepository repository)
        {
            bool tryAgain;
            do 
            {
                Console.Write("Enter data to save: ");
                var data = Console.ReadLine();
                repository.Save(data);

                Console.Write($"So far you have saved, ({repository.GetAll()}).  Would you like to try again?");
                tryAgain = Console.ReadLine().Trim().Equals("y", StringComparison.OrdinalIgnoreCase);
            } while (tryAgain);
        }
    }
}
