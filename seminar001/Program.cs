Console.WriteLine("введите число а");

// string a = Console.ReadLine();
// double b = Convert.ToInt32(Console.ReadLine())

// Console.WriteLine(a);

int a = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("введите число b");
int b = Convert.ToInt32(Console.ReadLine());

// int b = Convert.ToInt32(b); 
// int c = 2, int d = 10 -> нет 
// int r = 9, int f = -3 -> да 
// int s = -3 int w = 9 -> нет

if (a == b*b)  // != не равенство
{
    Console.WriteLine("да");
}
else
{
   Console.WriteLine("нет");
}