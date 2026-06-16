using System;

class Program
{
    static void Main()
    {
        int numero;

        Console.Write("Informe o número inicial da contagem regressiva: ");
        numero = Convert.ToInt32(Console.ReadLine());

        for (int i = numero; i >= 0; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Fim da contagem.");
    }
}