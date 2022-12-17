Console.WriteLine("введите число а");

// string a = Console.ReadLine();
// double b = Convert.ToInt32(Console.ReadLine())

// Console.WriteLine(a);

int a = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("введите число b");
int b = Convert.ToInt32(Console.ReadLine());


if (a == b*b)  // != не равенство
{
    Console.WriteLine("да");
}
else
{
   Console.WriteLine("нет");
}