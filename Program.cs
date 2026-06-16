int idade;

        Console.Write("Informe a idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        if (idade >= 0 && idade <= 11)
        {
            Console.WriteLine("Faixa etária: criança.");
        }
        else if (idade >= 12 && idade <= 17)
        {
            Console.WriteLine("Faixa etária: adolescente.");
        }
        else if (idade >= 18 && idade <= 59)
        {
            Console.WriteLine("Faixa etária: adulto.");
        }
        else
        {
            Console.WriteLine("Faixa etária: idoso.");
        }