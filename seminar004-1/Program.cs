Console.Clear();

Console.WriteLine("Hello");

// task 24

// double n = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine((1 + n) / 2 * n);
// 5 = 1 + 2 + 3 + 4 + 5
// 10 = 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 = 55

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("принимает на вход число и выдаёт количество цифр в числе");
Console.WriteLine();
Console.Write("введите число");
Console.WriteLine();

int а = Convert.ToInt32(Console.ReadLine());
int count = 0;
// нужна проверка на цифру 0 и вывод итога = 1

while (а > 0)
{
    а /= 10;
    count ++ ;
}

Console.Write("Результат действия");
Console.WriteLine();
Console.Write(count);

Console.WriteLine();
Console.WriteLine("конец алгоритма");

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до a.
// 4 -> 24 
// 5 -> 120
Console.Write("принимает на вход число a и выдаёт произведение чисел от 1 до a");
Console.WriteLine();
Console.Write("введите число");
Console.WriteLine();

int b = Convert.ToInt32(Console.ReadLine());
int res = 1;

for (int i = 2; i <=b; i++)
    res *= i;

Console.WriteLine(res);
Console.WriteLine();
Console.WriteLine("конец алгоритма");

// Задача 30: Напишите программу, которая выводит массив из n1 элементов, заполненный нулями и единицами в случайном порядке.
Console.Write("выводит массив из n1 элементов, заполненный нулями и единицами в случайном порядке");
Console.WriteLine();
Console.Write("введите число");
Console.WriteLine();

int n1 = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n1];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0,2);
Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine();
Console.WriteLine("конец алгоритма");


