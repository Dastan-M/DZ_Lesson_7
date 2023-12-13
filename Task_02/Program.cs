// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
        else
        {
            return -1;
        }
    }

    int result = Ackermann(m,n);
    System.Console.WriteLine(result);
