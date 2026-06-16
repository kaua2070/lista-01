 int idade;
        double valorNormal, valorPagar;

        Console.Write("Informe a idade do passageiro: ");
        idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o valor normal da passagem: ");
        valorNormal = Convert.ToDouble(Console.ReadLine());

        if (idade <= 5)
        {
            valorPagar = 0;
        }
        else if (idade >= 60)
        {
            valorPagar = valorNormal / 2;
        }
        else
        {
            valorPagar = valorNormal;
        }

        Console.WriteLine("Valor normal da passagem: R$ " + valorNormal.ToString("F2"));
        Console.WriteLine("Valor a pagar: R$ " + valorPagar.ToString("F2"));
        