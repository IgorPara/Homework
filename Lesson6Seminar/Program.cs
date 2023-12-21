// Урок 6. Массивы и строки
// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

char[,] charsArray = new char[,] 
{
    {'a', 'b', 'c', 'd'},
    {'e', 'f', 'g', 'h'}
};

string str = new string("");

for (int i = 0; i < charsArray.GetLength(0); i++)
{
    for (int j = 0; j < charsArray.GetLength(1); j++)
    {
        str += charsArray[i,j];
    }
}

string str2 = string.Join("", charsArray); // попытка присвоить типу string тип char
System.Console.WriteLine(str2); // проверка вывода после присвоения типу string тип char
System.Console.WriteLine(str); // вывод одной строкой элементов двумерного массива

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string smallAndBigLetters = new string("adGEghRdE");
string allBigLetters    = new string("QWERTYUIOPASDFGHJKLZXCVBNM");
string allSmallLetters  = new string("qwertyuiopasdfghjklzxcvbnm");

System.Console.WriteLine("Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах: ");
string? stringOfVariousLetters = System.Console.ReadLine(); // ? на случай пустой строки

char[] arrayOfSmallLetters = new char[stringOfVariousLetters!.Length]; // массив, в который будут записаны только малые буквы

for (int i = 0; i < stringOfVariousLetters!.Length; i++) // ! на случай пустой строки
{
    for (int j = 0; j < allBigLetters!.Length; j++)
    {
        if (stringOfVariousLetters[i] == allBigLetters[j]) 
        {
            arrayOfSmallLetters[i] = allSmallLetters[j];
            break;
        }
        if (stringOfVariousLetters[i] == allSmallLetters[j])
        {
            arrayOfSmallLetters[i] = allSmallLetters[j];
            break;
        }
    }
}

System.Console.WriteLine("Задача 2: Строка только из малых букв: " + string.Join("", arrayOfSmallLetters));

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

System.Console.WriteLine("Задача 3: Задайте строку символов. Будет выполнена проверка на палиндром: ");
string? stringPalindromeCheck = System.Console.ReadLine(); // ? на случай пустой строки

int counting = 0;
int downsize = stringPalindromeCheck!.Length - 1;
for (int i = 0; i < stringPalindromeCheck!.Length / 2; i++) // ! на случай пустой строки
{
        if (stringPalindromeCheck[i] == stringPalindromeCheck[downsize]) 
        {
            counting++;
            downsize--;
        }
}

if (counting == stringPalindromeCheck!.Length / 2)
{
    System.Console.WriteLine("Задача 3: Строка является палиндромом!");
}
else
{
    System.Console.WriteLine("Задача 3: Строка НЕ является палиндромом!");
}


// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

System.Console.WriteLine("Задача 4: Введите слова, разделенные пробелом. Они будут записаны в обратном порядке.");
string? stringWordsReverse = System.Console.ReadLine(); // ? на случай пустой строки
string spacebar = " ";
int numberOfSpaces = 0;
// считаем пробелы, чтобы узнать количество слов
for (int i = 0; i < stringWordsReverse!.Length; i++) // ! на случай пустой строки
{
        if (stringWordsReverse[i] == spacebar) 
        {
            numberOfSpaces++;
        }
}
for (int j = 0; j < length; j++)
{
    
}



////////////////////////////////////////////////////////////////////
// ЗАДАЧИ НА СЕМИНАРЕ

// Задание 1. Совместная работа
// Семинар 6. Массивы и строки
// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”


char[] chars = new char[] {'a', 'b', 'c', 'd',};
// Первый способ
string str3 = new string(chars);
System.Console.WriteLine("1:" + str3);

// Второй способ
string str4 = string.Join("", chars);
System.Console.WriteLine("2:" + str4);

// Третий способ
string str5 = string.Concat<char>(chars);
System.Console.WriteLine("3:" + str5);


// Четвёртый способ
string str6 = new string("");

for (int i = 0; i < chars.Length; i++)
{
    str6 += chars[i];
}
System.Console.WriteLine("4:" + str6);


// Задание 2. Работа в сессионных залах
// Семинар 6. Массивы и строки
// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

string strHello = "Hello!";

string? strInput = Console.ReadLine(); // ? снимает предупреждения в случае пустой строки. 
// Нужен ! при обращении к длине массива strInput!.Length

char[] charArrayFromString = strHello.ToCharArray();
char[] charArrayUserInput = strInput.ToCharArray();

char[] charsInput = new char[strInput!.Length]; // ! значит, что при пустой строке не будет вополнен метод Length

for (int i = 0; i < strInput.Length; i++)
{
    charsInput[i] = strInput[i];
}


char[] charsArray2 = new char[strHello.Length];

for (int i = 0; i < strHello.Length; i++)
{
    charsArray2[i] = strHello[i];
}

System.Console.WriteLine("charArrayFromString: " + string.Join(", ", charArrayFromString));
System.Console.WriteLine("charsArray2: " + string.Join(", ", charsArray2));
System.Console.WriteLine("charArrayUserInput: " + string.Join(" ", charArrayUserInput));
System.Console.WriteLine("charsInput: " + string.Join("-", charsInput));

// записать цифру посередине строки в переменную типа int
string strDigit = "123"; // строка имеет тип char, который напрямую в int не преобразуется, нужно привести сначала в тип string
// Convert.ToString(strDigit[1]);
int numbertwo = Convert.ToInt32(strDigit[1]); // якобы присвоение переменной значения 2го символа строки. отсчёт начинается с 0
System.Console.WriteLine("number: " + numbertwo); // все время выводится 50 
int numberthree = Convert.ToInt32(Convert.ToString(strDigit[1])); // нужно сначала привести в тип string
System.Console.WriteLine("converted number: " + numberthree);

// Задание 3. Совместная работа
// Семинар 6. Массивы и строки
// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1
System.Console.WriteLine("Задание 3. Введите строки из латинских букв: ");
string? stringOfLetters = System.Console.ReadLine(); // ? на случай пустой строки
char[] vouvels = {'e', 'y', 'u', 'i', 'o', 'a'};
int count = 0;
for (int i = 0; i < stringOfLetters!.Length; i++) // ! на случай пустой строки
{
    for (int j = 0; j < vouvels!.Length; j++)
    {
        if (stringOfLetters[i] == vouvels[j]) 
        {
            count++;
            break;
        }
    }
}
System.Console.WriteLine("Задание 3. Количество гласных в строке: " + count);