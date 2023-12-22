// Урок 7. Рекурсия
// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

int ReadInt (string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(System.Console.ReadLine());
}

void OutputMN(int m, int n)
{
    if (n < m) return;
    {
        OutputMN(m, n - 1);
        System.Console.Write(n + " ");
    }
}

//-----------------------

int numberm = ReadInt("Урок 7. Задача 1: Введите меньшее число M: "); // ввод первого числа

int numbern = ReadInt("Урок 7. Задача 1: Введите большее число N: "); // ввод второго числа

 OutputMN(numberm, numbern);
System.Console.WriteLine();

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// функция Аккермана
int Akkerman (int n, int m)
{
  if (n == 0)
    return m + 1; 
  else
    if ((n != 0) && (m == 0))
      return Akkerman (n - 1, 1);
    else
      return Akkerman (n - 1, Akkerman(n, m - 1));
}

//-----------------------
System.Console.WriteLine();

int n = ReadInt("Урок 7. Задача 2: Введите неотрицательное число n: "); // ввод первого числа

int m = ReadInt("Урок 7. Задача 2: Введите неотрицательное число m: "); // ввод второго числа

 System.Console.WriteLine(Akkerman(n, m));


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }
    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.Write(arrayForPrint[i] + "\t");
    }
}


void print(int[] array, int first = 0)
{
    if(first != array.Length) {
        print(array, first + 1);
        Console.Write($"{array[first]} ");
    }
}
        

//----------------

int size = ReadInt("Задача 3. Введите размер массива: ");
int [] array = GenerateArray(size, -10, 10);

PrintArray(array);
System.Console.WriteLine();

print(array);
System.Console.WriteLine();



