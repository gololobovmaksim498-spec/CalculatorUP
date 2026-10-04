using System;
namespace CalculatorUP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите режим ('mass' - массив, Enter - примеры): ");
            string mode = Console.ReadLine();

            if (mode == "mass")
                ArrayMode();
            else
                MathMode();

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
        // ------- Режим примеров -------
        static void MathMode()
        {
            Console.WriteLine("0-проценты, 1-умнож, 2-деление, 3-вычит, 4-слож, 9-факториал, 10-остаток, 11-обратное");
            Console.Write("Действие: ");
            int action = int.Parse(Console.ReadLine());

            MathOperations math = new MathOperations();

            if (action == 0)
            {
                Console.Write("Число: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Процент: ");
                double p = double.Parse(Console.ReadLine());
                Console.WriteLine("Результат: " + math.PercentOfNumber(a, p));
            }
            else if (action == 1)
            {
                Console.Write("a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Результат: " + math.Multiply(a, b));
            }
            else if (action == 2)
            {
                Console.Write("a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Результат: " + math.Divide(a, b));
            }
            else if (action == 3)
            {
                Console.Write("a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Результат: " + math.Subtract(a, b));
            }
            else if (action == 4)
            {
                Console.Write("a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Результат: " + math.Add(a, b));
            }
            else if (action == 9)
            {
                Console.Write("Число: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Результат: " + math.Factorial(n));
            }
            else if (action == 10)
            {
                Console.Write("a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Остаток: " + math.Modulo(a, b));
                Console.WriteLine("Целое: " + math.IntegerDivide(a, b));
            }
            else if (action == 11)
            {
                Console.Write("Процент: ");
                double p = double.Parse(Console.ReadLine());
                Console.Write("Итог: ");
                double total = double.Parse(Console.ReadLine());
                Console.WriteLine("Результат: " + math.InversePercent(p, total));
            }
        }

        // ------- Режим массива -------
        static void ArrayMode()
        {
            bool go = true;

            while (go)
            {
                Console.WriteLine("5-сумма, 6-вывод, 7-максимум, 8-минимум");
                Console.Write("Действие: ");
                int action = int.Parse(Console.ReadLine());

                Console.Write("Размер массива: ");
                int size = int.Parse(Console.ReadLine());

                int[] array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write("array[" + i + "] = ");
                    array[i] = int.Parse(Console.ReadLine());
                }

                ArrayOperations ops = new ArrayOperations(array);

                if (action == 5)
                    Console.WriteLine("Сумма: " + ops.Sum());
                else if (action == 6)
                    Console.WriteLine("Массив: " + ops.Show());
                else if (action == 7)
                    Console.WriteLine("Максимум: " + ops.Max());
                else if (action == 8)
                    Console.WriteLine("Минимум: " + ops.Min());

                Console.Write("Продолжить? (Y/yes): ");
                string answer = Console.ReadLine();
                if (answer != "Y" && answer != "yes")
                    go = false;
            }
        }
    }
}