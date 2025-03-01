using Calculator.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-EN");
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;
            // Зделал англоязычную глобализацию чтобы не писать числа с запятой

            double input1;
            double input2;
            double result;

            Logger logger = new Logger();
            Calculate calculate = new Calculate();

            while (true)
            {
                try
                {
                    input1 = calculate.InputNumber(1);
                    input2 = calculate.InputNumber(2);

                    result = calculate.Sum(input1, input2);

                    Console.WriteLine($"Результат сложения {result}\n");
                }
                catch (Exception)
                {
                }

                Console.ReadKey();
            }
        }
    }
}
