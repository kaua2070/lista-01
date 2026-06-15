int tarefas;
        
        Console.Write("Informe a quantidade de tarefas concluídas: ");
        tarefas = Convert.ToInt32(Console.ReadLine());

        if (tarefas >= 50)
        {
            Console.WriteLine("Meta atingida.");
            Console.WriteLine("Tarefas concluídas: " + tarefas);
        }
        else
        {
            int faltaram = 50 - tarefas;

            Console.WriteLine("Meta não atingida.");
            Console.WriteLine("Faltaram " + faltaram + " tarefas.");
        }d