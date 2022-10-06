int N;
string userEnter;

Console.Write ("Введите число N: ");
userEnter = Console.ReadLine()!;
N = int.Parse(userEnter);

Console.Write($"{N/1000*10+(N%100)/10}");
Console.Write($"{N/100-N%10}");