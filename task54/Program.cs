int[,] Sort(int[,] nums)
{
    for(int i = 0; i < nums.GetLength(0); i++)
    {
        for(int x = 0; x < nums.GetLength(1) - 1; x++)
        {
            for(int j = 0; j < nums.GetLength(1) - 1; j++)
            {
                if(nums[i, j] < nums[i, j + 1])
                {
                    int temp = nums[i, j];
                    nums[i, j] = nums[i, j + 1];
                    nums[i, j + 1] = temp;
                }
            }
        }
    }
    return nums;
}

void PrintArray(int[,] nums)
{
   for(int i = 0; i < nums.GetLength(0); i++)//cтрока
    {
        for(int j = 0; j < nums.GetLength(1); j++) //по столбцам(0,0;0,1;0,2) до предпоследнего
        {
            Console.Write($"{nums[i,j]} ");
        }
        Console.WriteLine();
    }  
}

int[,] ConvertNums(string[] lines)
{
    int[,] result = new int[lines.Length,lines[0].Split(" ").Length];/*[кол-во линий которые вел пользователь,кол-во линий в строке]*/
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

Console.WriteLine("Введите 4 числа первой строки через пробел: ");
string line1 = Console.ReadLine();
Console.WriteLine("Введите 4 числа второй строки через пробел: ");
string line2 = Console.ReadLine();
Console.WriteLine("Введите 4 числа третьей строки через пробел: ");
string line3 = Console.ReadLine();
Console.WriteLine("======================================================================");

string[] lines = {line1, line2, line3};
int[,] numbers = ConvertNums(lines);
int[,] sortedNumbers = Sort(numbers);
PrintArray(sortedNumbers);
