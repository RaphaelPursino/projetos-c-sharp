class Program
{
    static void Main()
    {
        Dictionary<string, string> agenda = new Dictionary<string, string>();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Adicionar contato");
            Console.WriteLine("2 - Buscar contato");
            Console.WriteLine("3 - Remover contato");
            Console.WriteLine("4 - Exibir todos os contatos");
            Console.WriteLine("5 - Sair");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Número de telefone: ");
                    string telefone = Console.ReadLine();
                    agenda[nome] = telefone;
                    Console.WriteLine("Contato adicionado.");
                    break;

                case "2":
                    Console.Write("Nome do contato: ");
                    nome = Console.ReadLine();
                    if (agenda.TryGetValue(nome, out telefone))
                    {
                        Console.WriteLine($"{nome}: {telefone}");
                    }
                    else
                    {
                        Console.WriteLine("Contato não encontrado.");
                    }
                    break;

                case "3":
                    Console.Write("Nome do contato para remover: ");
                    nome = Console.ReadLine();
                    if (agenda.Remove(nome))
                    {
                        Console.WriteLine("Contato removido.");
                    }
                    else
                    {
                        Console.WriteLine("Contato não encontrado.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Contatos na agenda:");
                    foreach (var contato in agenda)
                    {
                        Console.WriteLine($"{contato.Key}: {contato.Value}");
                    }
                    break;

                case "5":
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
