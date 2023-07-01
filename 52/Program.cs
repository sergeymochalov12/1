// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            System.Console.Write($"{matrixFotPrint[i, j]}" + "    \t");
            //Console.Write(String.Format("{0,5:f1}", matrixFotPrint[i,j]));
        }
        System.Console.WriteLine();
    }
}
void Result (int[,] matrix2, int SIZE)// выводит на экран результат поиска среднего арифметического каждого столбца
{
double[] pos2 = new double [SIZE];
double sum = 0;
    
    for (int i = 0; i < matrix2.GetLength(1); i++)
    {
        sum = 0;
    
        for (int j = 0; j < matrix2.GetLength(0); j++)
        {
            sum = sum + matrix2[j, i];
            //System.Console.Write($" {sum}");
        }

        pos2[i] = Math.Round (sum / matrix2.GetLength(0), 1);
        System.Console.Write ($"{pos2[i]}" +"    \t");    
    }

}
// ------------------------------ОСНОВНОЙ КОД-------------------------------------------

System.Console.WriteLine("Задайте двумерный массив из целых чисел");
int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 10);// 0..10 здесь интервал случайного числа
System.Console.WriteLine();
PrintMatrix(matrix);
int SIZE = matrix.GetLength(1);
System.Console.WriteLine("Среднее арифметическое каждого столбца ");
Result (matrix, SIZE);