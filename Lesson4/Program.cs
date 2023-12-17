// Урок 4. Функции
// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


string ReadUserInput()
{
    while (true)
    {
    System.Console.Write("Введите целое число (завершит программу ввод q или если сумма всех цифр числа четная): ");
    string userInput = System.Console.ReadLine()!;
    if (userInput == "q") return userInput;
    int countEven = 0;
    foreach (char symbol in userInput)
    {
        countEven = countEven + Convert.ToInt32(symbol);
    }
    if (countEven % 2 == 0) return userInput;
    }
}

ReadUserInput();

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CountEvenNumbers(int[] array)
{
int countEven =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) countEven++;
    }
    System.Console.WriteLine($"Количество четных чисел в массиве: {countEven}");
    return array;
}

int ReadInt (string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
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

int size = ReadInt("Введите размер массива: ");
int[] myArray = GenerateArray(size, 100, 1000);
PrintArray(myArray);
CountEvenNumbers(myArray); // для следующей задачи эта строка сделана комментарием, для задачи 2 ее комментарий нужно убрать



// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
int size2 = ReadInt("Введите размер массива: ");
int[] myArray2 = GenerateArray(size2, 1, 50);
PrintArray(myArray2);
int last = size2 - 1;
int temp = 0;
for (int i = 0; i < myArray2.Length / 2; i++)
{
    temp = myArray2[i];
    myArray2[i] = myArray2[last];
    myArray2[last] = temp;
    last--;
}
PrintArray(myArray2);

// ***********************************************************


