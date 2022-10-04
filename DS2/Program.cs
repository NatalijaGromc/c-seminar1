int a, b, c;
string userEnter;

Console.Write ("Введите число a: ");
userEnter = Console.ReadLine()!;
a = int.Parse(userEnter);

Console.Write ("Введите число b: ");
userEnter = Console.ReadLine()!;
b = int.Parse(userEnter);

Console.Write ("Введите число c: ");
userEnter = Console.ReadLine()!;
c = int.Parse(userEnter);

if (a>b)
{
    if (a>c)
    {
        Console.Write ($"max = {a}",a);
    }
    else {Console.Write ($"max = {c}",c);}
}

else
{
    if (b>c)
    {
        Console.Write ($"max = {b}",b);
    }
    else {Console.Write ($"max = {c}",c);}
}
