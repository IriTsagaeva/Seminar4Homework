void PrintMassive (int[] array)
{
    int size = array.Length;
    if (size>0)
    {
        Console.Write($"[ ");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.Write($"]");
    }
    else
    {
        return;
    }
}

int[] CreateRandomArray (int length, int max_random)
{
    int[] massive = new int[length];
    for (int i = 0; i < length; i++)
    {
        massive[i] = new Random().Next(max_random);
    }
    return massive;
}

Console.Clear();
Console.Write("Пожалуйста, введите количество элементов массива:");
Int32.TryParse(Console.ReadLine(), out int size);
Console.Write("Пожалуйста, введите максимальный элемент массива:");
Int32.TryParse(Console.ReadLine(), out int max_random);
max_random++;
if ((size<=0)||(max_random<=0))
{
    Console.WriteLine("Какой-то из показателей меньше или равен 0. Пожалуйста, введите корректные данные");
}
else
{
    int[] array = CreateRandomArray(size,max_random);
    PrintMassive (array);
}


