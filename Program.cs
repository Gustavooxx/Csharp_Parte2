using System;

namespace Csharp_Parte2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o número do dia da semana (0-6):");
        int dia = Convert.ToInt32(Console.ReadLine());

        string[] diasSemana = { "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado" };

        if (dia >= 0 && dia <= 6)
        {
            Console.WriteLine($"O dia da semana é: {diasSemana[dia]}");
        }
        else
        {
            Console.WriteLine("Dia da semana inválido");
        }
    }

    public static void Apresentacao()
    {
        Console.WriteLine("PROGRAMA DA SEMANA ");
    }
}
