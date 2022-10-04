int a;
string userEnter;

Console.Write ("Введите число a: ");
userEnter = Console.ReadLine()!;
a = int.Parse(userEnter);

if (a%2==0)
{
    Console.Write($"Четное");
   
}

else
{
    Console.Write($"Нечетное, остаток = {a%2}");
}
