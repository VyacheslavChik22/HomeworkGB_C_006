// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int EnterNumbers(string phrase)
{
    Console.Write(phrase);
    return int.Parse(Console.ReadLine()!);
}

int M = new Random().Next(1, 10);
int[] numbers = new int[M];

Console.WriteLine($"Введите {M} чисел: ");

int inputNumbers;
int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    inputNumbers = EnterNumbers("");
    numbers[i] = inputNumbers;
    if (numbers[i] > 0) count++;
}

Console.Write(String.Join(", ", numbers) + " -> " + count);

