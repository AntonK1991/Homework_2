//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

void DigitQ(int input)
{
    int count = 0;
    int input1 = input;
    while (input > 0)
    {
        input = input / 10;
        count++;
    }
    Console.Write("Количество цифр в числе - ");
    Console.WriteLine(count);
       
    if (count > 2)
	{
        ThirdNum (input1, count);
    }
    else 
    {
        Console.WriteLine("Третьей цифры нет");
    }

    void ThirdNum(int input, int count)
    {
        int n = 0;
        int[] list = new int[count];
        int index = 0;
        int count2 = 0;
        while (count2 < count)
        {
            n = input % 10;         
            input = input / 10;  
            list[index] = n;     
            count2 = count2 + 1;   
            if (index < count - 1)
            {                       
                index = index + 1;
            }
        }
        Console.Write("Третья цифра числа - ");
        Console.WriteLine(list[index - 2]);
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

DigitQ(num);