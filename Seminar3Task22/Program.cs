//==========================================================================
//                        Задача 22
// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//==========================================================================

int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

//
string lineNumbers(int numberN, int pow)
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + Math.Pow(i,pow) + "\t";
        ++i;
    }
    outLine = outLine + Math.Pow (numberN, pow);
    return outLine;
}


void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число N: ");


PrintResult(lineNumbers(num, 1));
PrintResult(lineNumbers(num, 2));