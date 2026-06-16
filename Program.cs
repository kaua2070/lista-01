int pontuacao1, pontuacao2, pontuacao3;

        Console.Write("Informe a primeira pontuação: ");
        pontuacao1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe a segunda pontuação: ");
        pontuacao2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe a terceira pontuação: ");
        pontuacao3 = Convert.ToInt32(Console.ReadLine());

        // Verifica se as três pontuações são iguais
        if (pontuacao1 == pontuacao2 && pontuacao2 == pontuacao3)
        {
            Console.WriteLine("As três pontuações são iguais.");
        }
        // Verifica se a primeira é a maior
        else if (pontuacao1 >= pontuacao2 && pontuacao1 >= pontuacao3)
        {
            Console.WriteLine("Maior pontuação: " + pontuacao1);
        }
        // Verifica se a segunda é a maior
        else if (pontuacao2 >= pontuacao1 && pontuacao2 >= pontuacao3)
        {
            Console.WriteLine("Maior pontuação: " + pontuacao2);
        }
        // Caso contrário, a terceira é a maior
        else
        {
            Console.WriteLine("Maior pontuação: " + pontuacao3);
        }
