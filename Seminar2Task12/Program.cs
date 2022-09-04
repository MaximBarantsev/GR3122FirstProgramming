//================================================================
//                        Задача 12
// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому, если второе число некратно первому,
// то программа выводит остаток от деления.
//================================================================

//Вариант 1======================================================
// Console.Write("Введите первое число: ");
// string numberA = Console.ReadLine() ?? "";
// Console.Write("Введите второе число: ");
// string numberB = Console.ReadLine() ?? "";

// int firstNumber = int.Parse(numberA);
// int secondNumber = int.Parse(numberB);

// bool numberDiv = (secondNumber % firstNumber == 0);

// if (numberDiv)
// {
//     Console.WriteLine("Число B кратно А");
// }
// else
// {
//     Console.WriteLine("Не кратно, остаток: " + secondNumber % firstNumber);
// }

//Вариант 2=====================================================
// void Varint2()
// {
//     Console.Write("Введите первое число: ");
//     string numberA = Console.ReadLine() ?? "";
//     Console.Write("Введите второе число: ");
//     string numberB = Console.ReadLine() ?? "";

//     int firstNumber = int.Parse(numberA);
//     int secondNumber = int.Parse(numberB);
//     Console.WriteLine((secondNumber % firstNumber == 0) ? ("Второе число кратно первому") : ("Остаток от деления: " + secondNumber % firstNumber));
// }

// Varint2();

//Вариант 3=====================================================
int inputNumberA = 0;
int inputNumberB = 0;
bool result = false;

ReadData();      //Получаем два чила от пользователя и преобразуем строковое представление числа в знаковое целое число
CalculateData(); //Определяем кратность чисел
PrintData();     //Выводим результат в консоль

void ReadData()
{
    Console.Write("Введите первое число: ");
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число: ");
    string? inputLineB = Console.ReadLine();

    inputNumberA = int.Parse(inputLineA);
    inputNumberB = int.Parse(inputLineB);

}

void CalculateData()
{
    result = (inputNumberB % inputNumberA == 0);
}

void PrintData()
{
    if(result)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine("Остаток от деления: " + inputNumberB % inputNumberA);
    }
}