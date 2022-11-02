void SecondDigit(int x)
{
    int n1 = x % 100;
    int result = n1 / 10;
    Console.WriteLine("Вторая цифра числа - " + result);
}

int input = 123; 

SecondDigit(input);
