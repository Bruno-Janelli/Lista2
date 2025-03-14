using System;

class Class1
{
 

    public static void ExibirVariaveis()
    {
        int numeroInteiro = 10;
        float numeroFloat = 5.75f;
        double numeroDouble = 3.14159265359;
        string texto = "Exemplo de string";
        bool booleano = true;

        Console.WriteLine("Valores armazenados:");
        Console.WriteLine($"int: {numeroInteiro}");
        Console.WriteLine($"float: {numeroFloat}");
        Console.WriteLine($"double: {numeroDouble}");
        Console.WriteLine($"string: {texto}");
        Console.WriteLine($"bool: {booleano}");
        Console.WriteLine();
    }

    static void ConverterCelsiusParaFahrenheit()
    {
        Console.Write("Digite a temperatura em Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"{celsius}°C equivale a {fahrenheit}°F.");
        Console.WriteLine();
    }

    static void AtividadesAnteriores()
    {
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
        Console.WriteLine();
    }
}
