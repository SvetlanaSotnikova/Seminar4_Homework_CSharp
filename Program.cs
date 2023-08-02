// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)

void GetDegree(int A, int B)
{
    int res = 1;
    for (int i = 0; i < B; i++)
    {
        res *= A;
    }
    Console.WriteLine($"{A}, {B} -> {res}");
}
Console.Write("Your base num: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Your degree num: ");
int B = Convert.ToInt32(Console.ReadLine());
GetDegree(A, B);


Console.WriteLine();
// Задача 25: решение методом POW
void GetDegreePow(int A, int B)
{
    double res = Math.Pow(A, B);
    Console.WriteLine($"{A}, {B} -> {res} //{A}^({B})");
}
Console.Write("Your base num: ");
int A1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Your degree num: ");
int B1 = Convert.ToInt32(Console.ReadLine());
GetDegreePow(A1, B1);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
Console.WriteLine();

void GetNumber(int num)
{
    int sum = 0;
    for (int i = num; i > 0; i /= 10)
    {
        int d = i % 10;
        sum += d;
    }
    Console.WriteLine($"{num} -> {sum}");
}
Console.Write("Your num: ");
int num = Convert.ToInt32(Console.ReadLine());
GetNumber(num);

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
Console.WriteLine();

int[] CreateArr(int m, int valMin, int valMax)
{
    int[] arr = new int[m];
    for (int i = 0; i < m; i++)
    {
        arr[i] = new Random().Next(valMin, valMax + 1);
    }
    return arr;
}
void WriteArr(int[] arr)
{
    Console.Write(arr[0]);
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
    Console.Write($" - > [{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.Write("Your m: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Your value min: ");
int valMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Your value max: ");
int valMax = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArr(n, valMin, valMax);
WriteArr(myArray);


Console.WriteLine();
//Задача 29: сокращенный вариант
int[] GetArr(int m, int valMin, int valMax)
{
    int[] arr = new int[m];
    for (int i = 0; i < m; i++)
    {
        arr[i] = new Random().Next(valMin, valMax + 1);
    }
    return arr;
}
void ReadArr(int[] arr)
{
    string element = string.Join(", ", arr);
    Console.WriteLine($"{element} -> [{element}]");
}
Console.Write("Your m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Your value min: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Your value max: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int[] Arr = GetArr(m, minVal, maxVal);
ReadArr(Arr);