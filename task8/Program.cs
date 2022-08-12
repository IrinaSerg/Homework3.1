Console.Write("Введите положительное число: ");
uint number = Convert.ToUInt32(Console.ReadLine());

for(int i = 1; i <= number; i++)
{ 
    if(i % 2 == 0)
    {
        Console.Write(i);
        Console.Write(" ");                            
    }
}

