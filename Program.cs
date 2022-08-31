Console.WriteLine("Введите кол-во строк в массиве");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в массиве");
int column = Convert.ToInt32(Console.ReadLine());
double[,] number = new double[str,column];
FillArray(number);
PrintArray(number);

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-300, 300)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}