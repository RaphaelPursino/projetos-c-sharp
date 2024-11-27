class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Estoque { get; set; }
}

class Program
{
    static List<Produto> produtos = new List<Produto>();

    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n--- Sistemas de Cadastro de Produtos ---");
            Console.WriteLine("1. Adicionar novo produto");
            Console.WriteLine("2. Listar produtos cadastrados");
            Console.WriteLine("3. Atualizar estoque de um produto");
            Console.WriteLine("4. Sair");
            Console.WriteLine("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarProduto();
                    break;
                case 2:
                    ListarProdutos();
                    break;
                case 3:
                    AtualizarEstoque();
                    break;
                case 4:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }
        }
        while (opcao != 4);
    }

    static void AdicionarProduto()
    {
        Console.WriteLine("\n--- Adicionar Novo Produto ---");
        Produto novoProduto = new Produto();

        Console.Write("Nome do produto: ");
        novoProduto.Nome = Console.ReadLine();

        Console.Write("Preço do produto: ");
        novoProduto.Preco = decimal.Parse(Console.ReadLine());

        Console.Write("Quantidade em estoque: ");
        novoProduto.Estoque = int.Parse(Console.ReadLine());

        produtos.Add(novoProduto);
        Console.WriteLine("Produto adicionado com sucesso.");
    }

    static void ListarProdutos()
    {
        Console.WriteLine("\n--- Lista de Produtos Cadastrados");
        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
            return;
        }

        foreach (var produto in produtos)
        {
            Console.WriteLine($"Nome: {produto.Nome}");
            Console.WriteLine($"Preço: {produto.Preco}");
            Console.WriteLine($"Estoque: {produto.Estoque}");
            Console.WriteLine("-----------------------------");
        }
    }

    static void AtualizarEstoque()
    {
        Console.WriteLine("\n--- Atualizar Estoque ---");
        Console.Write("Digite o nome do produto: ");
        string nomeProduto = Console.ReadLine();

        Produto produtoEncontrado = produtos.Find(p => p.Nome.Equals(nomeProduto, StringComparison.OrdinalIgnoreCase));

        if (produtoEncontrado == null)
        {
            Console.WriteLine("Produto não encontrado.");
            return;
        }

        Console.Write($"Estoque atual: {produtoEncontrado.Estoque}. Digite a nova quantidade: ");
        produtoEncontrado.Estoque = int.Parse(Console.ReadLine());

        Console.WriteLine("Estoque atualizado com sucesso.");
    }
}