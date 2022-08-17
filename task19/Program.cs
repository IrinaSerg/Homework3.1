Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();

if(number[0] == number[4] && number[1] == number[3])
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}