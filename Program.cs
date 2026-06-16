using System;

class Program
{
    static void Main()
    {
        int numero;

        Console.Write("Informe o número da tabuada: ");
        numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(numero + " x " + i + " = " + (numero * i));
        }
    }
}