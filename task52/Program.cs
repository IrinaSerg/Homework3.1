int[,] array = {{1,4,7,2},
                {5,9,2,3}, 
                {8,4,2,4}};
double average = 0;

for(int j = 0; j < array.GetLength(1); j++)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        average += array[i,j];
    }
    average /= array.GetLength(0);
    Console.Write($"{average.ToString("F2")} ");
    average = 0;
}

