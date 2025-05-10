using System;
using System.Collections.Generic;

class Prog
{
    static void Main()
    {
        var fat = new Dictionary<string, double>();
        fat.Add("SP", 67836.43);
        fat.Add("RJ", 36678.66); 
        fat.Add("MG", 29229.88);
        fat.Add("ES", 27165.48);
        fat.Add("Outros", 19849.53);

        double soma = 0;
        foreach (var x in fat)
        {
            soma = soma + x.Value;
        }

        Console.WriteLine("Percentual de cada um:");
        foreach (KeyValuePair<string, double> i in fat)
        {
            double p = (i.Value / soma) * 100;
            Console.WriteLine(i.Key + " -> " + p.ToString("F2") + "%");
        }

        // fim :)
    }
}
