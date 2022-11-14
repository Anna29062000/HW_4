int Exponentiation(int A, int B)
{
    int res = 1;
    for (int i = 1; i <= B; i++)
    {
        res = res * A; 
    }
    return res;
}
Console.WriteLine("Введите натуральное число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B");
int B = Convert.ToInt32(Console.ReadLine());
int res = 1;
res = Exponentiation(A, B);
Console.WriteLine($"Результат возведения А в степень В: {res}");