Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
if(number.Length <= 2)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    Console.WriteLine(number[2]);
}


