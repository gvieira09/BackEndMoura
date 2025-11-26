namespace Heranca
{
    public class Funcionario
    {
        public string nome;
        public double salarioBase;

        public double CalcularSalario()
        {
            return salarioBase + (salarioBase * 25 / 100);
        }

        public void ExibirSalario()
        {
            double salarioTotal = CalcularSalario();
            Console.WriteLine($"Salario Base: {salarioBase}");
            Console.WriteLine($"Salario Total: {salarioTotal}");
        }
    }
}