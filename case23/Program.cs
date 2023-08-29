/* Напишите программу, которая принимает на 
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125. */

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void Cubes(int num)
{
    for (int i = 1; i <= num; i++)
    {
        int res = (int)Math.Pow(i, 3);
        Console.Write(res);
        if (i != num) Console.Write(", ");
    }
}

int number = InputNum("Введите число: ");
Cubes(number);