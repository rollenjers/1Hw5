using System;

class Program
{
    static void Main()
    {
        // Задаем размеры массива
        int rows = 4; // Количество строк
        int cols = 4; // Количество столбцов

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

        // Выводим исходный массив на экран
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Находим позицию наименьшего элемента
        int minValue = array[0, 0];
        int minRow = 0, minCol = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] < minValue)
                {
                    minValue = array[i, j];
                    minRow = i;
                    minCol = j;
                }
            }
        }

        Console.WriteLine($"Наименьший элемент: {minValue}, позиция: [{minRow}, {minCol}]");

        // Создаем новый массив без строки и столбца с наименьшим элементом
        int[,] newArray = RemoveRowAndColumn(array, minRow, minCol);

        // Выводим новый массив на экран
        Console.WriteLine("Новый массив после удаления строки и столбца:");
        PrintArray(newArray);
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

    // Метод для удаления строки и столбца
    static int[,] RemoveRowAndColumn(int[,] array, int rowToRemove, int colToRemove)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        // Создаем новый массив с уменьшенными размерами
        int[,] newArray = new int[rows - 1, cols - 1];

        int newRow = 0;
        for (int i = 0; i < rows; i++)
        {
            if (i == rowToRemove) continue; // Пропускаем строку для удаления

            int newCol = 0;
            for (int j = 0; j < cols; j++)
            {
                if (j == colToRemove) continue; // Пропускаем столбец для удаления

                newArray[newRow, newCol] = array[i, j];
                newCol++;
            }
            newRow++;
        }

        return newArray;
    }
}