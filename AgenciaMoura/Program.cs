string[] nomes = new string[10];
float[] saldos = new float[10];
int totalClientes = 0;

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($"=== SISTEMA BANCÁRIO SIMPLES ===");
    Console.WriteLine($"1) Cadastrar Cliente");
    Console.WriteLine($"2) Depositar");
    Console.WriteLine($"3) Sacar");
    Console.WriteLine($"4) Transferir");
    Console.WriteLine($"5) Listar Clientes");
    Console.WriteLine($"0) Sair");
    Console.WriteLine($"Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando o programa...");
            break;
        case 1:
            CadastrarCliente();
            break;
        case 2:
            Depositar();
            break;
        case 3:
            Sacar();
            break;
        case 4:
            Transferir();
            break;
        case 5:
            ListarClientes();
            break;
        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }

    Console.WriteLine($"Pressione <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);

void CadastrarCliente()
{
    Console.WriteLine($"=== Cadastro de Clientes ===");

    //verificar se eu posso cadastrar
    if (totalClientes >= 10)
    {
        Console.WriteLine($"Limite de clientes atingido");
        return;
    }

    Console.WriteLine($"Nome do cliente: ");
    nomes[totalClientes] = Console.ReadLine();
    saldos[totalClientes] = 0;
    totalClientes++;

    Console.WriteLine($"cliente cadastrado com sucesso!");
}
void Depositar()
{
    Console.WriteLine($"Função depositar em desenvolvimento");
}
void Sacar()
{
    Console.WriteLine($"Função sacar em desenvolvimento");
}
void Transferir()
{
    Console.WriteLine($"Função transferir em desenvolvimento");
}
void ListarClientes()
{
 Console.WriteLine($"=== Listagem de Clientes ===");

   for (int t = 0; t < totalClientes; t++)
   {
    Console.WriteLine($"Nome: {nomes[t]}, R$ {saldos[t]}");
   }
}