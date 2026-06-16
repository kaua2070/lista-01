using System;

class Program
{
    static void Main()
    {
        double valor, soma = 0, media;

        for (int i = 1; i <= 5; i++)
        {
            if (i == 1)
                Console.Write("Informe o primeiro valor: ");
            else if (i == 2)
                Console.Write("Informe o segundo valor: ");
            else if (i == 3)
                Console.Write("Informe o terceiro valor: ");
            else if (i == 4)
                Console.Write("Informe o quarto valor: ");
            else
                Console.Write("Informe o quinto valor: ");

            valor = Convert.ToDouble(Console.ReadLine());
            soma += valor;
        }

        media = soma / 5;

        Console.WriteLine("Soma dos valores: " + soma);
        Console.WriteLine("Média dos valores: " + media);
    }
}