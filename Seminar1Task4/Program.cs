﻿//==================================================================================================================================================================================
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//==================================================================================================================================================================================
Console.Write("Введите первое число: ");             //Комментарий ко вводу
string numberA = Console.ReadLine() ?? "";           //Вводим первое число
Console.Write("Введите второе число: ");             //Комментарий ко вводу
string numberB = Console.ReadLine() ?? "";           //Вводим второе число
Console.Write("Введите третье число: ");             //Комментарий ко вводу
string numberС = Console.ReadLine() ?? "";           //Вводим третье число

int inputNumberA = int.Parse(numberA);               //Преобразуем строковое представление первого числа в знаковое целое число
int inputNumberB = int.Parse(numberB);               //Преобразуем строковое представление второго числа в знаковое целое число
int inputNumberC = int.Parse(numberС);               //Преобразуем строковое представление третьего числа в знаковое целое число

if (inputNumberA > inputNumberB)                     //Сравниваем первое и второе число
{
    if (inputNumberA > inputNumberC)                 //Сравнивает первое и третье число
    {
        Console.WriteLine(inputNumberA);             //Вывод результата в консоль
    }
    else
    {
        Console.WriteLine(inputNumberC);             //Вывод результата в консоль
    }
}
else
{
    if (inputNumberB > inputNumberC)                 //Сравниваем второе и третье число
    {
        Console.WriteLine(inputNumberB);             //Вывод результата в консоль
    }
    else
    {
        Console.WriteLine(inputNumberC);             //Вывод результата в консоль
    }

}
