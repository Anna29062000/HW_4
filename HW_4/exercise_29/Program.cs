int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    Console.Write($"Введите элемент массива под номером {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.Write("Был введен массив: ");

for (int i = 0; i < 8; i++)
{
    Console.Write($"{array[i]} ");
}