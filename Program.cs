﻿using System;

namespace Csharp_Parte2;

class Program
{
    static void Main(string[] args)
    {

        Apresentacao();
        double dia = pegarMes("dia:");
       double diasSemana =  pegarMes("dia da semana:");
       double mes =  pegarMes("mes:");
       double ano =  pegarMes("ano:");
       
        Mes((int)dia, (int)diasSemana, (int)mes, (int)ano);
    }

    public static void Apresentacao()
    {
        Console.WriteLine("PROGRAMA DA MES ");
    }

    public static int pegarMes(string ordem)
    {
        Console.WriteLine($"informe o {ordem}");
        int mes = Convert.ToInt32(Console.ReadLine());
        return mes;
    }

    public static void Mes(int dia , int diaSemanal, int mes, int ano)
    {   
          string[] diasSemana = { "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado" };
        string[] Mes = { "mes invalido", "janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };

            Console.WriteLine($"Enviado {diasSemana[diaSemanal]}, {dia} de {Mes[mes]} de {ano}");
    }
}