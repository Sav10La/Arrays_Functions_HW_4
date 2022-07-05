// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

void Zadacha27()
{
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма цифр числа {number} равно {DigitSum(number)}");
}

int DigitSum(int number)
{
    int sum = 0, i;
    while (number > 0)
    {
        i = number % 10;
        sum = sum + i;
        number = number / 10;
    }
    return sum;
}
Zadacha27();