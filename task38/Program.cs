int[] numbers = new int[4];

Random random = new Random();
int min = 100;
int max = 0;
for(int i = 0; i < numbers.Length; i++)
{
    int number = random.Next(0, 100);
    if(number < min)
    {
        min = number;
    }
    if(number > max)
    {
        max = number;
    }
    numbers[i] = number;
}
Console.WriteLine($"Вывод случайных элементов: [{string.Join(",", numbers)}]");
 
Console.WriteLine($"Разница max - min: {max - min}");