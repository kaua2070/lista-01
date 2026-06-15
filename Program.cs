double valorCompra, desconto, valorFinal;

        Console.Write("Informe o valor total da compra: ");
        valorCompra = Convert.ToDouble(Console.ReadLine());

        if (valorCompra >= 200)
        {
            desconto = valorCompra * 0.10; // 10% de desconto
        }
        else
        {
            desconto = 0;
        }

        valorFinal = valorCompra - desconto;

        Console.WriteLine("Valor original: R$ " + valorCompra.ToString("F2"));
        Console.WriteLine("Desconto aplicado: R$ " + desconto.ToString("F2"));
        Console.WriteLine("Valor final: R$ " + valorFinal.ToString("F2"));
    