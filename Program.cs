using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();

        // Завдання 1: Формування колекції з N випадкових чисел [-5;5] та видалення максимальних
        Console.WriteLine("Завдання 1:");
        List<int> collection1 = GenerateRandomList(-5, 5, 10);
        Console.WriteLine("Початкова колекція: " + string.Join(", ", collection1));

        int maxValue = collection1.Max();
        collection1.RemoveAll(x => x == maxValue);
        Console.WriteLine("Колекція після видалення максимальних: " + string.Join(", ", collection1));

        // Завдання 2: Формування колекції з N випадкових чисел [5;50] та вставка -1 перед останнім максимальним
        Console.WriteLine("\nЗавдання 2:");
        List<int> collection2 = GenerateRandomList(5, 50, 10);
        Console.WriteLine("Початкова колекція: " + string.Join(", ", collection2));

        int lastMaxIndex = collection2.LastIndexOf(collection2.Max());
        collection2.Insert(lastMaxIndex, -1);
        Console.WriteLine("Колекція після вставки -1: " + string.Join(", ", collection2));

        // Завдання 3: Формування двох колекцій та отримання третьої з мінімальних елементів
        Console.WriteLine("\nЗавдання 3:");
        List<int> collection3 = GenerateRandomList(1, 10, 10);
        List<int> collection4 = GenerateRandomList(1, 10, 10);

        Console.WriteLine("Колекція 1: " + string.Join(", ", collection3));
        Console.WriteLine("Колекція 2: " + string.Join(", ", collection4));

        List<int> collection5 = new List<int>();
        for (int i = 0; i < collection3.Count; i++)
        {
            collection5.Add(Math.Min(collection3[i], collection4[i]));
        }
        Console.WriteLine("Колекція з мінімальних елементів: " + string.Join(", ", collection5));
    }

    // Метод для генерації колекції випадкових чисел
    static List<int> GenerateRandomList(int minValue, int maxValue, int count)
    {
        Random rand = new Random();
        List<int> randomList = new List<int>();
        for (int i = 0; i < count; i++)
        {
            randomList.Add(rand.Next(minValue, maxValue + 1));
        }
        return randomList;
    }
}

