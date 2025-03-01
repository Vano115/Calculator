using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Properties
{
    class Calculate : ISum
    {
        Logger logger = new Logger();

        /// <summary>
        /// Функция сложения
        /// </summary>
        /// <param name="a">Первое слагаемое</param>
        /// <param name="b">Второе слагаемое</param>
        /// <returns></returns>
        public double Sum(double a, double b)
        {
            logger.Info("Успешно");
            return a + b;
        }

        /// <summary>
        /// Получение значений в калькулятор
        /// </summary>
        /// <param name="num">Номер слагаемого который будет получен</param>
        /// <returns></returns>
        public double InputNumber(int num)
        {
            double value;
            Console.WriteLine($"Введите {num} слагаемое: ");

            while (double.TryParse(Console.ReadLine(), out value) == false)
            {
                logger.Error("Недопустимое значение, введите повторно");
            }

            logger.Info($"Введено {num} слагаемое {value}");

            return value;
        }

    }
}
