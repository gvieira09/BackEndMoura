namespace Exemplos
{
      public class Contacorrente : Contabancaria
    {
        public double Saldo = 0;
        private double TaxaSaque = 5;


        public Contacorrente (double saldoInicial)
        {
            Saldo = saldoInicial;
        }



        public override void Depositar(double valor)
        {
            if(valor <= 0)
            {
                Console.WriteLine($"O valor do deposito deve ser positivo!"); 
                return;
            }
            Saldo += valor;
        }

        public override void Sacar(double valor)
        {

            double TotalComTaxa = valor / 100 *TaxaSaque + valor;

            if(valor <= 0 || Saldo >= TotalComTaxa)
            {
                Console.WriteLine($"O valor do saque deve ser positivo e de ter dinheiro na conta");
                return;
            }

            Saldo -= TotalComTaxa;
        }

    }
}

