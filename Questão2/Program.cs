using System;

class Prog
{
    static void Main()
    {
        Console.Write("Informe um número: ");
        int num = int.Parse(Console.ReadLine());

        bool pertence = false;
        int a = 0;
        int b = 1;

        while (a <= num)
        {
            if (a == num)
            {
                pertence = true;
                break;
            }
            int prx = a + b;
            a = b;
            b = prx;
        }

        if (pertence)
        {
            Console.WriteLine($"número {num} pertence à sequência");
        }
        else
        {
            Console.WriteLine($"número {num} não pertence à sequência");
        }
    }
}
