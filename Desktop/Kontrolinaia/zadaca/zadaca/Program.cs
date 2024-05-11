using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем начальный массив строк
        string[] initialArray = { "apple", "banana", "cat", "dog", "elephant", "fox" };

        // Создаем новый массив строк, длина которых меньше или равна 3 символам
        string[] newArray = FilterStrings(initialArray);

        // Выводим новый массив на экран
        Console.WriteLine("New array:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterStrings(string[] array)
    {
        int count = 0; // Счетчик строк, удовлетворяющих условию
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count]; // Создаем новый массив с размером, равным количеству подходящих строк
        int index = 0; // Индекс для записи в новый массив
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                result[index] = str; // Записываем подходящую строку в новый массив
                index++;
            }
        }

        return result;
    }
}
