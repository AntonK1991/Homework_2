// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

void WeekDayCheck(int daynumber)
{
    int input = daynumber;
    if (daynumber == 1)
    {
        Console.WriteLine("Понедельник - не выходной день");
    }
    else if (daynumber == 2)
    {
        Console.WriteLine("Вторник - не выходной день");
    }
    else if (daynumber == 3)
    {
        Console.WriteLine("Среда - не выходной день");
    }
    else if (daynumber == 4)
    {
        Console.WriteLine("Четверг - не выходной день");
    }
    else if (daynumber == 5)
    {
        Console.WriteLine("Пятница - не выходной день");
    }
    else if (daynumber == 6)
    {
        Console.WriteLine("Суббота - выходной день");
    }
    else if (daynumber == 7)
    {
        Console.WriteLine("Воскресенье -  выходной день");
    }
    else 
    {
        Console.WriteLine("Это не день недели, введите цифру от 1 до 7");
    }

}

Console.Write("Введите цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

WeekDayCheck(num);

