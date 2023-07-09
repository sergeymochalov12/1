// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//Генерация массива
int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    var rand = new Random();
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

//Печать двумерного массива
void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
//Ввод данных
int[] ReadInt(string text)
{
    System.Console.Write(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse); ;
}


//поиск строки с минимальной суммой
int FindMinSum(int[,] matrix1)
{
    int[] array = new int[matrix1.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++) // считаем сумму строк и заполняем этими значениями массив array[]
    {
        sum = matrix1[i, 0];
        for (int j = 1; j < matrix1.GetLength(1); j++)
        {
            sum = sum + matrix1[i, j];
        }
        array[i] = sum;
      
    }
    int min = array[0];
    int imin = 0;
    
    for (int k = 1; k < array.Length; k++)// поиск минимального элемента из массива array[]
    {
        if (min > array[k])
        {
            min = array[k];
            imin = k;
        }
    }
    return imin;

}


// Основной код
int[] sizeA = ReadInt("Задайте количество строк и столбцов массива через пробел: ");
int[,] matrix1 = FillMatrix(sizeA[0], sizeA[1], 0, 9);
PrintMatrix(matrix1);
System.Console.WriteLine($"Строка с минимальной суммой элементов {FindMinSum(matrix1)}");

