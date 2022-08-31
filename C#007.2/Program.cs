Console.WriteLine("Введите номер строки в массиве");
int nunberstr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца в массиве");
int numbercolumn = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [6,6];
FillArray(numbers);

if (nunberstr > numbers.GetLength(0) || numbercolumn > numbers.GetLength(1))
{
    Console.WriteLine("Нет такого элемента!!!");
}
else
{
    Console.WriteLine("Значение элемента равно " + numbers[nunberstr-1,numbercolumn-1]);
}

PrintArray(numbers);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-300, 300)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}