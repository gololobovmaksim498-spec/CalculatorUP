namespace CalculatorUP
{
    class ArrayOperations
    {
        private int[] array;

        public ArrayOperations(int[] array)
        {
            array = array;
        }

        // 5 - сумма
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            return sum;
        }

        // 6 - вывод массива
        public string Show()
        {
            string result = "[ ";
            for (int i = 0; i < array.Length; i++)
                result += array[i] + " ";
            result += "]";
            return result;
        }

        // 7 - максимум
        public int Max()
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
                if (array[i] > max) max = array[i];
            return max;
        }

        // 8 - минимум
        public int Min()
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
                if (array[i] < min) min = array[i];
            return min;
        }
    }
}