int[,] getMatrix(string[] elements)
{
   int[,] matrix = new int[2, 2];
   matrix[0, 0] = Convert.ToInt32(elements[0]);
   matrix[0, 1] = Convert.ToInt32(elements[1]);
   matrix[1, 0] = Convert.ToInt32(elements[2]);
   matrix[1, 1] = Convert.ToInt32(elements[3]);
   return matrix;
}

int[,] multiplyMatrix(int[,] first, int[,] second)
{
    int[,] result = new int[first.GetLength(0), second.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); ++i)
    {
        for (int j = 0; j < result.GetLength(1); ++j)
        {
            int temp_value = 0;
            for (int c = 0; c < result.GetLength(1); ++c)
            {
               temp_value += first[i, c] * second[c, j];
            }
            result[i,j] = temp_value;
        }
    }
    return result;
}

Console.WriteLine("Введите матрицы 2х2, разделяя их знаком |: ");
string[] firstLineStr = Console.ReadLine()!.Split(" | ");
string[] lastLineStr = Console.ReadLine()!.Split(" | ");

string[] firstLinePart1 = firstLineStr[0].Split(" ");
string[] firstLinePart2 = firstLineStr[1].Split(" ");
string[,] firstLine = {{firstLinePart1[0],firstLinePart1[1]},{firstLinePart2[0],firstLinePart2[1]}};

string[] lastLinePart1 = lastLineStr[0].Split(" ");
string[] lastLinePart2 = lastLineStr[1].Split(" ");
string[,] lastLine = {{lastLinePart1[0],lastLinePart1[1]},{lastLinePart2[0],lastLinePart2[1]}};

string[] matrixAElems = {firstLine[0,0], firstLine[0,1], lastLine[0,0], lastLine[0,1]};
string[] matrixBElems = {firstLine[1,0], firstLine[1,1], lastLine[1,0], lastLine[1,1]};

int[,] matrixA = getMatrix(matrixAElems);
int[,] matrixB = getMatrix(matrixBElems);

int[,] result = multiplyMatrix(matrixA, matrixB);

Console.WriteLine("===============");

for(int i = 0; i < result.GetLength(0); i++)
{
    for(int j = 0; j < result.GetLength(1); j++)
    {
        Console.Write($"{result[i,j]} ");
    }
    Console.WriteLine();
}