using System;

namespace ConsoleApp1
{
    internal static class Program
    {
        static int Solve(string opr)
        {
            // Complete this function
            // Complete this function

            var x = Int32.Parse(opr.Substring(0, 1));
            var y = Int32.Parse(opr.Substring(2, 1));
            var result2 = 0;
            var z = opr.Substring(1, 1);
            if (x < 0 || y > 9) return result2;
            switch (z)
            {
                case "+":
                    result2 = x + y;
                    break;
                case "-":
                    result2 = x - y;
                    break;
            }
            return result2;
        }

        static void Main()
        {
            string opr = Console.ReadLine();
            int result = Solve(opr);
            Console.WriteLine(result);


        }
    }
}

