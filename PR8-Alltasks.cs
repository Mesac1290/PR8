using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////// Периметр
            double height, width;
            Console.Write("Введите высоту: ");
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out height) || height < 0)
                {
                    Console.WriteLine("Ошибка: некоректроное значение!");
                    continue;
                }
                break;
            }
            Console.Write("Введите ширину: ");
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out width) || width < 0)
                {
                    Console.WriteLine("Ошибка: некоректроное значение!");
                    continue;
                }
                break;
            }
            Console.WriteLine($"Высота равна: {height}");
            Console.WriteLine($"Ширина равна: {width}");
            Console.WriteLine($"Периметр равен: {CalculatePerimeter(height, width)}");
            ////////////////////////////////////////////// Проверка строки на длину
            string text;
            int minValue;
            while (true)
            {
                Console.Write("Введите строку: ");
                text = Console.ReadLine();
                if (string.IsNullOrEmpty(text))
                {
                    Console.WriteLine("Ошибка: строка не должна быть пустой!");
                    continue;
                }
                break;

            }
            while (true)
            {
                Console.Write("Введите минимальную длину: ");
                if (!int.TryParse(Console.ReadLine(), out minValue) || minValue < 0)
                {
                    Console.WriteLine("Ошибка: некоректроное значение!");
                    continue;
                }
                break;
            }
            isStringLongEnough(text, minValue);
            //////////////////////////////////////////////// Увеличение числа с помощью ref
            int userValue;
            Console.Write("Введите число: ");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out userValue))
                {
                    Console.WriteLine("Ошибка: некоректное значение");
                    continue;
                }
                break;
            }
            int userValue2;
            Console.Write("Введите число для прибавки: ");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out userValue2) || userValue2 < 0)
                {
                    Console.WriteLine("Ошибка: некоректное значение");
                    continue;
                }
                break;

            }
            Console.Write($"Число: ");
            increaseNumber(ref userValue, userValue2);
            ////////////////////////////////////////////////// Разделение строки
            string txt;
            while (true)
            {
                Console.Write("Введите строку: ");
                txt = Console.ReadLine();
                if (string.IsNullOrEmpty(txt))
                {
                    Console.WriteLine("Ошибка, некоректное значение!");
                    continue;
                }
                break;
            }
            if (!SplitIntoWords(txt, out string firstString, out int quantityStrings))
            {
                Console.WriteLine("Ошибка, строка состоит из пробелов");
            }
            else
            {
                Console.WriteLine($"Первое число: {firstString}");
                Console.WriteLine($"Кол-во cлов: {quantityStrings} ");
            }
            ///////////////////////////////////////////////////Факторил
            int number;
            while (true)
            {
                Console.Write("Введите n значение(0 - 20): ");
                if (!int.TryParse(Console.ReadLine(), out number) || number < 0 || number > 20)
                {
                    Console.WriteLine("Ошибка: некоректроное значение!");
                    continue;
                }
                break;
            }
            double factorial = CalculateFactorial(number);
            Console.WriteLine($"Факториал: {factorial}");
        }


        static double CalculatePerimeter(double height, double width)
        {
            double perimeter = (height + width) * 2;
            return perimeter;
        }
        static void isStringLongEnough(string text, int minValue)
        {
            if (text.Length > minValue)
            {
                Console.WriteLine("Строка достаточно длинная!");
            }
            else {
                Console.WriteLine("Строка слишком короткая!");
            }
        }
        static void increaseNumber(ref int value, int value2)
        {
            Console.WriteLine(value += value2);
        }
        static bool SplitIntoWords(string txt, out string firstString, out int quantityStrings)
        {
            firstString = null;
            quantityStrings = 0;
            if (txt == null||String.IsNullOrWhiteSpace(txt))
            {
                return false;
            }
            string[] charArray = new string [txt.Length];
            charArray = txt.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            firstString = charArray[0];
            quantityStrings = charArray.Length;
            return true;
        }
        static double CalculateFactorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            double result = 1;
            for (int i = 1; i<=num;i++)
            {
                result *= i;
            }
            return result;
        }

    }
}
