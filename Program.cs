while (true)
{
    Console.WriteLine("Введите строку");

    TryToParse();
    Console.Clear();
}
static void TryToParse()
{
    string userInput = Console.ReadLine();
    bool result = int.TryParse(userInput, out var number);

    if (result == true)
    {
        Console.WriteLine("Преобразование прошло успешно. Число: " + number);
    }
    else
    {
        Console.WriteLine("Преобразование прошло неудачно.");
    }
}