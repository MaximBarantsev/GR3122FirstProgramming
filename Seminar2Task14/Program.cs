//================================================================
//                        Задача 14
// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
//================================================================
//Вариант 1
// Console.Write("Введите число: ");
// string inputLineA = Console.ReadLine()??"";
// int inputNumberA = int.Parse(inputLineA);

// if(inputNumberA % 7 == 0 && inputNumberA % 23 == 0)
// {
//     Console.Write("Число кратно одновременно 7 и 23");
// }
// else 
// {
//     Console.Write("Число не кратно одновременно 7 и 23");
// }

//Вариант 2
// Console.Write("Введите число: ");
// string? inputLineA = Console.ReadLine();
// if(inputLineA != null)
// Console.Write(((int.Parse(inputLineA)% 7 == 0)&& (int.Parse(inputLineA)% 23 ==0))? ("Кратно"): ("Не кратно"));

//Вариант 3
int number, resultA, resultB;

//запрашивает число у пользователя
//(принимает текст запроса и команду входа)
int RequestNumber(string text = "Enter number", string exitCmd = "q")
{
    //цикл выполняется до введения целого числа или "q"
    while (true)
    {
        Console.Write(text + ":");
        string? inputLine = Console.ReadLine();

        //игнорируем пробел
        if (inputLine == null)
        {
            continue;
        }
        //выходим из программы
        if (inputLine.ToLower() == exitCmd)
        {
            Environment.Exit(0);
        }
        //выдаем полученное число
        if (int.TryParse(inputLine, out int number))
        {
            return number;
        }
    }
}

//чтение данных из консоли
void ReadData()
{
    number = RequestNumber("Enter number");
}

//определяем кратность чисел
void CalculatedData()
{
    resultA = number % 7;
    resultB = number % 23;
}

//вывод данных
void PrintData()
{
    if (resultA == 0 && resultB == 0)
    {
        Console.WriteLine("Число кратно одновременно 7 и 23");
    }
    else
    {
        Console.WriteLine("Число не кратно одновременно 7 и 23");
    }
}

ReadData();
CalculatedData();
PrintData();