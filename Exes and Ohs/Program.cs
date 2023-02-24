using System;

namespace Exes_and_Ohs
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static bool XO(string input)
        {
            string inputs = input.ToLower();

            int countX = 0;
            int countO = 0;

            foreach (var val in inputs)
            {
                if (val == 'x')               
                    countX++;
                if (val == 'o')
                    countO++;             
            }

            return countX == countO;
        }
    }
}
