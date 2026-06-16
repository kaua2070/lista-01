using System;

class Program
{
    static void Main()
    {
        int numero;

        Console.Write("Informe o número final da contagem: ");
        numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= numero; i++)
        {
            Console.WriteLine(i);
        }
    }
}