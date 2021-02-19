using System;

namespace Day14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the type of shape: ");
            var shapeType = Console.ReadLine();

            Console.Write("Enter the addl information on the shape: ");
            var parameter = int.TryParse(Console.ReadLine(), out int value) ? value : default;
            
            var shape = ShapeFactory.Instance.Create(shapeType, parameter);
            Console.WriteLine($"The area of your shape is: {shape.GetArea()}");

            // To prove it is a singleton
            var shape2 = ShapeFactory.Instance.Create("square", 4);

            // 1. Create a new branch off of main       - git checkout -B new-branch
            // 2. Make change and commit to new branch  - git add . / git commit -m "some message"
            // 3. When finished, push branch to github  - git push --set-upstream origin new-branch
            // 4. Create pull request from new branch   - Done from GitHub web application
            // 5. Merge pull request into main          - Done from GitHub web application
            // 6. Pull main merge commit locally        - git checkout main / git pull
        }
    }
}
