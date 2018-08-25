using System;
using System.Linq;

namespace SecondLetterLoopProject
{
    class Program
    {
        static void Main(string[] args)
        // INPUT = RqaEzty
        // DESIRED OUTPUT = R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy
        {
            var letters = "RqaEzty";

            /* The line below is taking the string and using the string.Join() method the join the contents of the string with a - in between and 
               then using the .Select() method to take the in the char and the index of that to add the equivalent number of the same character to it and capitlizing the first and lowering the case on the rest */

            var output = string.Join("-", letters.Select((c, i) => Char.ToUpper(c) + new string(Char.ToLower(c), i)));
            Console.WriteLine(output);
            Console.ReadLine();

        }
    }
}
