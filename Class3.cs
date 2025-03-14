using System;

class Class3
{
    public static void NumerosDeUmaCem()
    {
        // Exibir números de 1 a 100
        Console.WriteLine("Números de 1 a 100:");
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(i);
        }

        // Pedir ao usuário para digitar um número
        Console.Write("\nDigite um número para ver a tabuada: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Exibir a tabuada do número digitado
        Console.WriteLine($"Tabuada do {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}
