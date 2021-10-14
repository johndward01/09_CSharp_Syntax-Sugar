using System;

namespace Syntax_Sugar_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Explicit Typing
            //string firstName = "John"; // Declaring & initializing
            //int age = 29;
            //bool isOver18 = true;

            //// Inferred Typing
            //var x = "abc"; // Declaring & Initializing 
            //var y = 2324;
            //var z = false;

            //if (x == "abc" && !z)
            //{
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine();
            //}


            //var answer = (x == "abc" && !z) ? "Both of these are true" : "One of these was false";
            //Console.WriteLine(answer);

            int x = 0;
            int y = 1;

            //if (x > y)
            //{
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine();
            //}

            //var answer = (x > y) ? "x is greater" : "y is greater";
            //Console.WriteLine(answer);

            var answer1 = "0";
            var answer2 = $"{0}";

            Console.WriteLine(answer1);
            Console.WriteLine(answer2);



        }
    }
}
