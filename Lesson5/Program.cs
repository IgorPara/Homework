// Урок 5. Двумерные Массивы
// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {    
        System.Console.Write(arrayForPrint[i] + "\t");
        System.Console.WriteLine();
    }
}

void PrintElement(int[,] matrix, int rowToFind, int columnToFind)
{
    if (rowToFind <= matrix.GetLength(0) && columnToFind <= matrix.GetLength(1))
    {
        System.Console.WriteLine($"Искомый элемент [{rowToFind}, {columnToFind}] {matrix[rowToFind, columnToFind]}");
    }
    else System.Console.WriteLine("Такого элемента нет в массиве");
}

int[,] ChangeRows(int[,] matrix)
{
    //int[,] tempArray = new int[matrix.GetLength(0), matrix.GetLength(1)];
    int[,] tempArray = matrix;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int[] firstLine = new int[matrix.GetLength(1)]; // пришлось ввести одномерный массив для хранения первой строки двумерного
        firstLine[i] = tempArray[0, i]; 
        tempArray[0, i] = matrix[matrix.GetLength(0) - 1, i];
        // System.Console.WriteLine($"tempArray[0, {i}] {tempArray[0, i]}"); // поэлементный вывод на экран значений первой строки
        // tempArray[matrix.GetLength(0) - 1, i] = matrix[0, i]; // при такой записи значения последней строки одного массива 
        // записывались в первую строку второго массива
        // и значения первой строки обеих матриц становились одинаковыми, т.к. массив - ссылочный тип данных
        tempArray[matrix.GetLength(0) - 1, i] = firstLine[i];
        // System.Console.WriteLine($"tempArray[{matrix.GetLength(0) - 1}, {i}] {tempArray[matrix.GetLength(0) - 1, i]} ");
        // поэлементный вывод на экран значений последней строки
    }
    return tempArray;
}

int[] MinimumSumInRow(int[,] matrix)
{

int[] sumArray = new int[matrix.GetLength(0)];
for (int i = 0; i < matrix.GetLength(0); i++)
    {
    int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
    sumArray[i] = sum;
    System.Console.WriteLine($"Сумма {i + 1}й строки = {sum}");
    }
    return sumArray;
}

int MinimumElementInArray(int[] array)
{
int lineindex = 0;
int minimum = 0;
for (int i = 0; i < array.Length; i++)
    {
        if (minimum > array[i])
        {minimum = array[i];
        lineindex = i;
        }
    }
    return lineindex;
    // System.Console.WriteLine($"Номер строки с минимальной суммой: {lineindex}");
}


//**********************************************
int rows = ReadInt("Задача 1. Введите количество строк в массиве: ");
int cols = ReadInt("Задача 1. Введите количество столбцов в массиве: ");

int[,] myMatrix = GenerateMatrix(rows, cols, -10, 10);

PrintMatrix(myMatrix);

int rowFind = ReadInt("Задача 1. Введите искомую строку элемента: ");
int colFind = ReadInt("Задача 1. Введите искомый столбец элемента: ");

PrintElement(myMatrix, rowFind - 1, colFind -1);


// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int rows2 = ReadInt("Задача 2. Введите количество строк в массиве: ");
int cols2 = ReadInt("Задача 2. Введите количество столбцов в массиве: ");

int[,] myMatrix2 = GenerateMatrix(rows2, cols2, 1, 100);

PrintMatrix(myMatrix2);
int[,] changedMatrix = ChangeRows(myMatrix2);
System.Console.WriteLine("Задача 2. Новый массив с заменой строк первой на последнюю");
PrintMatrix(changedMatrix);



// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int rows3 = ReadInt("Задача 3. Введите количество строк в массиве: ");
int cols3 = ReadInt("Задача 3. Введите количество столбцов в массиве: ");
int[,] myMatrix3 = GenerateMatrix(rows3, cols3, 1, 100);

PrintMatrix(myMatrix3);

int line = MinimumElementInArray(MinimumSumInRow(myMatrix3));
System.Console.WriteLine($"Строка с минимальной суммой: {line}");

// System.Console.WriteLine("Задача 3. Номер строки с минимальной суммой элементов: " + line);

// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца
