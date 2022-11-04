//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

void SecondDigit(int x)
{
    int n1 = x % 100;
    int result = n1 / 10;
    Console.WriteLine("Вторая цифра числа - " + result);
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

SecondDigit(num);