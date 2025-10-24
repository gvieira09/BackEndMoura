using System.Net.WebSockets;
int opcao = -1;
Console.Clear();
Console.WriteLine($"-----------------------------------------");
Console.WriteLine($"              Bem Vindo                  ");
Console.WriteLine($"                 ao                      ");
Console.WriteLine($"            Jacareca Food                ");
Console.WriteLine($"-----------------------------------------");
Console.WriteLine($"");
Console.WriteLine($"");

Console.WriteLine($"Escolha uma opção:");
Console.WriteLine($"");
Console.WriteLine($" 1)  Hot Holl ........... R$ 20,00");
Console.WriteLine($" 2)  Temaki ............. R$ 33,00");
Console.WriteLine($" 3)  Yakisoba ........... R$ 50,00");
Console.WriteLine($" 4)  Guioza ............. R$ 30,00");
Console.WriteLine($"");
Console.WriteLine($" Sair");
Console.WriteLine($"Opção: ");
opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
       case 0:
       Console.WriteLine($"Saindo..");
       Console.WriteLine($"Digite <Enter> para continuar...");
       Console.WriteLine();
       break;
        
        case 1:
        Console.WriteLine($"Boa escolha, vamos perparar seu Hot Holl com carinho!");
        case 2:
        Console.WriteLine($"Boa escolha, vamos perparar seu Temaki com carinho!");
        case 3:
        Console.WriteLine($"Boa escolha, vamos perparar seu Yakisoba com carinho!");
        case 4:
        Console.WriteLine($"Boa escolha, vamos perparar seu Guioza com carinho!");
}
