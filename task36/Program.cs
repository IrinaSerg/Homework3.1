int[] numbers = new int[4];

Random random = new Random();
for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(-99, 100);
}
Console.WriteLine($"Вывод случайных элементов: [{string.Join(",", numbers)}]");

int sum = 0;
for(int i = 1; i < numbers.Length; i += 2)
{
    sum += numbers[i];
}
Console.WriteLine($"Сумма нечетных позиций: {sum}");