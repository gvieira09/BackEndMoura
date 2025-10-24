double salarioRecebido, totalGasto;
Console.WriteLine("Informe o salário: ");
salarioRecebido = double.Parse(Console.ReadLine());
Console.WriteLine($"Informe o gasto do mês: ");
totalGasto = double.Parse(Console.ReadLine());

if (totalGasto > salarioRecebido)
{
    Console.WriteLine("Orçamento estourado!");
}
else
{
    Console.WriteLine($"Gastos do Orçamento!");
}