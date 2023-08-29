/* Напишите программу, которая принимает 
на вход пятизначное число и проверяет, является ли 
оно палиндроном.
14212 -> нет
23432 -> да
12821 -> да */

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

bool SizeNumber(int num)
{
    if (num > 99999 || num < 10000)
    {
        Console.WriteLine("Данное число не является пятизначным");
        return false;
    }
    return true;
}

void Palindron(int num)
{
    int firstNumber = num / 10000;
    int secondNumber = num / 1000 % 10;
    int fourthNumber = num / 10 % 10;
    int fifthNumber = num % 10;
    if (firstNumber == fifthNumber && secondNumber == fourthNumber)
    {
        Console.WriteLine("Данное число является палиндроном");
    }
    else 
        Console.WriteLine("Данное число не является палиндроном");

}


int number = InputNum("Введите пятизначное число: ");
if (SizeNumber(number))
{
    Palindron(number);
}
