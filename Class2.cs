using System;

class Class2
{
    public static void VerificarParOuImpar()
    {
        Console.Write("Digite um número inteiro para verificar se é par ou ímpar: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine($"{numero} é par.");
        }
        else
        {
            Console.WriteLine($"{numero} é ímpar.");
        }
        Console.WriteLine();
    }

    static void EncontrarMaiorNumero()
    {
        Console.Write("Digite o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        int numero3 = int.Parse(Console.ReadLine());

        int maior = numero1;

        if (numero2 > maior)
        {
            maior = numero2;
        }

        if (numero3 > maior)
        {
            maior = numero3;
        }

        Console.WriteLine($"O maior número digitado é: {maior}");
        Console.WriteLine();
    }
}
