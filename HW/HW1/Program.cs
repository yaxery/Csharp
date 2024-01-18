// Программа принимающая число, и проверяет кратность 7 и 23.
 

 /*int num = 34;

 if (num % 7 == 0 && num % 23 == 0)
 {
    Console.WriteLine("Number multiple 7 and 23");
 }
 else
 {
    Console.WriteLine("Number is`nt multiple 7 and 23");
 }
*/


// Определение координатной четверти

using System;
class Program
{
static void Main()
{
Console.Write("Введите координаты точки X и Y через пробел:");string[] coordinates = Console.ReadLine().Split(' ');
int x = Convert.ToInt32(coordinates[0]);
int y = Convert.ToInt32(coordinates[1]);
if (x > 0 && y > 0)
{
Console.WriteLine("1");
else if (x < 0 && y > 0)
Console.WriteLine("2");
else if (x < 0 && y < 0)
Console.WriteLine("3");
else if (x > 0 && y < 0)
Console.WriteLine("4");
}
else{

Console.WriteLine("Точка находится на оси координат");
}
}