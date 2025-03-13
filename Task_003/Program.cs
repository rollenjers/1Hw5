using System;

class Program
{
    static void Main()
    {
        // Задаем размеры массива
        int rows = 4; // Количество строк
        int cols = 3; // Количество столбцов

        // Создаем двумерный массив и заполняем его случайными числами
        int[,] array = new int[rows, cols];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = random.Next(1, 101); // Случайные числа от 1 до 100
            }
        }

        // Выводим массив на экран
        Console.WriteLine("Двумерный массив:");
        PrintArray(array);

        // Находим строку с наименьшей суммой элементов
        int minSumRowIndex = FindRowWithMinSum(array);

        // Выводим результат
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex + 1}");
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

    // Метод для нахождения строки с наименьшей суммой элементов
    static int FindRowWithMinSum(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        int minSum = int.MaxValue; // Начальное значение для минимальной суммы
        int minSumRowIndex = 0; // Индекс строки с минимальной суммой

        // Перебираем все строки
        for (int i = 0; i < rowCount; i++)
        {
            int rowSum = 0; // Сумма элементов текущей строки

            // Считаем сумму элементов в текущей строке
            for (int j = 0; j < colCount; j++)
            {
                rowSum += array[i, j];
            }

            // Если сумма текущей строки меньше минимальной, обновляем минимальную сумму и индекс
            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRowIndex = i;
            }
        }

        return minSumRowIndex;
    }
}