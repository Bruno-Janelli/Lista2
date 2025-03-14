using System;

class Program
{
    static void Main(string[] args)
    {
        Class1.ExibirVariaveis();
        Class2.VerificarParOuImpar();
        Class3.NumerosDeUmaCem();
        Class4.CincoNumerosCincoMeninos();
        Class5.ExomploSimples();
        Console.WriteLine("Olá, Mundo!");

        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine($"Bem-vindo, {nome}!");

        Console.Write("Digite o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        int soma = numero1 + numero2;
        int subtracao = numero1 - numero2;
        int multiplicacao = numero1 * numero2;
        double divisao = (double)numero1 / numero2;

        Console.WriteLine($"\nResultados das operações entre {numero1} e {numero2}:");
        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");
        Console.WriteLine($"Divisão: {divisao}");
    }
}

