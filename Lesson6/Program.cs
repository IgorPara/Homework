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

System.Console.WriteLine("Задача 1. Вывод одной строкой элементов двумерного массива: " + str); // вывод одной строкой элементов двумерного массива


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
