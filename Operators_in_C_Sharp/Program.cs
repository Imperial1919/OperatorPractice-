using System;

namespace Operators_in_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable1 = 25;
            int variable2 = 5;
            // Huh, didn't even know you could do operations inside the stirng interpolation brackets.
            Console.WriteLine($"Ok. So 25 plus 5 is {variable1 + variable2}.");
            Console.WriteLine($"Alrighty, and 25 minus 5 is {variable1 - variable2}.");
            Console.WriteLine($"Twenty-Five divided by 5 will return the amount of {variable1 / variable2}");
            Console.WriteLine($"Twenty Five Multiplied by 5 will return {variable1 * variable2}");

            string a;
            string b;


            Console.WriteLine("Ok, please tell me what you want variable a to be.");
            a = Console.ReadLine();
            Console.WriteLine("Now type in a number for variable b");
            b = Console.ReadLine();

            int integera = Convert.ToInt32(a);
            int integerb = Convert.ToInt32(b);

           

            int quotient = integera / integerb;
            int remainder = integera % integerb;

           
            Console.WriteLine($"Ok, so a divided by b will give us {quotient}, However, using the modulus operator will give us {remainder}.");




        }
    }
}
