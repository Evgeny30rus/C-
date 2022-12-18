Console.Clear();

Console.Write("вывод на экран созданного и случайнно заполненного массива, вертикально и в строку");
int[] array = new int[8];

for (int i = 0; i < array.Length; i++) //i = i + 1
    array[i] = new Random().Next(-10, 11);

Console.WriteLine($"[ {string.Join(separator: ", ", array)} ]");
           Console.WriteLine();
// процедуры

Console.Write(" процедура void");

void f(ref int x, int y = 18){ //Процедура
    x = x + 10;
    Console.WriteLine(y);
}
           Console.WriteLine();

int n = 5;
Console.WriteLine(n);
           Console.WriteLine();
f(ref n, 122);
           Console.WriteLine();

Console.WriteLine(n);

//Сколько значений передаем, столько и получаем

// return возвращает значение и прерывает подпрограмму
//


string g(int x, int y){ // функция
    if (x > y)
        return ">";
    return "<";
}

// Напишите программу, которая выводит случайное число из отрезка 
// [10, 99] и показывает наибольшую цифру числа.


Console.Write("вывод на экран случайное число из отрезка [10, 99] и показывает наибольшую цифру числа");

int d = new Random().Next(10,100);
int n1 = n / 10; // берем только целую часть до запятой
int n2 = n % 10; // берем только остаток после запятой
           Console.WriteLine();
Console.WriteLine(d);

if (n1 > n2)
    Console.WriteLine(n1);
else if (n1 < n2)
    Console.WriteLine(n2);
else
    Console.WriteLine("=");
            Console.WriteLine();

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.


Console.Write("выводит на экран случайное трехзначное число и удаляет вторую цифру этого числа");

int r = new Random().Next(100,1000);
int n3 = r / 100; // берем только целую часть до запятой
int n4 = r % 10; // берем только остаток после запятой

Console.WriteLine(r);

Console.WriteLine(n3);
Console.WriteLine(n4);

Console.WriteLine(n3*10+n4);
Console.WriteLine($"{n3}{n4}"); //вывод другой


// ввести 2 числа и проверить на кратность 1 ко 2

Console.Write("вввести 2 числа и проверить на кратность 1 ко 2");

Console.Write("Введите первое число: a ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: b ");
int b = Convert.ToInt32(Console.ReadLine());


if (a % b == 0)
    Console.WriteLine("a Кратно b");
else
    Console.WriteLine($"Остаток {a % b}");


// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Write("Вывести на экран проверку одновременной кратности числа к 7 и 23");

Console.Write("Введите число: a1 ");
int a1 = Convert.ToInt32(Console.ReadLine());


if (a1 % 7 == 0 && a1 % 23 == 0)  // && - и; || - или; == проверка на отсток от деления 
    Console.WriteLine("Кратно");
else
    Console.WriteLine("Некратно");


// Напишите программу, которая принимает на вход два числа и проверяет,
//  является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Write("Вывести на экран проверку является ли одно число квадратом другого");


Console.Write("Введите первое число a2: ");
int a2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

if (a2*a2 == b2 || b2*b2 == a2)            // проверка на квадрат числа
    Console.WriteLine("a2 квадрат числа b2 и наоборот верно");
else    
    Console.WriteLine("а2 не квадрат числа b2");


// Math.Sqrt(5.25)




