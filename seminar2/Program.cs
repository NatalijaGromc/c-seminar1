int[] array = { 4, 9, 3, 7, 2, 9, 2, 5 };
int[] array2 = { 4, 2, 3, 2, 2, 9, -5, 5 };

for (int i = 0; i < array2.Length; i++)
Console.Write($"{array2[i]} ");

Sort(array2);
Console.WriteLine();

for (int i = 0; i < array2.Length; i++)
Console.Write($"{array2[i]} ");


void Sort(int[] _array)
{
for (int j = 0; j < _array.Length - 1; j++)
{
for (int i = 0; i < _array.Length - 1; i++)
{
if (_array[i] > _array[i + 1])
{
int temp = _array[i];
_array[i] = _array[i + 1];
_array[i + 1] = temp;
}
}
}
}



int[] array = { 24, 9, 3 };

int max = Max(array[0], array[1], array[2]);

Console.Write($"Максимальное число = {max}");

int Max(int _a, int _b, int _c)
{
int max = _a;
if (_b > max)
max = _b;
if (_c > max)
max = _c;
return max;
}



/*Напишите программу, которая выводит случайное число
из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8*/

int rand = new Random().Next(10, 100);

Console.WriteLine(rand);

int a = rand / 10;
int b = rand % 10;
Console.Write($"Наибольшая цифра числа = ");
if (a > b)
Console.Write(a);
else
Console.Write(b);



/*Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру
этого числа.
456 -> 46
782 -> 72
918 -> 98*/

int rand = new Random().Next(10, 100);

Console.WriteLine(rand);

Console.Write($"{rand / 100 * 10 + rand % 10}");



Задача 1

Console.Write("Введите число a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b = ");
int b = Convert.ToInt32(Console.ReadLine());
if (a % b == 0)
{
Console.Write("Кратно");
}
else
{
Console.Write(a % b);
}
*/
// Задача 2

Console.Write("Введите число a = ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 7 == 0 && a % 23 == 0)
{
Console.Write("Да");
}
else
{
Console.Write("Нет");
}