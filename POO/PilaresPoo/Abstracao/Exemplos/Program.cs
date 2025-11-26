using Exemplos;

// Gato lia = new Gato();

// Cachorro Theo = new Cachorro();

// Pessoa Milena = new Pessoa();
// Milena.nome = "Milena Mares";
// Milena.idade = 17;
// Milena.Exibir();
// Milena.Dormir();
// Milena.FazerSom();
// Milena.Mover();

Console.WriteLine($"Conta Corrente:");
Contacorrente cc = new Contacorrente(10);
Console.WriteLine($"Saldo inicial da conta: {cc.Saldo}");
cc.Depositar(0.5);
Console.WriteLine($"Saldo apos deposito: R${cc.Saldo}");
cc.Sacar(10.01);
Console.WriteLine($"Saldo apos saque: R$ {cc.Saldo}");

Console.WriteLine();

Console.WriteLine($"Conta Poupança:");
Contacorrente cp = new Contacorrente(10);
Console.WriteLine($"Saldo inicial da conta: {cp.Saldo}");
cp.Depositar(0.5);
Console.WriteLine($"Saldo apos deposito: R${cp.Saldo}");
cp.Sacar(10.01);
Console.WriteLine($"Saldo apos saque: R$ {cp.Saldo}");


