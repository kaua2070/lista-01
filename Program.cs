int numero;

        Console.Write("Informe um número inteiro: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("O número informado é par.");
        }
        else
        {
            Console.WriteLine("O número informado é ímpar.");
        }
