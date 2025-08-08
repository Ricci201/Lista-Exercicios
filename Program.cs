using Lista_Exercicios;

internal class Program
{
    private static int posicao;

    private static void Main(string[] args)
    {
        Console.WriteLine("********** Listas **********");
        List<string> tarefas = new List<string>();
        tarefas.Add("Lavar a louça");
        tarefas.Add("Lavar o banheiro");
        tarefas.Add("Tirar o lixo");
        tarefas.Add("Fazer o almoço");
        tarefas.Add("Dormir");

        tarefas.Insert(2, "Passar pano na casa");

        tarefas[4] = "Fazer a janta";

        bool achou = tarefas.Contains("Lavar o banheiro");

        if (achou)
        {
            Console.WriteLine("\nTarefa existe");
        }
        else
            Console.WriteLine("\nTarefa não existe");

        tarefas.Remove("Lavar o banheiro");

        foreach (string item in tarefas)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("************************* Atividade 02 ************************");

        // Criar o Dictionary<string, string> chamado agenda
        Dictionary<string, string> agenda = new Dictionary<string, string>();

        // Inserir pelo menos 5 contatos
        agenda.Add("João", "9999-1111");
        agenda.Add("Maria", "9888-2222");
        agenda.Add("Pedro", "9777-3333");
        agenda.Add("Ana", "9666-4444");
        agenda.Add("Carlos", "9555-5555");

        // Alterar o telefone de um contato específico (exemplo: Pedro)
        agenda["Pedro"] = "9000-0000";

        // Pesquisar se "Maria" existe na agenda
        if (agenda.ContainsKey("Maria"))
        {
            Console.WriteLine($"Telefone de Maria: {agenda["Maria"]}");
        }
        else
        {
            Console.WriteLine("Maria não está na agenda.");
        }

        // Remover um contato pelo nome (exemplo: Ana)
        if (agenda.Remove("Ana"))
        {
            Console.WriteLine("Contato Ana removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Contato Ana não encontrado.");
        }

        // Exibir todos os contatos restantes
        Console.WriteLine("\nContatos restantes na agenda:");
        foreach (var contato in agenda)
        {
            Console.WriteLine($"{contato.Key} - {contato.Value}");
        }

        Console.WriteLine("************************* Atividade 03 ************************");

        Queue<Cliente> fila = new Queue<Cliente>();

        // Inserir clientes
        fila.Enqueue(new Cliente("Ana Banana"));
        fila.Enqueue(new Cliente("Bruno Roberto"));
        fila.Enqueue(new Cliente("João Bananão"));
        fila.Enqueue(new Cliente("Carla Josefa"));
        fila.Enqueue(new Cliente("Marcos Tum Tum Sahur"));

        // Atender primeiro cliente
        if (fila.Count > 0)
        {
            Cliente atendido = fila.Dequeue();
            Console.WriteLine($"Cliente atendido: {atendido}");
        }

        // Pesquisar cliente específico
        string nomeProcurado = "João Bananão";
        var listaRestante = fila.ToList();
        int posicao = listaRestante.FindIndex(c =>
            string.Equals(c?.Nome, nomeProcurado, StringComparison.OrdinalIgnoreCase));

        if (posicao != -1)
            Console.WriteLine($"O cliente {nomeProcurado} está na posição {posicao + 1} da fila.");
        else
            Console.WriteLine($"O cliente {nomeProcurado} não está na fila.");

        // Remover cliente específico (ex.: "Carla Josefa")
        string primeiroFila = fila.Dequeue();
        Console.WriteLine($"\n{primeiroFila} é o primeiro,e saiu da fila\n");

        foreach (var pessoa in fila)
        {
            // Imprimir chave e valor do dicionário
            Console.WriteLine(pessoa);
        }

        // Reconstruir a fila com os clientes restantes
        fila = new Queue<Cliente>(listaRestante);

        // Exibir todos os clientes restantes
        Console.WriteLine("\nClientes restantes na fila:");
        if (fila.Count > 0)
        {
            foreach (var cliente in fila)
                Console.WriteLine(cliente);
        }
        else
        {
            Console.WriteLine("Nenhum cliente restante na fila.");
        }
    }
}