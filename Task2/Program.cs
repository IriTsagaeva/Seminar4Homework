int ReturnDecimalsSum (int number)
{
    if (number<0)
    {
        number=number*(-1);
    }
    int sum = 0;
    while (number!=0)
    {
        sum = sum + number%10;
        number = number/10;        
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Please, enter your number:");
int sum = ReturnDecimalsSum (Int32.Parse(Console.ReadLine()));
Console.WriteLine($"SUM = {sum}");
