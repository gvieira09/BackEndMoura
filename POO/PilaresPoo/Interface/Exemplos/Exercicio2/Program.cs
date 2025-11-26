using System.Net.WebSockets;
using Exercicio2;


List<IImprimivel> documentos = new List<IImprimivel>();

int opcao;

do
{
    Console.Clear();
    Console.Write($@"Menu de Opcoes
    1) Cadastrar Fatura
    2) Cadastrar Relatorio
    3) Cadastrar Contrato
    4) Listar Fatura
    5) Listar Relatorio
    6) Listar Contrato
    0) Sair
    Escolha uma opcao:
    ");
    opcao = int.Parse(Console.ReadLine());

   switch (opcao)
   {
        case 1:
        CadastrarFaturas();
            break;
        case 2:
        CadastrarRelatorios();
            break;
        case 3:
        CadastrarContratos();
            break;
        case 4:
        ListarFaturas();
            break;
        case 5:
        ListarRelatorios();
            break;
        case 6:
        ListarContrato();
            break;
        case 0:
        Console.WriteLine($"Sair");
            break;
    default:
    Console.WriteLine($"Opcao Invalida!");
        break;
   }

    Console.WriteLine($"Pressione <ENTER> para continuar");
    Console.ReadLine();
    
    
} while (opcao != 0);

void CadastrarFaturas()
{
    Console.WriteLine($"Digite o nome do cliente Devedor");
    string dev = Console.ReadLine();

    Console.WriteLine($"Digite o nome da Empresa");
    string empresa = Console.ReadLine();

    Console.WriteLine($"Digite o Valor");
    float valor = float.Parse (Console.ReadLine());
    
    Console.WriteLine($"Dias de atraso da fatura?");
    int qtdDiasAtraso = int.Parse(Console.ReadLine());

    Console.WriteLine($"Fatura calculada com sucesso!");
    

    Fatura fat = new Fatura(dev, empresa, valor, qtdDiasAtraso);
    documentos.Add(fat);
    
    
}
void CadastrarRelatorios()
{
    Console.WriteLine($"Digite o Nome do Responsavel:");
    string NR = Console.ReadLine();

    Console.WriteLine($"Digite o Texto Relatorio:");
    string TR = Console.ReadLine();

    Relatorio relatorio = new Relatorio(NR, TR);
    relatorio.NomeResponsavel = NR;
    relatorio.TextoRelatorio = TR;
    documentos.Add(relatorio);
    Console.WriteLine($"Relatorio cadastrado com sucesso!");
    
    
}
void CadastrarContratos()
{
    Console.WriteLine($"Digite o Nome para o contrato:");
    string N = Console.ReadLine();

    Console.WriteLine($"Qual o Texto da Clausula do contrato:");
    string TX = Console.ReadLine();

    Contrato contrato = new Contrato(N, TX);
    contrato.Nome = N;
    contrato.TextoClausulas = TX;
    documentos.Add(contrato);
    Console.WriteLine($"Contrato cadastrado com sucesso!");
    
    
}
void ListarFaturas()
{
    Console.WriteLine($"Listando Faturas:");
    foreach (var item in documentos)
    {
       if (item is Fatura)
       {
            item.Imprimir();
       } 
    }
    
}
void ListarRelatorios()
{
        Console.WriteLine($"Listando Relatorios:");
    foreach (var item in documentos)
    {
       if (item is Relatorio)
       {
            item.Imprimir();
       } 
    }
}
void ListarContrato()
{
            Console.WriteLine($"Listando Contratos:");
    foreach (var item in documentos)
    {
       if (item is Contrato)
       {
            item.Imprimir();
       } 
    }

}




    
    





























// //Cria um objeto de cada classe e adiciona nas listas
// Fatura fatGui = new Fatura();
// documentos.Add(fatGui);

// Fatura fatMika = new Fatura();
// documentos.Add(fatMika);


// Relatorio relGui = new Relatorio();
// documentos.Add(relGui);


// Contrato contGui = new Contrato();
// documentos.Add(contGui);

// //lista os dados da fatura 

// Console.WriteLine($"Faturas");
// foreach ( var fat in documentos)
// {
//     if (fat is Fatura)
//     {fat.Imprimir();}
// }

// Console.WriteLine($"Contratos");

// foreach ( var item in documentos)
// {
//     if (item is Contrato)
//     {
//         item.Imprimir();
//     }

// }

// Console.WriteLine($"Relatorios");
// foreach ( var item in documentos)
// {
//     if (item is Relatorio)
//     {
//         item.Imprimir();
//     }
// }

