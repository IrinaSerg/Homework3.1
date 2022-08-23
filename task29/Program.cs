int[] convertToInt(string s, int size)
{
    string[] splitedNumbers = s.Split(","); // попилили на много строк по запятой
    int currentSize = 0; // создали переменную, чтобы взависимости от условий понимать на какую длинну массива рассчитывать
    if(size > splitedNumbers.Length)
    {
        currentSize = splitedNumbers.Length; // если пришло меньше элементов чем 8, то берем их количество за size
    } 
    else 
    {
        currentSize = size; // иначе если их пришло больше восьми, то рассматривать будем толкьо первые 8
    }

    int[] result = new int[currentSize]; // пустой массив с длинной, которую выбрали
    for(int i = 0; i < currentSize; i++)
    {
        result[i] = Convert.ToInt32(splitedNumbers[i]); // конвертация каждой отдельной строки и сохранение результата конвертации в массив int.
    }

    return result; // возврат результата вызывающему коду
}

void printArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++) 
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.Write("]");
}

Console.WriteLine("Введите восемь или меньше чисел через запятую: ");
string input = Console.ReadLine();
int maxSize = 8;

int[] numbers = convertToInt(input, maxSize);
printArray(numbers);
