// Урок 3. Массивы
// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] GenerateArray(int size, int leftRange, int rightRange) // размер массива, левое и правое крайние значения
{
    int[] tempArray = new int[size];
    Random rand = new Random();
        for (int j = 0; j < size; j++)
        {
            tempArray[j] = rand.Next(leftRange, rightRange+1);
        }
        return tempArray;
}

void PrintArray(int[] array)
{ 
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

// int ReadInt (string text) 
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }


// Код выполнения
int size = 10; // ReadInt("Введите размер массива: "); // Задача определяет size == 10
int[] myArray = GenerateArray(size, 1, 100);
PrintArray(myArray);
int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
        if (myArray[i] >= 20 && myArray[i] <=90)
    {
        count++;
    }
}
    System.Console.WriteLine($"Количество элементов массива от 20 до 90: {count}");

// Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.
// В этой задаче используется код задачи 1 выше.

int countEven = 0;
for (int i = 0; i < myArray.Length; i++)
{
        if (myArray[i] % 2 == 0)
    {
        countEven++;
    }
}
    System.Console.WriteLine($"Количество чётных чисел в массиве: {countEven}");

// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементами массива.

double[] array = new double[5];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 2);
    }
System.Console.WriteLine("[" + string.Join(", ", array) + "]");
double max = array[0];
double min = array[0];
for (int j = 0; j < array.Length; j++)
{
    if (max < array[j])
        max = array[j];
    if (min > array[j])
        min = array[j];
}
System.Console.WriteLine($"Максимальный элемент массива: {max}");
System.Console.WriteLine($"Минимальный элемент массива: {min}");
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {max - min}");