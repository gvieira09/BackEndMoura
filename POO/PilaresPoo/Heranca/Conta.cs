namespace Heranca
{
    public class Conta
    {
        public float numero;
        public double saldoaBase;
        public double saldoAtual;
        public double QntdDeposito;
        public double QntdSacar;


        public void ExibirInfo()
        {
            Console.WriteLine($"Saldo: {saldoaBase}");
        }

        public void ExibirInfo2()
        {
            Console.WriteLine($"Saldo Atual: {saldoAtual}");
        }

        public double Depositar()
        {
            return saldoAtual = saldoaBase += QntdDeposito;
        }

        public double Sacar()
        {
            if (QntdSacar <= 0)
            {
                Console.WriteLine($"Valor Invalido");
                return saldoaBase;
            }
            else if (QntdSacar > saldoaBase)
            {
                Console.WriteLine($"Saldo Insuficiente para Saque!!!");
                return saldoaBase;
            }
            else
            {
                return saldoAtual = saldoaBase -= QntdSacar;
            }
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