using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int sum= num1 + num2;
            int product = num1 * num2;
            int difference = num1 - num2;
            double quotation = (double)num1 / num2;
            Console.WriteLine($"Sum = {sum}\nDifference = {difference}\nProduct = {product}\nQuotation = {quotation}");
        }
    }
}
