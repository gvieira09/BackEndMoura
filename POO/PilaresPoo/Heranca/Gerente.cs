namespace Heranca
{
    public class Gerente : Funcionario
    {
        public void ExibirSalario()
        {
            double salarioTotal = CalcularSalario();
            Console.WriteLine($"Salario Base: {salarioBase}");
            Console.WriteLine($"Salario Total: {salarioTotal}");
        }
    }
}
