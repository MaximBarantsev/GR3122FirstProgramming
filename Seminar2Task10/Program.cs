//================================================================
//                        Задача 10
// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
//================================================================


string number = string.Empty;
char[] charArray = { };

ReadData();
CalculateData();
PrintData();

void ReadData()
{
    Console.Write("Введите число: ");                     //Комментарий ко вводу
    number = Console.ReadLine() ?? "";               //Вводим число
}
void CalculateData()
{
    charArray = number.ToString().ToCharArray();   //Преобразуем строку в массив символов
}
void PrintData()
{
    Console.WriteLine(charArray[1]);                      //Вывод результата в консоль
}
