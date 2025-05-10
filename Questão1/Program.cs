using System;
class Prog
{
    static void Main()
    {
        int lim = 13;
        int tot = 0;
        for (int cont = 1; cont <= lim; cont++)
        {
            tot += cont; 
        }
        Console.WriteLine(tot);
    }
}
