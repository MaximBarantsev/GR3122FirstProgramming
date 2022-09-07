//==========================================================================
//                        Задача 18
// Напишите программу, которая по заданному номеру
//   четверти, показывает диапазон возможных
//   координат точек в этой четверти (x и y).
//==========================================================================

//Чтение данных из сонсоли
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

string QuterBorderAsk(int numQuoter)
{
    if (numQuoter == 1)
        return "x>0 y>0";
    if (numQuoter == 2)
        return "x<0 y>0";
    if (numQuoter == 3)
        return "x<0 y<0";
    if (numQuoter == 4)
        return "x>0 y<0";

    return "";
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите номер четверти: ");

string res =QuterBorderAsk(num);

PrintResult(res);