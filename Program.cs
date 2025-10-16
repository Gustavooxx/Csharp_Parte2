using System;

namespace Csharp_Parte2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a cor do semáforo:");
        string cor = Console.ReadLine().ToLower();
        string acao = GetAction(cor);
        Console.WriteLine(acao);
    }

    static string GetAction(string cor)
    {
        var coresAcoes = new (string cor, string acao)[]
        {
            ("verde", "atravesse"),
            ("vermelho", "espere")
        };

        for (int i = 0; i < coresAcoes.Length; i++)
        {
            if (coresAcoes[i].cor == cor)
            {
                return coresAcoes[i].acao;
            }
        }

        return "Farol inoperante";
    }
}
