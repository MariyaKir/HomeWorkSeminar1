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