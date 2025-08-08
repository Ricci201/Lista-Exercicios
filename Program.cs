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

        // Criar a fila de atendimento
        Queue<string> fila = new Queue<string>();

        // Inserir pelo menos 5 nomes de clientes
        fila.Enqueue("Lula Presidente");
        fila.Enqueue("Maria Antonella");
        fila.Enqueue("Carlos Andrade");
        fila.Enqueue("Ana Banana");
        fila.Enqueue("Pedro ANdrade");

        Console.WriteLine("Fila inicial:");
        foreach (string cliente in fila)
        {
            Console.WriteLine(cliente);
        }

        // Atender (remover) o primeiro cliente e exibir o nome
        string primeiroAtendido = fila.Dequeue();
        Console.WriteLine($"\nAtendendo cliente: {primeiroAtendido}");

        // Pesquisar se um cliente específico está na fila e sua posição
        _ = fila.Contains("Lula Presidente");

        if (achou)
            Console.WriteLine("\nNome Encontrado");
        else
            Console.WriteLine("\nO Nome não está na lista");

        // Remover outro cliente da fila
        string segundoAtendido = fila.Dequeue();
        Console.WriteLine($"\nRemovendo cliente: {segundoAtendido}");

        // Exibir todos os clientes restantes
        Console.WriteLine("\nClientes restantes na fila:");
        foreach (string cliente in fila)
        {
            Console.WriteLine(cliente);
        }

        Console.WriteLine("\nFim do programa.");

        Console.WriteLine("************************* Atividade 04 ************************");

        Stack<string> historico = new Stack<string>();

        historico.Push("www.google.com");
        historico.Push("www.github.com");
        historico.Push("www.stackoverflow.com");
        historico.Push("www.microsoft.com");
        historico.Push("www.reddit.com");

        // Mostrando o próximo da pilha sem removê-lo
        Console.WriteLine($"\nPágina atual: {historico.Peek()}");

        string paginaAnterior = historico.Pop();
        Console.WriteLine($"\nVoltando para a página: {paginaAnterior}");

        bool visitou = historico.Contains("www.github.com");
        if (visitou)
            Console.WriteLine("\nA página foi visitada");
        else
            Console.WriteLine("\nA página não foi visitada");

        Console.WriteLine("\nHistórico atual:");
        foreach (string pagina in historico)
        {
            Console.WriteLine(pagina);
        }
    }
}
