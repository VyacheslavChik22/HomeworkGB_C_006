// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

// y = k1 * x + b1, y = k2 * x + b2
// k1* x + b1 = k2 * x + b2
// (k1 - k2) * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1

double EnterDigit(string phrase)
{
    Console.WriteLine(phrase);
    return double.Parse(Console.ReadLine()!);
}
double x;
double y;

double b1 = EnterDigit("Введите значение значение b1 ");
double k1 = EnterDigit("Введите значение значение k1 ");
double b2 = EnterDigit("Введите значение значение b2 ");
double k2 = EnterDigit("Введите значение значение k2 ");

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают");
}
else if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}  ->  ({x = (b2 - b1) / (k1 - k2)}, {y = k1 * x + b1})");
}

