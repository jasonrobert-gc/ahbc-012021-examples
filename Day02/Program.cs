using System;

namespace Day02
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Example of value types
            int number1 = 5;
            int number2 = number1;
            number1 = 6;

            Console.WriteLine(number1);
            Console.WriteLine(number2);

            // Example of reference types
            int[] num1 = new int[]{ 5 };
            int[] num2 = num1;
            num1[0] = 6;
            num2[0] = 7;

            Console.WriteLine(num1[0]);
            Console.WriteLine(num2[0]);

            // COMMON INTERVIEW QUESTION - What are value types and reference types?
            // What is the difference between the two?

            // Value type variables store the VALUE directly.  Value types store data on the stack.
            // Reference type variables store a REFERNCE to the value.  Reference types store data on the heap.
            // Hint - Think of a variable as a box or container. WHATS IN THE BOOOOOX?!?!

            // Three ways to do the same thing
            number1 = number1 + 1; // number1++; // number1 += 1;

            // Implicit Casting
            int smallNumber = 5;
            long bigNumber = smallNumber;

            // Explicit Casting
            long bigNumber2 = 5;
            int smallNumber2 = (int)bigNumber2;

            // Boolean Expressions
            Console.WriteLine(number1 == number2);
            Console.WriteLine(number1 == 7);
            Console.WriteLine(number1 + 1 == 7);
            Console.WriteLine(number1 > number2);

            // Logical Operators
            Console.WriteLine(number1 == 7 && number1 == number2); // and
            Console.WriteLine(number1 == 7 || number1 == number2); // or (C# uses short circuiting)
            Console.WriteLine(!(number1 == 7 || number1 == number2)); // not

            // Boolean variable
            int number = 5;
            bool isEven = number % 2 == 0;
            Console.WriteLine(isEven);

            // If statements
            if (isEven) // if statements will take a boolean variable OR expression
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }

            int newNumber = 4;
            if (newNumber % 2 == 0)
            {
                int newerNumber = newNumber;
                Console.WriteLine("Is divisible by two");
            }
            // 'else if' is optional. I could add as many more 'else if' statements here as I want
            else if (newNumber % 3 == 0)
            {
                Console.WriteLine("Is divisible by three");
            }
            // 'else' is optional.
            else
            {
                Console.WriteLine("I don't know what it is divisible by");
            }

            // switch statements
            int mySwitchNumber = 3;
            switch (mySwitchNumber)
            {
                case 1:
                    Console.WriteLine("The number is one.");
                    break;
                case 2:
                    Console.WriteLine("The number is two.");
                    break;
                case 3:
                    Console.WriteLine("The number is three");
                    break;
                default:
                    Console.WriteLine("I don't know what the number is");
                    break;
            }

            string text = "Jason is the best";
            switch (text)
            {
                case "Something else":
                    Console.WriteLine("Something else");
                    break;
                case "Jason is the best":
                    Console.WriteLine("Yup he is");
                    break;
                default:
                    break;
            }

            // Do loop
            string answer;
            do
            {
                Console.WriteLine("Enter (y)es or (n)");
                answer = Console.ReadLine();
            } while (answer == "y");

            // Quick note on "Scope" remember curly brackets { } are boundaries of scope.
            // Variables of an outer scope are visible but, variable of an inner scope are not.
            // You can look inside out but not outside in.
            // This is why 'answer' needed to be declared outside of the do loop

            // While loop
            string answer2 = "y";
            while (answer2 == "y")
            {
                Console.WriteLine("Enter (y)es or (n) part 2");
                answer2 = Console.ReadLine();
            }

            // For loop
            for (int i = 0; i < 5; i++)
            { 
                string output = "Your number is " + i;
                Console.WriteLine(output);
            }
            
            // For loop in reverse
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            // string manipulation
            for (int i = 0; i < 5; i++)
            {
                //string output = "Your number is " + i;
                //string output = string.Format("Your number is {0}", i);
                string output = $"Your number is {i}"; // String interpolation is used the most frequently
                Console.WriteLine(output);
            }
        }
    }
}
