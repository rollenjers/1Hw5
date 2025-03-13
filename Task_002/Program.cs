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

        // Выводим исходный массив на экран
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Меняем местами первую и последнюю строки
        SwapFirstAndLastRows(array);

        // Выводим измененный массив на экран
        Console.WriteLine("Массив после замены строк:");
        PrintArray(array);
    }

    // Метод для вывода двумерного массива на экран
    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Метод для замены первой и последней строки массива
    static void SwapFirstAndLastRows(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        // Проверяем, что массив имеет более одной строки
        if (rowCount < 2)
        {
            Console.WriteLine("Массив слишком мал для замены строк.");
            return;
        }

        // Меняем местами первую и последнюю строки
        for (int j = 0; j < colCount; j++)
        {
            int temp = array[0, j];
            array[0, j] = array[rowCount - 1, j];
            array[rowCount - 1, j] = temp;
        }
    }
}
