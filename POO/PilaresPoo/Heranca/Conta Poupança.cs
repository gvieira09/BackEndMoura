namespace Heranca
{
    public class ContaPoupanca : Conta
    {
        public double CalcularRendimento()
        {
            return saldoAtual = saldoaBase + (saldoaBase * 2 / 100);
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Saldo: {saldoaBase}");
        }

        public void ExibirInfo2()
        {
            Console.WriteLine($"Saldo Atual: {saldoAtual}");
        }

        public void Exibir()
        {
            Console.WriteLine($"Realizando Deposito...");
            Thread.Sleep(2000);

            Console.WriteLine($"Deposito Realizado");
        }

         public void Exibir2()
        {
            Console.WriteLine($"Realizando Saque...");
            Thread.Sleep(4000);

            Console.WriteLine($"Saque Realizado");
        }
    }
}