using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Properties
{
    internal class Logger : ILogger
    {
        /// <summary>
        /// Сообщение об ошибке, цвет текста красный
        /// </summary>
        /// <param name="message">Выводимая строка</param>
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Сообщение информативного характера, пишется синим цветом
        /// </summary>
        /// <param name="message">Выводимая строка</param>
        public void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
