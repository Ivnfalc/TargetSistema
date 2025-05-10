using System;

class Prog
{
    static void Main()
    {
        Console.Write("Digite uma string: ");
        string a = Console.ReadLine();
        char[] b = a.ToCharArray();
        int x = 0;
        int y = b.Length - 1;

        while (x < y)
        {
            char z = b[x];
            b[x] = b[y];
            b[y] = z;

            x++;
            y--;
        }

        string res = new string(b);

        Console.WriteLine("Original era: " + a);
        Console.WriteLine("Invertida agora é: " + res);
    }
}
