//================================================================
//                        Задача 11
// Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.
//================================================================

//Вариант 1
int A = new Random().Next(100, 1000);
Console.WriteLine(A);
int B = A / 100;
int C = A % 10;
A = B * 10 + C;
//Console.WriteLine(A);
Console.WriteLine(B * 10 + C);

//Вариант 2
void Varint2()
{
    Console.WriteLine("Вариант 2");
    int number = new Random().Next(100, 1000);
    Console.WriteLine(number);
    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine($"{charArray[0]}{charArray[2]}");
}

Varint2();
