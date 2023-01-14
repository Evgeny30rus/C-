// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



// Pадача 19: 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
Console.Clear();

string num = Console.ReadLine();

if (num[0] == num[4] && num[1] == num[3]) {
    Console.Write("+");
}
else
    Console.Write("-");


//Семинар 
//                по array
Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1,11);
Console.WriteLine($"[{string.Join(", ", array)}]"); // выворд массива на экран в строку с разделителем ", "

//                  array double
Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
for (int i = 0; i < array.Length; i++)
//                                                 * (end - begin) + begin
    array[i] = Math.Round(new Random().NextDouble() * (50 - 10) + 10, 2);   
    // NextDouble() * (50 - 10) + 10, 2) - вносит от 10 до 50 значения в массив 
Console.WriteLine($"[{string.Join(", ", array)}]");


// function
// Необходимо вывести наибольшее число из двух

int test(int a, int b = 15)
{
    if (a > b)
        return a;
    return b;

}

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(test(n, m));




