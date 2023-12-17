// Урок 5. Двумерные Массивы
// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int ReadInt (string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < Get.Length(0); i++)
    {
        for (int j = 0; j < Get.Length(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        
    }
    System.Console.WriteLine();
}

int[] GenerateArray(int size, int leftRange, int rightRange) 
{
    int[] tempArray = new int[size];
    Random rand = new Random();
        for (int j = 0; j < size; j++)
        {
            tempArray[j] = rand.Next(leftRange, rightRange+1);
        }
        return tempArray;
}

// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца
