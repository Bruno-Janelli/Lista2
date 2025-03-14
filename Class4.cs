using System;
using System.Collections.Generic;

class Class4
{
    public static void CincoNumerosCincoMeninos()
    {
        int[] numeros = new int[5];
        int soma = 0;

        Console.WriteLine("Digite 5 números:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
            soma += numeros[i];
        }

        Console.WriteLine($"\nA soma dos números é: {soma}");

        List<string> alunos = new List<string>();

        Console.WriteLine("\nDigite o nome de 5 alunos:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Aluno {i + 1}: ");
            alunos.Add(Console.ReadLine());
        }

        alunos.Sort(); 

        Console.WriteLine("\nAlunos em ordem alfabética:");

        foreach (var aluno in alunos)
        {
            Console.WriteLine(aluno);
        }
    }
}

