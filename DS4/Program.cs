int i, N;
string userEnter;

Console.Write ("Введите число N: ");
userEnter = Console.ReadLine()!;
N = int.Parse(userEnter);
i=2;
while (i<=N)
{
    Console.Write($"{i} ");
    i=i+2;
   
}

