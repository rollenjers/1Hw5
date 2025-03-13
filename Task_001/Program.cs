using System;

class Program
{
    static void Main()
    {
        // Создаем двумерный массив (пример)
        int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Выводим массив на экран для наглядности
        Console.WriteLine("Двумерный массив:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Вводим позиции элемента
        Console.Write("Введите индекс строки: ");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите индекс столбца: ");
        int col = Convert.ToInt32(Console.ReadLine());

        // Проверяем, существует ли элемент с такими индексами
        if (row >= 0 && row < array.GetLength(0) && col >= 0 && col < array.GetLength(1))
        {
            // Если элемент существует, выводим его значение
            Console.WriteLine("Значение элемента: " + array[row, col]);
        }
        else
        {
            // Если элемент не существует, выводим сообщение
            Console.WriteLine("Элемента с такими индексами не существует.");
        }
    }
}