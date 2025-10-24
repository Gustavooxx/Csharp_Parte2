﻿using System;

namespace Csharp_Parte2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de Mensalidade de Faculdade de Tecnologia");

        Console.WriteLine("Informe a sigla do curso (SI, ADS, CS, EC, ES):");
        string curso = Console.ReadLine().ToUpper();

        Console.WriteLine("É isento? (sim ou nao):");
        string isento = Console.ReadLine().ToLower();

        Console.WriteLine("Informe o desconto em (%):");
        double desconto = Convert.ToDouble(Console.ReadLine());

        double mensalidadeBase = 0;
        if (curso == "SI")
        {
            mensalidadeBase = 550.00;
        }
        else if (curso == "ADS")
        {
            mensalidadeBase = 750.00;
        }
        else if (curso == "CS")
        {
            mensalidadeBase = 1150.00;
        }
        else if (curso == "EC")
        {
            mensalidadeBase = 1300.00;
        }
        else if (curso == "ES")
        {
            mensalidadeBase = 950.00;
        }
        else
        {
            Console.WriteLine("Curso inválido.");
            return;
        }

        double mensalidade;
        if (isento == "sim")
        {
            mensalidade = 0.00;
        }
        else
        {
            mensalidade = mensalidadeBase * (1 - desconto / 100);
        }

        Console.WriteLine($"Valor da mensalidade: R$ {mensalidade}");
    }
}
