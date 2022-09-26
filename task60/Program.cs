int[,,] FillArray() 
{
    int[,,] numbers = new int[2,2,2];
    Random random = new Random();
    for(int i = 0; i < numbers.GetLength(0); i++) 
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            for(int k = 0; k < numbers.GetLength(2); k++)
            {
                numbers[i,j,k] = random.Next(10, 100);
            }
        }
    }
    return numbers;
}

void PrintArray(int[,,] numbers)
{
    for(int i = 0; i < numbers.GetLength(0); i++) 
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            for(int k = 0; k < numbers.GetLength(2); k++)
            {
                Console.Write($"{numbers[i,j,k]}({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
}

int[,,] numbers = FillArray();
PrintArray(numbers);
