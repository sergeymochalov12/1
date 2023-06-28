// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void PrintArray(int[] arrayForPrint)// метод для вывода массива на экран
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

int[] EnterArray(string text)// фунция для заливки массива
{
    System.Console.WriteLine(text);
    int[] tempArray = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);// ввод одной строкой
    return tempArray;
}

int FindPositiv(int[] inputArray)// функция поиска положительных элементов
{
    int flag = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i]>0)
        {
            flag = flag +1;
        }
    }
    return flag;
}
int[] array = EnterArray("Введите числа :"); // задаем массив
PrintArray(array);// выводим массив
FindPositiv(array);
System.Console.WriteLine($"Пользователь ввел {FindPositiv(array)} чисел больше 0");
