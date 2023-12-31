﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
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
    return Convert.ToInt32(Console.ReadLine());
}

int number = InputNum("Введите число: ");
for (int i = 1; i <= number; i++)
    {
        int num = i * i * i;
        Console.Write($"{num} ");
    }
*/

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int InputNum(string ourNum)
{
    Console.Write(ourNum);
    return Convert.ToInt32(Console.ReadLine());
}
int Power(int powNum, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
        power *= powNum;
    return power;
}
bool PowTrue(int exponent)
{
    if (exponent < 0)
    {
        Console.WriteLine("Вы ввели показатель меньше нуля.");
        return false;
    }
    return true;
}

int numPow = InputNum("Введите число: ");
int exp = InputNum("Введите степень числа: ");
if (PowTrue(exp))
    Console.WriteLine($"Число {numPow} в степени {exp} равно {Power(numPow, exp)}");
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int InputNum(string ourNum)
{
    Console.Write(ourNum);
    return Convert.ToInt32(Console.ReadLine());
}
int Sum(int number)
{
    int result = 0;
    for(int i = number; i > 0; i /= 10)
        result += i % 10;
    return result;
}
int num = InputNum("Введите число: ");
Console.WriteLine($"Сумма всех цифр в числе равна {Sum(num)}");
*/
// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int InputNum(string ourNum)
{
    Console.Write(ourNum);
    return Convert.ToInt32(Console.ReadLine());
}
int[] Print(int elem)
{
    int[] array = new int[elem];
    for(int i = 0; i < elem; i++)
        array[i] = InputNum("Введите элемент массива: ");
    return array;
}
void OutArray(int elem, int[] newArr)
{
    Console.Write("[");
    for(int i = 0; i < elem; i++)
        Console.Write($"{newArr[i]}, ");
    Console.Write("]");
}
int numElem = InputNum("Задайте колличество элементов массива: ");
int[] inArray = Print(numElem);
Console.WriteLine("Массив, введенный пользователем: ");
OutArray(numElem, inArray);
Console.WriteLine();
*/

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);

    return array;
}
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
int QuantityOfEvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    return count;
}
Console.Write("Input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(m);
WriteArray(myArray);
Console.WriteLine(QuantityOfEvenNum(myArray));
*/
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}
void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
int SumOfNegativ(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}

Console.Write("input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m, a, b);
WriteArray(myArray);
Console.WriteLine(SumOfNegativ(myArray));
*/
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateRandomArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        {
            Console.Write($"Input number in array with index {i}: ");
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
    return array;
}
void WriteArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
double DifferenceMaxMin(double[] array)
{
    double result = 0;
    double min = array[0];
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
        if(array[i] < min)
            min = array[i];
        result = max - min;
    }
    return result;
}
Console.Write("Input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArray(m);
WriteArray(myArray);
Console.WriteLine(DifferenceMaxMin(myArray));
*/

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int InputNum(string ourNum)
{
    Console.Write(ourNum);
    return Convert.ToInt32(Console.ReadLine());
}
void Counting(int m)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        if ((Convert.ToInt32(Console.ReadLine()) > 0))
            count++;
    }
    Console.WriteLine("Положительных чисел: " + count);
}
int Input = InputNum("Сколько всего цифр будете вводить? ");
Counting(Input);
*/
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
double InputNum(string ourNum)
{
    Console.Write(ourNum);
    return Convert.ToDouble(Console.ReadLine());
}
void Calculations(double k1, double k2, double b1, double b2)
{
    if (k1 - k2 == 0 && b2 -b1 == 0)
        Console.WriteLine("Прямые совпадают.");
    else if (k1 - k2 == 0 && b2 - b1 != 0)
        Console.WriteLine("Прямые параллельны.");
    else
    {
        double x = (b2 - b1) / (k1 -k2);
        double y = x * k1 + b1;
        Console.WriteLine($"Прямые пересекаются в точке с координатами ({x}; {y})");
    }
}
double K1 = InputNum("Введите k1: ");
double B1 = InputNum("Введите b1: ");
double K2 = InputNum("Введите k2: ");
double B2 = InputNum("Введите b2: ");
Calculations(K1, K2, B1, B2);
*/

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = Convert.ToDouble(random.Next(-100, 100)/10.0);
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void FindNum(int[,] array)
{
    Console.Write("Input a number of row: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of column: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int i = array.GetLength(0);
    int j = array.GetLength(1);
    if(m <= i && n <= j) Console.WriteLine($"{array[m,n]}");
    else Console.WriteLine($"There is no elements with {m} and {n} indexes");
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
FindNum(myArray);
*/
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void AverageColumns(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < array.GetLength(0); i ++) sum += array[i,j];
        double average = sum / (array.GetLength(0));
        Console.Write($"{average} ");          // is average of {j} column"
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
AverageColumns(myArray);
*/

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}
void SortLine(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(1) - 1; k ++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i,k] = array[i,k + 1];
                    array[i,k + 1]= temp;
                }   
            }
        }
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
SortLine(myArray);
Show2dArray(myArray);
*/
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}
int FindRowNumb (int[,] array)
{
    int row = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum += array[0,i];
    }
    Console.Write($"{minSum} ");
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        Console.Write($"{sum} ");
        if (minSum > sum)
        {
            minSum = sum;
            row = i;
        }
    }
    return row + 1;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine($"Строка с наименьшей суммой - {FindRowNumb(myArray)}");
*/
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}
int[,] MatrixMult(int[,] matrixA, int[,] matrixB)
{
    int rowsA = matrixA.GetLength(0);
    int columnsB = matrixB.GetLength(1);
    int[,] result = new int[rowsA, columnsB];
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < columnsB; j++)
            {
                for (int n = 0; n < matrixA.GetLength(1); n++) result[i,j] += matrixA[i,n] * matrixB[n,j];
            }
        }
    }
    return result;
}

int[,] matA = CreateRandom2dArray();
Show2dArray(matA);
int[,] matB = CreateRandom2dArray();
Show2dArray(matB);
Console.WriteLine();
int[,] newArray = MatrixMult(matA, matB);
Show2dArray(newArray);
*/
// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]} ({j},{k},{i})\t");
            }
            Console.WriteLine();
        }
    }
}
void CreateArray(int[,,] array3D)
{
    int[] temp = new int[array3D.Length];
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = new Random().Next(10, 100);
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                }
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for ( int y = 0; y < array3D.GetLength(1); y++)
        {
            for ( int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x,y,z] = temp[count];
                count++;
            }
        }
    }
}
int [,,] myArray = new int[2,2,2];
CreateArray(myArray);
PrintArray(myArray);
*/
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
void SpiralFillArray(int[,] array, int size)
{
    int value = 1;
    int i = 0;
    int j = 0;
    while (value <= size * size)
    {
        array[i,j] = value;
        if (i <= j + 1 && i + j < size - 1) j++;
        else if ( i < j && i + j >= size - 1) i++;
        else if ( i >= j && i + j > size -1) j--;
        else i--;
        value++;
    }
}
void PrintArray(int[,] array, int size)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < 10) Console.Write("0" + array[i,j] + " ");
            else Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input a number: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] myArray = new int[size,size];
SpiralFillArray(myArray, size);
PrintArray(myArray, size);
*/

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
/*
void OutputNumbers(int num)
{
    if (num > 0)
    {
        Console.Write(num + " ");
        OutputNumbers(num - 1);
    }
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
OutputNumbers(number);
*/
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
void SumNatural(int start, int end)
{
    int sum = 0;
    if (start == end) Console.WriteLine($"Сумма всех элементов в промежутке равна {start}");
    else if (start < end)
        for (int i = start; i <= end; i++) sum += i;
    else
        for (int i = end; i <= start; i++) sum += i;
    Console.WriteLine($"Сумма всех элементов в промежутке равна {sum}");
}

Console.Write("Input first number: ");
int inM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int inN = Convert.ToInt32(Console.ReadLine());
SumNatural(inM, inN);
*/
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Funct (int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Funct(m - 1, 1);
    return Funct(m - 1, Funct(m, n - 1));
}
Console.Write("Input first parameter of function: ");
int inM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second parameter of function: ");
int inN = Convert.ToInt32(Console.ReadLine());
Console.Write("Result of function " + Funct(inM, inN));
*/