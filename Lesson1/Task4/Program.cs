// Задача с 5-ю гирями

int a = 8;
int b = 10;
int c = 6;
int d = 16;
int e = 24;

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
if (d > max)
{
    max = d;
}
if (e > max)
{
    max = e;
}

Console.WriteLine(max);