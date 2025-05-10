using System;

class Prog
{
    static void Main()
    {

        int I = 13;
        int SOMA = 0;
        int K = 0;


        while (K < I)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }


        Console.WriteLine(SOMA);
    }
}