using System;
using System.Collections.Generic;

namespace Syntax_Sugar_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------------------------------------
            //Exercise -> change the code to implement inferred typing, string interpolation, and the ternary operator

            //int answer = 4;
            //string response;

            //if (answer < 9)
            //{
            //    response = answer + "is less than nine";
            //}
            //else
            //{
            //    response = answer + "greater than or equal to nine";
            //}



            int answer = 4;

            var response = answer < 9 ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
            Console.WriteLine(response);

        }
    }
}
