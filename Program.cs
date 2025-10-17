    using System;

namespace Csharp_Parte2;

class Program
{
    static void Main(string[] args)
    {
        Apresentacao();
        int salario = pegarSalario();
        int gastos = pegarGastos();
        string resultado = Resu(salario, gastos);
        Console.WriteLine(resultado);
    }

    public static void Apresentacao()
    {
        Console.WriteLine("PROGRAMA DO ORCAMENTO");
    }

    public static int pegarSalario()
    {
        Console.WriteLine("Informe o salario:");
        int salario = Convert.ToInt32(Console.ReadLine());
        return salario;
    }

    public static int pegarGastos()
    {
        Console.WriteLine("Informe os gastos:");
        int gastos = Convert.ToInt32( Console.ReadLine());
        return gastos;
    }
    public static string Resu(int salario, int gastos)
    {
        int orcamento = salario - gastos;
        if (orcamento >= 0)
        {
            return "Você está dentro do orçamento!";
        }
        else
        {
            return "Você está fora do orçamento! Não gaste mais!";
        }
    }
    
}
