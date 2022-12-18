Console.Clear();

int[] array = new int[8];

for (int i = 0; i < array.Length; i++) //i = i + 1
    array[i] = new Random().Next(-10, 11);

Console.WriteLine($"[ {string.Join(", ", array)} ]");

// процедуры



void f(ref int x, int y = 18){ //Процедура
    x = x + 10;
    Console.WriteLine(y);
}

int n = 5;
Console.WriteLine(n);
f(ref n, 122);
Console.WriteLine(n);

//Сколько значений передаем, столько и получаем


// return возвращает значение и прерывает подпрограмму
//
Console.Clear();

string f(int x, int y){ // функция
    if (x > y)
        return ">";
    return "<";
}

// Напишите программу, которая выводит случайное число из отрезка 
// [10, 99] и показывает наибольшую цифру числа.

Console.Clear();

int n = new Random().Next(10,100);
int n1 = n / 10; // берем только целую часть до запятой
int n2 = n % 10; // берем только остаток после запятой
Console.WriteLine(n);

if (n1 > n2)
    Console.WriteLine(n1);
else if (n1 < n2)
    Console.WriteLine(n2);
else
    Console.WriteLine("=");

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

Console.Clear();

int n = new Random().Next(100,1000);
int n1 = n / 100; // берем только целую часть до запятой
int n2 = n % 10; // берем только остаток после запятой
int n3 = 10;
Console.WriteLine(n);

Console.WriteLine(n1);
Console.WriteLine(n2);

Console.WriteLine(n1*10+n2);
Console.WriteLine($"{n1}{n2}"); //вывод другой




// ввести 2 числа и проверить на кратность 1 ко 2

Console.Clear();

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());


if (a % b == 0)
    Console.WriteLine("Кратно");
else
    Console.WriteLine($"Остаток {a % b}");


// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());


if (a % 7 == 0 && a % 23 == 0)  // && - и; || - или; == проверка на отсток от деления 
    Console.WriteLine("Кратно");
else
    Console.WriteLine("Некратно");


// Напишите программу, которая принимает на вход два числа и проверяет,
//  является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Clear();

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a*a == b || b*b == a)            // проверка на квадрат числа
    Console.WriteLine("yes");
else    
    Console.WriteLine("no");



// Math.Sqrt(5.25)




