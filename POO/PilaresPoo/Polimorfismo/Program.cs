using ExercicoPolimorfismo;

PagamentoPIX compraPix = new PagamentoPIX();
compraPix.ValorCompra = 4000;

float valorPagar = compraPix.CalcularTotal();
Console.WriteLine($"Produto: Smartphone");
Console.WriteLine($"Preço: {compraPix.ValorCompra}");
Console.WriteLine($"Pagamento om desconto: {valorPagar}");

Console.WriteLine();

PagamentoCartao compraCartao = new PagamentoCartao();
compraCartao.ValorCompra = 50;

Console.WriteLine($"Produto: Caneca");
Console.WriteLine($"Preço: {compraCartao.ValorCompra}");
Console.WriteLine($"Forma de Pagamento: Cartão");
Console.WriteLine($"Pagamento om acréscimo: {compraCartao.CalcularTotal}");