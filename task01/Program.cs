//Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

double SumNum(int a , int b)
{

    double n_num = 1;
    int b_abs = Math.Abs(b);

    for (int i = 1; i <= b_abs; i++)
    {

        if (b > 0)
            n_num *= a;
        else
            n_num /= a;
    }

    return n_num;
}

Console.WriteLine("enter number ");
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter degree ");
int num_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNum(num_1, num_2));
