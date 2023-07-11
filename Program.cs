
void ShowCubes(int number)
{
    for (int count1 = 1; count1 < number+1; count1++)
    {
        Console.Write($"{Math.Pow(count1,3)} ");
    }
}

int GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите число: ");
Console.Write($"{number} -> ");
ShowCubes(number);