Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i < number + 1)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
        i = i + 2;
    }
    else
    {
        i = i + 2;
    }
}