int GetSum(int number)
{
    number = Math.Abs(number);
    int size = 0;
    size = number.ToString().Length;
    int res = 0;
    for (int i = 1; i <= size; i++)
    {
        res = res + (number%10);
        number = number / 10;
    }
    return res;
}
Console.WriteLine("Введите число...");
int number = Convert.ToInt32(Console.ReadLine());
int res = 0;
res  = GetSum(number);
Console.WriteLine($"Сумма цифр числа равна: {res}");

