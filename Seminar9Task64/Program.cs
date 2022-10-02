﻿// ---------------------------------------------------------------------
//                                 Задача 64
// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// ---------------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

string LineGenRec(int num)
{
    if (num == 0) return "";
    string outLine = num + " " + LineGenRec(num - 1);
    return outLine;
}

int numN = ReadData("Введите число: ");
string resultLine = LineGenRec(numN);
PrintResult(resultLine);
