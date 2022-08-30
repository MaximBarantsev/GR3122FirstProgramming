//============================================================================
// # 0 Напишите программу, которая на входи принимает число и 
//проверяет, является ли первое число квадратом второго.
//============================================================================

string? inputLineA = Console.ReadLine();
string? inputLineA = Console.ReadLine();
if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    //bool outResult = (inputLineA * inputLineA == inputNumberB);
    //bool outResult = (inputNumberA * inputNumberA == inputNumberB);
    bool outResult = (Math.Sqrt(inputNumberB) == inputNumberA);

    Console.WriteLine(outResult);
}