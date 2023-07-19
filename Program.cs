static void Main()
{
    while (true)
    {
        Console.WriteLine("Введите строку");

        GetNumber();
        Console.Clear();
    }
}
static int GetNumber()
{
    string userInput = Console.ReadLine();
    bool isItNumber = int.TryParse(userInput, out int number);

    if (isItNumber == true)
    {
        Console.WriteLine("Преобразование прошло успешно. Число: " + number);
    }
    else
    {
        Console.WriteLine("Преобразование прошло неудачно.");
    }

    return number;
}