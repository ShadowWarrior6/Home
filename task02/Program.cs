//Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе

Console.WriteLine("Введите число");

int AnyNum(int num)
{
    int n_Sum = 0;

    while (num > 0)
    {

        n_Sum += num % 10;
        num /= 10;

    }
    return n_Sum;

}

int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("как-то так " + AnyNum(num_1));


