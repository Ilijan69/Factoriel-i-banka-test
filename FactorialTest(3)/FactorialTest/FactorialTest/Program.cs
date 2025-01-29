using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialTest
{
    public class ExtendedCalculator
    {
        public long Factorial(int n)
        {
            long result = 1;

            for (int i = 1; i <= n; i++)
            {

                result = result * i;

            }
            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
