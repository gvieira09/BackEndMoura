using ClassesObjetos;

// Garrafa Tupperware = new Garrafa();
// Tupperware.Cor = "Vermelho";
// Tupperware.Capacidade = 500;
// Tupperware.Tamanho = 27;
// Tupperware.Formato = "Arredondada";
// Tupperware.Abrir();
// Tupperware.Beber();

// Garrafa Stanley = new Garrafa();
// Stanley.Cor = "Preta";
// Stanley.Capacidade = 500;
// Stanley.Formato = "Cilíndrico";
// Stanley.Tamanho = 20;
// Console.Write($"Abrindo a garrafa Stanley: ");
// Stanley.Abrir();

// Console.Write($"Bebendo água da garrafa: ");
// Stanley.Beber();

// Console.Clear();
// Console.WriteLine($"== Agencia Bancária ==");
// Console.WriteLine();

// AgenciaBancaria contaDoGuilherme = new AgenciaBancaria();

// contaDoGuilherme.Titular = "Guilherme Vieira";
// contaDoGuilherme.Saldo = 1000.98f;

// contaDoGuilherme.Depositar(500);

// contaDoGuilherme.Sacar(1500);



ProdutoDesconto panela = new ProdutoDesconto();
panela.nome = "Panela de Pressao Tramontina";
panela.preco = 200;

Console.WriteLine($"{panela.nome} custa {panela.preco}");

panela.AplicarDesconto(20);
