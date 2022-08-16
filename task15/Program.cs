Console.WriteLine("Введите день недели(1-7): ");
int day = Convert.ToInt32(Console.ReadLine());
 
if(day < 1 || day > 7)
{
    Console.WriteLine("Такого дня не существует, введите от 1 до 7");
    Environment.Exit(1);
}

if(day <= 5)
{
    Console.WriteLine("Будний");
}
else
{
    Console.WriteLine("Выходной");
}