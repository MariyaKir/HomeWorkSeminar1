// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1 , min = num1;

if (max < num2)
{
    max = num2;
}
else
{
    min = num2;
    Console.WriteLine($"Max number is {max} and Min number is {min}");
}
*/
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Input first number - ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number - ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number - ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (max < num2)
    max = num2;
if (max < num3)
    max = num3;

Console.WriteLine("Max =  " + max);
*/
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num % 2) == 0)
    Console.WriteLine("Четное");
else
    Console.WriteLine("Нечетное");
*/
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;

while (count <= num)
{
    if ((count % 2) == 0)
    {
        Console.Write(count + " ");
    }
    count++;
}
*/

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int InputNum(string ourNum)
{
    Console.Write(ourNum);
    int InNum = Convert.ToInt32(Console.ReadLine());
    return InNum;
}
Repeat:
int number = InputNum("Введите трехзначное число: ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Это не трехзначное число, повторите ввод.");
    goto Repeat;
}

Console.WriteLine($"Введенное число {number}, вторая цифра числа {number / 10 % 10}.");
*/
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет).
/*
int InputNum(string ourNum)
{
    Console.Write(ourNum);
    int InNum = Convert.ToInt32(Console.ReadLine());
    return InNum;
}

bool CheckNum(int InNum)
{
    if (InNum < 100)
    {
        Console.WriteLine("Третьей цифры нет!");
        return false;
    }
    return true;
}

int ThirdDig(int inNum)
{
   while (inNum >= 1000)
   {
    inNum /= 10;
   }
   return inNum % 10;
}

int number = InputNum("Введите число: ");
if (CheckNum(number))
{
    Console.WriteLine($"В числе {number} третья цифра {ThirdDig(number)}");
}
*/
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
int InputNum(string ourNum)
{
    Console.Write(ourNum);
    int InNum = Convert.ToInt32(Console.ReadLine());
    return InNum;
}

bool WeekEnd(int numDay)
{
    if (numDay > 5)
    {
        return true;
    }
    return false;
}

Repeat:
int day = InputNum("Введите день недели: ");

if (day < 1 || day > 7)
    {
        Console.WriteLine("Это не день недели.");
        goto Repeat;
    }

if (WeekEnd(day))
{
    Console.WriteLine("Сегодня выходной!");
}
else
{
    Console.WriteLine("Сегодня рабочий день.");
}
*/

// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
int InputNum(string ourNum)
{
    Console.Write(ourNum);
    return Convert.ToInt32(Console.ReadLine());
}

bool Palindrom(int num)
{
    if (num < 10) return false;
    else
    {
        int cutNum = num;
        int rev = 0;
        while (cutNum > 0)
        {
            rev *= 10;
            rev += cutNum % 10;
            if (rev == 0) return false;
            cutNum /= 10;
        }
        if (rev != num) return false;
    }
    return true;
}

int digital = InputNum("Введите число: ");
if (Palindrom(digital)) Console.WriteLine("Это палиндром");
else Console.WriteLine("Это не палиндром");
*/
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double X = x2 - x1;
    double Y = y2 - y1;
    double Z = z2 - z1;
    return Math.Round(Math.Sqrt(X * X + Y * Y + Z * Z), 2);
}
Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Distance(x1, y1, z1, x2, y2, z2));
*/
// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
int InputNum(string ourNum)
{
    Console.Write(ourNum);
    return Convert.ToInt32(Console.ReadLine());;
}

int number = InputNum("Введите число: ");
for (int i = 1; i <= number; i++)
    {
        int num = i * i * i;
        Console.Write($"{num} ");
    }
*/
