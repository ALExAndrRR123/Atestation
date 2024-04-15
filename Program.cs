
// 1 Задача
/*
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение M:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        int n = int.Parse(Console.ReadLine());

        PrintNaturalNumbersInRange(m, n);
    }

    static void PrintNaturalNumbersInRange(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNaturalNumbersInRange(m + 1, n);
        }
    }
}
*/
// 2 Задача
/*
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение m:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение n:");
        int n = int.Parse(Console.ReadLine());

        int result = AckermannFunction(m, n);
        Console.WriteLine($"Значение функции Аккермана для m={m} и n={n} равно {result}");
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (m > 0 && n == 0)
            return AckermannFunction(m - 1, 1);
        else
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}
*/ 
// 3 Задача
class Program
{
    static void Main(string[] args)
    {
        // Произвольный массив
        int[] array = { 1, 45, 76, 41, 2 };

        Console.WriteLine("Элементы массива, начиная с конца:");
        PrintArrayReverse(array, array.Length - 1);
    }

    static void PrintArrayReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]);
            PrintArrayReverse(array, index - 1);
        }
    }
}
