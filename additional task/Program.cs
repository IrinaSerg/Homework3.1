int[,] myArray = new int[3,4];
for(int i = 0; i < myArray.GetLength(0); i++)
{
    for(int j = 0; j < myArray.GetLength(1); j++)
    {
        myArray[i,j] = new Random().Next(-10, 11);
        Console.Write(myArray[i,j] + "\t");
    }
    Console.WriteLine();
}


int sum(int[,] myArray)
{
    int result = 0;
    for(int i = 0; i < myArray.GetLength(0); i++)
    {
      for(int j = 0; j < myArray.GetLength(1); j++)
      {
        if(i == j)
        {
            result += myArray[i,j];
        }
      }
    }
    return result;
}
Console.Write($"Сумма элементов главной диагонали: {sum(myArray)}");

