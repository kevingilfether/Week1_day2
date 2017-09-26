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

            // Operator Time ( +, -, <, >, etc)
            // ARITHMETIC OPERATORS
            // + adds operands
            // - subtracts the second operand from the first
            // * multiplies
            // / divides the dividend by the divisor (first operand by second operand)
            // % - modulus, returns remainder of whole number division
            // ++ increments operator by 1, and is usually used for ints
            // -- decrements value by one

            // RELATIONAL OPERATORS
            // == Checks if the values of two operands are equal
                // and returns bool true in case they are
            // != Checks if two things are not equal
                // if they are not equal, returns bool true
            // > Checks if left operand is greater than the right operand, returns true if so
            // < Checks if right operand is greater than the left operand, returns true if so
            // >= Greater than or equal to
            // <= Less than or equal to

        }
    }
}
