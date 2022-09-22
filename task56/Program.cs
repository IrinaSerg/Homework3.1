int[,] ConvertNums(string[] lines)
{
    int[,] result = new int[lines.Length,lines[0].Split(" ").Length];
    for(int i = 0; i < result.GetLength(0); i++)
    {
        string[] chars = lines[i].Split(" ");        
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = Convert.ToInt32(chars[j]);
        }
    }
    return result;
}

int MinSum(int[,] numbers)
{
    int index = 0;
    int minSum = Int32.MaxValue;
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        int currentSum = 0;
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
           currentSum += numbers[i, j]; 
        }

        if(currentSum <= minSum)
        {
            index = i;
            minSum = currentSum;
        }
    }
    return index + 1;
}

Console.WriteLine("Введите 4 числа первой строки через пробел: ");
string line1 = Console.ReadLine();
Console.WriteLine("Введите 4 числа второй строки через пробел: ");
string line2 = Console.ReadLine();
Console.WriteLine("Введите 4 числа третьей строки через пробел: ");
string line3 = Console.ReadLine();
Console.WriteLine("Введите 4 числа четвертой строки через пробел: ");
string line4 = Console.ReadLine();
Console.WriteLine("======================================================================");

string[] lines = {line1, line2, line3, line4};
int[,] numbers = ConvertNums(lines);
int numberOfLineWithMinSum = MinSum(numbers);
Console.WriteLine($"Строка с минимальной суммой - {numberOfLineWithMinSum}");