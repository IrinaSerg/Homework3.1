int counter = 0;
Console.WriteLine("Введите числа через запятую: ");
string[] input = Console.ReadLine().Split(",");

for(int i = 0; i < input.Length; i++)
{
    int number = Convert.ToInt32(input[i]);
    if(number > 0)
    {
        counter++;
    }
}

Console.WriteLine($"Количество чисел больше нуля: {counter}");