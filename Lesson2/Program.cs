////////////////////////////
// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 ->  нет
// 161 -> да

int number = new Random().Next(1, 1000);  
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int divOne = number % 7; 
int divTwo = number % 23;  
if (divOne == 0 && divTwo == 0)
{
    System.Console.WriteLine($"{number} -> да");
}
else
{
    System.Console.WriteLine($"{number} -> нет (остатки от деления {number} % 7 - {divOne} и {number} % 23 - {divTwo})");
}
System.Console.WriteLine();

//++++++++++++++++++++++++++++++++

///////// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

int x;
int y;

System.Console.Write("Введите координату X, не равную нулю: ");
x = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату Y, не равную нулю: ");
y = Convert.ToInt32(Console.ReadLine());
if (x == 0 || y == 0)
System.Console.WriteLine("Ни одна из координат не должа быть равна 0");
if (x > 0 && y > 0)
System.Console.WriteLine("Точка находится в 1-й четверти");
if (x < 0 && y > 0)
System.Console.WriteLine("Точка находится во 2-й четверти");
if (x < 0 && y < 0)
System.Console.WriteLine("Точка находится в 3-й четверти");
if (x > 0 && y < 0)
System.Console.WriteLine("Точка находится в 4-й четверти");

//++++++++++++++++++++++++++++++++

// // Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
int number = new Random().Next(10, 100); // Правая граница должна быть на 1 больше диапазона. 
System.Console.WriteLine(number);
int first = number / 10;
int second = number % 10;
if (first > second)
{
    System.Console.WriteLine($"Первое число {first} больше второго {second}");
}
else if (first < second)
{
    System.Console.WriteLine($"Второе число {second} больше первого {first}");
}
else 
{
System.Console.WriteLine($"Второе число {second} равно первому {first}");
}

//++++++++++++++++++++++++++++++++

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
int number = new Random().Next(1, 121); // Правая граница должна быть на 1 больше диапазона. 
System.Console.WriteLine(number);
if (number >= 1 && number < 10)
System.Console.WriteLine($"Однозначное число: {number}");
if (number >= 10 && number < 100)
System.Console.WriteLine($"Двузначное число: {number/10}, {number%10}");
if (number >= 100 && number < 1000)
System.Console.WriteLine($"Трехзначное число: {number/100}, {number%100/10}, {number%10}");


// Пример вы найдете в конце презентации к семинару.

//++++++++++++++++++++++++++++++++



///////////////////////////////////
// Принимает 2 числа и проверяет является ли одно из них квадратом другого.
// 25, 5 ->  да
// 8, 9 -> нет
// System.Console.Write("Введите первое число: ");
// int numberOne = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число: ");
// int numberTwo = Convert.ToInt32(Console.ReadLine());

// int resultOne = numberOne * numberOne; 
// int resultTwo = numberTwo * numberTwo;  

// if (resultOne == numberTwo || resultTwo == numberOne)
// {
//     System.Console.WriteLine($"{numberOne}, {numberTwo} -> да");
// }
// else
// {
//     System.Console.WriteLine($"{numberOne}, {numberTwo} -> нет");
// }
// System.Console.WriteLine();


//////////////////////
// Получает 2 числа, определяет кратно ли второе число первому. Если не кратно, выводит остаток от деления.
// 16, 4 -> кратно
// 34, 5 -> не кратно, остаток 4
// int numberOne = new Random().Next(1, 100);  
// int numberTwo = new Random().Next(1, 10);  

// int result = numberOne % numberTwo;
// int division = numberOne / numberTwo;
// if (result == 0)
// {
//     System.Console.WriteLine($"{numberOne}, {numberTwo} -> кратно");
// }
// else
// {
//     System.Console.WriteLine($"{numberOne}, {numberTwo} -> не кратно, остаток {result} ({numberOne} / {numberTwo} = {division})");
// }
// System.Console.WriteLine();





////////////////////////
// Первоеолучает трехзначное число, удаляет вторую цифру, выводит двухзначное число.
// int number = new Random().Next(1000, 10000); // Правая граница должна быть на 1 больше диапазона. 
// int leftDigit = number / 100;
// int rightDigit = number % 10;
// if (number > 99 && number <1000)
// {
//     System.Console.WriteLine($"{number} -> {leftDigit}{rightDigit}");
// }
// else
// {
//         System.Console.WriteLine($"{number} -> Не трёхзначное число");
// }
// System.Console.WriteLine();




//////////////////////////
// Вывести случайное число от 10 до 99. Определить большее из них.
// int number = new Random().Next(10, 100); // Правая граница должна быть на 1 больше диапазона. 
// int leftDigit = number / 10;
// int rightDigit = number % 10;
// if (leftDigit > rightDigit)
// {
//     System.Console.WriteLine($"{number} -> {leftDigit}");
// }
// else
// {
//         System.Console.WriteLine($"{number} -> {rightDigit}");
// }
// System.Console.WriteLine();

