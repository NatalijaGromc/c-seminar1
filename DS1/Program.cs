// See https://aka.ms/new-console-template for more information
int a, b;
string userEnter;

Console.Write ("Введите число a: ");
userEnter = Console.ReadLine()!;
a = int.Parse(userEnter);

Console.Write ("Введите число b: ");
userEnter = Console.ReadLine()!;
b = int.Parse(userEnter);

if (a>b)
{
    
    Console.Write("max = ");
    Console.Write(a);
}

else
{
    Console.Write("max = ");
    Console.Write(b);
}