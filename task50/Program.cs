
int[,] array = {{1,4,7,2}, {5,9,2,3}, {8,4,2,4}};

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string result = "такого числа в массиве нет";
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        if(array[i,j] == number)
        {
            result = $"Индекс - [{i},{j}]";
            break;
        }
    }
}

Console.WriteLine(result);