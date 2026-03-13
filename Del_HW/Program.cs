using System.Runtime.CompilerServices;

namespace Del_HW
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            //Первая часть
            ArrayDel[] del = { ArrayIsEven, ArrayIsOdd, ArrayPrime, ArrayFibonacci };

            int[] arr = { 1221, 2, 3, 4, 5, 8, 6 };
            for (int i = 0; i < 4; i++)
            {
                del[i].Invoke(arr);
            }
            Console.WriteLine();
            //Вторая часть

            IntCheck isFibo = MyIsFibonacci;
            int num = 21;

            if (isFibo(num))
                Console.WriteLine("Число Фибоначчи");
            else
                Console.WriteLine("Не число Фибоначчи");

            // Делегаты для строк
            StrCheck wordCount = WordCount;
            StrCheck lastWordLen = LastWordLength;

            string str = "Hello world from C sharp";

            Console.WriteLine("Count: " + wordCount(str));
            Console.WriteLine("Length of last word: " + lastWordLen(str));


        }
        //Первая часть
        delegate void ArrayDel(int[] array);
        public static void ArrayIsEven(int[] array)
        {
            foreach (int i in array)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public static void ArrayIsOdd(int[] array)
        {
            foreach (int i in array)
            {
                if (i % 2 != 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public static void ArrayNutural(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                
            }
        }
        public static void ArrayPrime(int[] array)
        {
            foreach (int num in array)
            {
                if (IsPrime(num))
                    Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        public static void ArrayFibonacci(int[] array)
        {
            foreach (int num in array)
            {
                if (IsFibonacci(num))
                    Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        public static bool IsPrime(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
        public static bool IsFibonacci(int n)
        {
            int a = 0;
            int b = 1;

            while (b < n)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }

            return n == a || n == b;
        }

        //Вторая часть
        delegate bool IntCheck(int n);
        delegate int StrCheck(string text);
        public static bool MyIsFibonacci(this int n)
        {
            int a = 0;
            int b = 1;

            while (b < n)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }

            return n == a || n == b;
        }
        public static int WordCount(this string text)
        {
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        public static int LastWordLength(this string text)
        {
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return words[^1].Length;
        }


    }
}
