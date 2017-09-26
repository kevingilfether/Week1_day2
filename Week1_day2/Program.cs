using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //What data types have we talked about so far?
            // An int is a whole number (no decimals)
            // A string is a collection of characters

            char firstInitial = 'k';
            // A char is in '' and is a single character, letter, or symbols

            bool isTired = false;
            // A bool (or Boolean) is true or false

            // Other number data types
            float number = 200.02938575773890108934840577283021030f;
            decimal partialNum = 200.02938575773890108934840577283021030m;
            double someNumber = 200.02938575773890108934840577283021030d;
            // floats are "small," doubles are middle, and decimals are very large in terms of representation after the decimals

            Console.WriteLine(number);
            Console.WriteLine(partialNum);
            Console.WriteLine(someNumber);
        }
    }
}
