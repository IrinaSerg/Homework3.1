int[] convertToInt(string s)
{
    string[] splittedNumbers = s.Split(",");
    int size = 2;
    int[] result = new int[size];
    
    for(int i = 0; i < size; i++)
    {
        result[i] = Convert.ToInt32(splittedNumbers[i]);
    }

    return result;
}

int pow(int number, int grade)
{
    int result = 1;
    for(int i = 0; i < grade; i++) 
    {
        result *= number;
    }
    return result;
}

Console.WriteLine("Введите число и его степень: ");
string input = Console.ReadLine();

int[] numbers = convertToInt(input);

int number = numbers[0];
int grade = numbers[1];

int result = pow(number, grade);

Console.WriteLine($"Результат: {result.ToString()}");
