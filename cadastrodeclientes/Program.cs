using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace CadastroClientes
{
    class Program
    {
        static List<Cliente> listaClientes = new List<Cliente>();
        static int proximoId = 1;

        static void Main(string[] args)
        {
            bool sistemaAtivo = true;

            while (sistemaAtivo)
            {
                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("1. Adicionar cliente");
                Console.WriteLine("2. Exibir clientes");
                Console.WriteLine("3. Editar cliente");
                Console.WriteLine("4. Excluir cliente");
                Console.WriteLine("5. Sair");

                int opcaoSelecionada;

                if(!int.TryParse(Console.ReadLine(), out opcaoSelecionada))
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }

                switch (opcaoSelecionada)
                {
                    case 1:
                        AdicionarCliente();
                        break;
                    case 2:
                        ExibirClientes();
                        break;
                    case 3:
                        EditarCliente();
                        break;
                    case 4:
                        ExcluirCliente();
                        break;
                    case 5:
                        sistemaAtivo = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        static void AdicionarCliente()
        {
            Console.WriteLine("Digite o nome do cliente: ");
            string nomeCliente = Console.ReadLine();

            Console.WriteLine("Digite o email do cliente: ");
            string emailCliente = Console.ReadLine();

            Cliente novoCliente = new Cliente(proximoId++, nomeCliente, emailCliente);
            listaClientes.Add(novoCliente);

            Console.WriteLine("Cliente adicionado com sucesso. ID: " + novoCliente.Id);
        }

        static void ExibirClientes()
        {
            if(listaClientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
                return;
            }

            foreach (Cliente clienteAtual in listaClientes)
            {
                Console.WriteLine($"ID: {clienteAtual.Id}");
                Console.WriteLine($"Nome: {clienteAtual.Nome}");
                Console.WriteLine($"Email: {clienteAtual.Email}");
                Console.WriteLine("-------------------------");
            }
        }

        static void EditarCliente()
        {
            int idCliente = LerId("Digite o ID do cliente que deseja editar: ");

            Cliente clienteParaEditar = listaClientes.Find(c => c.Id == idCliente);

            if(clienteParaEditar != null)
            {
                Console.WriteLine("Digite o novo nome do cliente (deixe em branco para manter o atual)");
                string novoNome = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(novoNome))
                {
                    clienteParaEditar.Nome = novoNome;
                }

                Console.WriteLine("Digite o novo email do cliente (deixe em branco para manter o atual)");
                string novoEmail = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(novoEmail))
                {
                    clienteParaEditar.Email = novoEmail;
                }
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }

        static void ExcluirCliente()
        {
            int idCliente = LerId("Digite o ID do cliente que deseja excluir: ");
            Cliente clienteParaExcluir = listaClientes.Find(c => c.Id == idCliente);

            if(clienteParaExcluir != null)
            {
                listaClientes.Remove(clienteParaExcluir);
                Console.WriteLine("Cliente excluído com sucesso.");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }

        static int LerId(string mensagem)
        {
            Console.WriteLine(mensagem);
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID inválido. Tente novamente.");
            }
            return id;
        }
    }

    class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Cliente(int id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }
            
    }
}