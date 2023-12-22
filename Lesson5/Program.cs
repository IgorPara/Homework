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

void MinimumElementInArray(int[] array, out int lineindex)
{
lineindex = 0;
int minimum = 0;
for (int i = 0; i < array.Length; i++)
    {
        if (minimum > array[i])
        {minimum = array[i];
        lineindex = i;
        }
    }
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

MinimumElementInArray(MinimumSumInRow(myMatrix3), out int line);
System.Console.WriteLine($"Задача 3: Строка с минимальной суммой: {line}");

// Не получилось добиться, чтобы выводился номер строки с минимальный элементом.
// Выводится значение переменной, заданное при инициализации, то есть 0.

// System.Console.WriteLine("Задача 3. Номер строки с минимальной суммой элементов: " + line);

// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца

// !!!!!!!!!!!!!!!!!!!! ref out in - модификаторы для работы со значимыми и ссылочными данными


// void FindMinNumberIndexRef(ref int number) // ref передача значения по ссылке
// {
//     number += 10;
//     // int xy = new int{1, 2}; // для возвращения двух значений в виде одномерного массива
//     // return xy;
// }

// int FindMinNumberIndexOut(out int number) // ref передача значения по ссылке
// {
//     int number = 0; // out сначала нужно объявить переменную, потом изменить
//     number += 10;
// }

// void FindMinNumberIndexIn(in int numberin) // in передача значения по ссылке
// {
//     int test = numberin; // можно ее значение присвоить другой переменной
//     System.Console.WriteLine($"numberin: {numberin}");
//     // number += 10; // Нельзя изменять переменную, она только для чтения
// }

// int numref = 0;
// FindMinNumberIndexRef(ref numref); // ref передает в функцию не значение, а ссылку на значение
// System.Console.WriteLine($"ref numref: {numref}");

// FindMinNumberIndexOut(out numout); // out извлекает из функции значение переменной, которая задается внутри функции
// System.Console.WriteLine($"out numout: {numout}");

// int numin = 0;
// FindMinNumberIndexIn(in numin); // in только для чтения, изменять нельзя
// System.Console.WriteLine($"out numin: {numin}");

void FindMinNumberIndexes(int[,] matrix22, out int miniIndex, out int minjIndex) // iIndex, jIndex для извлечения индексов
{
    miniIndex = 0; // out нужно задать значение переменных, значения которых извлекаются из функции
    minjIndex = 0;
    for (int i = 0; i < matrix22.GetLength(0); i++)
    {
        for (int j = 0; j < matrix22.GetLength(1); j++)
        {
            if (matrix22[i,j] < matrix22[miniIndex, minjIndex])
            {
                miniIndex = i; // присваиваем индекс минимального элемента
                minjIndex = j;
            }
        }
    }
}

////// ОПЕРАТОРЫ ПЕРЕХОДА
// return - прерывает фукнцию, возвращает значение
// continue - прерывает текущую операции и переходит к следующей. пропускает итерацию цикла
// break - прерывает цикл, ничего не возвращает, функция продолжает работать
// goto - создается метка m: и переход к ней goto m;

// Вариант с тернарными операторами рассмотрен в семинаре Урок 6. Массивы и строки
// https://gb.ru/lessons/383923

int[,] DeleteRowAndCol(int[,] matrixToDelete, int iMin, int jMin)
{
    int[,] newMatrix = new int[matrixToDelete.GetLength(0) - 1, matrixToDelete.GetLength(1) - 1];

    for (int i = 0, x = 0; i < matrixToDelete.GetLength(0); i++) // i, x - счетчики
    {
        if(i == iMin) continue; // пропуск строки с минимальным элементом

        for (int j = 0, y = 0; j < matrixToDelete.GetLength(1); j++) // j, y - счетчики
        {
            if(j == jMin) continue; // пропуск столбца с минимальным элементом
            newMatrix[x,y] = matrixToDelete[i,j];
            y++;
        }
        x++;
    }
    return newMatrix;
}


// ---------------------------
int[,] oldMatrix = GenerateMatrix(5, 7, -10, 10);
PrintMatrix(oldMatrix);
FindMinNumberIndexes(oldMatrix, out int iMin, out int jMin);
System.Console.WriteLine($"iMin: {iMin} jMin: {jMin}");
PrintMatrix(DeleteRowAndCol(oldMatrix, iMin, jMin));

/// ТЕРНАРНЫЕ ОПЕРАТОРЫ
// int a = 13;
// int b = 7;
// int result = a > b ? a * b : a + b; // если a > b, то умножение, если не выполняется, то сложение
// System.Console.WriteLine(result);

