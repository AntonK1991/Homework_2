void SecondDigit(int x)
{
    int n1 = x % 100;
    double result = n1 / 10;
    Console.WriteLine("Вторая цифра числа - " + result);
}

int input = 379; 

SecondDigit(input);
