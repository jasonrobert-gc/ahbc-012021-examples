using System;

namespace Day01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // single line comment.  This is my first project so I hope you like it

            /* asdf
             asdf

            multi line comment
            
             asdf
             asdf
             */

            string result = "Hello class"; // declaring and initialzing in the same statement
            // But it does not have to be so, we can declare and initialize in two SEPARATE statements
            // although, doing it in one is preferred and a best practice.
            //// string result;
            //// result = "Hello class";

            // variables can change after they are initialized
            result = "Jason is the best";
            Console.WriteLine(result);

            // But what about constants they ask?
            const string theMostTrueThing = "Jason is the best";
            // The next line will not work because constants cannot change
            // theMostTrueThing = "Jason is not the best";
            Console.WriteLine(theMostTrueThing);
        }
    }
}
