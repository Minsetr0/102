static void Main()
{
    int number = GetNumber();

    Console.WriteLine("Преобразование прошло успешно. Число: " + number);
}

static int GetNumber()
{
    int number = 0;
    bool isItNumber = false;

    while (!isItNumber)
    {
        Console.WriteLine("Введите число:");

        string userInput = Console.ReadLine();
        if (int.TryParse(userInput, out number))
        {
            isItNumber = true;
        }
        else
        {
            Console.WriteLine("Преобразование прошло неудачно. Пожалуйста, введите корректное число.");
        }
    }

    return number;
}
