int[] convertToInt(string s)
{
    char[] symbols = s.ToCharArray();
    int[] result = new int[symbols.Length];
    for(int i = 0; i < symbols.Length; i++)
    {
        string symbol = symbols[i].ToString();
        result[i] = Convert.ToInt32(symbol);
    }
    return result;
}

int sum(int[] numbers)
{
    int sum = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum;
}

Console.WriteLine("Введите число: ");
string input = Console.ReadLine();

int[] numbers = convertToInt(input);

int result = sum(numbers);

Console.WriteLine($"Результат: {result.ToString()}");
