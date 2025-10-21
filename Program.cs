﻿using System;

namespace Csharp_Parte2;

class Program
{
    static void Main(string[] args)
    {

        Apresentacao();
        var (valor1, valor2, operacao) = pegarValoresEOperacao();
        Calcular(valor1, valor2, operacao);
    }

    public static void Apresentacao()
    {
        Console.WriteLine("CALCULADORA");
    }

    public static (double valor1, double valor2, string operacao) pegarValoresEOperacao()
    {
        Console.WriteLine("informe o primeiro valor:");
        double valor1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("informe o segundo valor:");
        double valor2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("informe a operação (soma, subtracao, multiplicacao, divisao, resto, potencia):");
        string operacao = Console.ReadLine().ToLower();
        return (valor1, valor2, operacao);
    }

    public static void Calcular(double valor1, double valor2, string operacao)
    {
        double resultado;
        if (operacao == "soma")
        {
            resultado = valor1 + valor2;
        }
        else if (operacao == "subtracao")
        {
            resultado = valor1 - valor2;
        }
        else if (operacao == "multiplicacao")
        {
            resultado = valor1 * valor2;
        }
        else if (operacao == "divisao")
        {
            if (valor2 == 0)
            {
                Console.WriteLine("Erro: Divisão por zero.");
                return;
            }
            resultado = valor1 / valor2;
        }
        else if (operacao == "resto")
        {
            if (valor2 == 0)
            {
                Console.WriteLine("Erro: Divisão por zero.");
                return;
            }
            resultado = valor1 % valor2;
        }
        else if (operacao == "potencia")
        {
            resultado = Math.Pow(valor1, valor2);
        }
        else
        {
            Console.WriteLine("Operação não suportada");
            return;
        }
        Console.WriteLine($"Resultado: {resultado}");
    }
}