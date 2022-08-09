Console.Write("Введите первое число: ");
int a = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Int32.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Int32.Parse(Console.ReadLine());

int max = 0;

Console.Write("Результат: ");
if (a > b)
{
    max = a;
}
else
{
    max = b;
}

if (max > c)
{
    Console.Write(max);
}
else
{
    Console.Write(c);
}
