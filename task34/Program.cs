int n = 4;
int[] numbers = new int[n];

Random random = new Random();
for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(100, 999);
}
Console.WriteLine($"Вывод случайных элементов: [{string.Join(",", numbers)}]");

int evenAmount = 0;
for(int i = 0; i < numbers.Length; i++)
{
   if(numbers[i] % 2 == 0) 
   {
     evenAmount++;
   }  
}
Console.WriteLine($"Кол-во четных чисел: {evenAmount}");