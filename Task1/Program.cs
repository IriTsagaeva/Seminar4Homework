double RaiseToThePower (int number, int power)
{
    double result = 1;
    int power_abs = Math.Abs(power);
    for (int i = 0; i < power_abs; i++)
    {
        result = result * number;
    }
    if (power<0)
    {
        result = 1/result;
    }
    return result;
}

Console.Clear();
Console.WriteLine("Пожалуйста, введите число");
bool num_text = Int32.TryParse(Console.ReadLine(), out int number);
Console.WriteLine("Пожалуйста, введите степень");
bool pow_text = Int32.TryParse(Console.ReadLine(), out int power);
if (num_text && pow_text)
{
    double result = RaiseToThePower(number,power);
    Console.WriteLine($"{number} в степени {power} равно {result}");
}
else
{
    Console.WriteLine($"Пожалуйста, введите число. Вместо числа или степени введены некорректные данные");
}
