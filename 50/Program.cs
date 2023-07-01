// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)// заливает массив случайными целыми числами
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();
    //var rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return tempMatrix;
}

int ReadInt(string text)// считывает параметр

{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintMatrix(int[,] matrixFotPrint)// выводит на экран массив
{
    for (int i = 0; i < matrixFotPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFotPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixFotPrint[i, j] + "\t");
            //Console.Write(String.Format("{0,5:f1}", matrixFotPrint[i,j]));
        }
        System.Console.WriteLine();
    }
}
int[] EnterElemenPosition(string text)// фунция записи позиции элемента
{
    System.Console.WriteLine(text);
    int[] tempArray = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);// ввод одной строкой
    return tempArray;
}
void Result(int[,] matrix, int[] pos2)// выводит на экран результат поиска
{
    if (pos2[0] > matrix.GetLength(0) || pos2[1] > matrix.GetLength(1))
    {
        System.Console.WriteLine($"Элемента с позицией [{pos2[0]}, {pos2[1]}] в массиве нет");
    }
    else
    {
        System.Console.WriteLine($"Элемент с позицией [{pos2[0]}, {pos2[1]}] = {matrix[pos2[0], pos2[1]]}");
    }
}


// ------------------------------ОСНОВНОЙ КОД-------------------------------------------

System.Console.WriteLine("Задайте двумерный массив");
int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 100);
System.Console.WriteLine();
PrintMatrix(matrix);
int[] position = EnterElemenPosition("Введите позиции элемента (через пробел): ");
Result (matrix, position);