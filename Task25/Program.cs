// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

void Zadacha25()
{
    Console.Write("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Exponentiation(a, b));
}    

int Exponentiation(int a, int b)
{
    int power = 1;
    for (int i = 1; i <= b; i++)
    {
        power = power * a;
    }
    return power;
}

Zadacha25();