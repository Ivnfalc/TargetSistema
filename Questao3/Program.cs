using System;
using System.Collections.Generic;

class Prog
{
    static void Main()
    {
        
        string arquivo = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "dados.json");

        
        if (!System.IO.File.Exists(arquivo))
        {
            Console.WriteLine("não encontrado!");
            return;
        }

        
        string conteudoArquivo = System.IO.File.ReadAllText(arquivo);
        List<double> vval = new List<double>();
        string[] linhas = conteudoArquivo.Trim('[', ']').Split("},");

       
        foreach (string linha in linhas)
        {
            string linhaLimpa = linha.Trim('{', '}').Trim();
            int posVal = linhaLimpa.IndexOf("\"valor\":") + 8;

            if (posVal >= 8)
            {
                string valorStr = linhaLimpa.Substring(posVal).Split(',')[0].Trim();
                double valor;

                if (double.TryParse(
                        valorStr,
                        System.Globalization.NumberStyles.Float,
                        System.Globalization.CultureInfo.InvariantCulture,
                        out valor) && valor > 0)
                {
                    vval.Add(valor);
                }
            }
        }

       
        if (vval.Count == 0)
        {
            Console.WriteLine("Não houve faturamento.");
            return;
        }

        double men = vval[0];
        double mai = vval[0];
        double soma = 0;

        
        foreach (double val in vval)
        {
            if (val < men) men = val;
            if (val > mai) mai = val;
            soma += val;
        }

        double media = soma / vval.Count;
        int acimedia = 0;

        
        foreach (double val in vval)
        {
            if (val > media) acimedia++;
        }

       
        Console.WriteLine("Menor valor: " + men.ToString("F2"));
        Console.WriteLine("Maior valor: " + mai.ToString("F2"));
        Console.WriteLine("valores acima da média: " + acimedia);
    }
}
