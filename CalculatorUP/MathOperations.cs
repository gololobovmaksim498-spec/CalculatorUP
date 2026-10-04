namespace CalculatorUP
{
    class MathOperations
    {

        // 0 - счёт процентов
        public double PercentOfNumber(double number, double percent)
        {
            return number * percent / 100;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public long Factorial(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }

        // 10 - остаток от деления
        public int Modulo(int a, int b)
        {
            return a % b;
        }

        // 10 - целочисленное деление
        public int IntegerDivide(int a, int b)
        {
            return a / b;
        }

        // 11 - обратное процентам
        public double InversePercent(double percent, double total)
        {
            return total * 100 / percent;
        }

    }
}