
namespace Encapsulamento
{
    public class ContaBancaria
    {
        public float Saldo;

        public void Depositar(float valor)
        {
            Saldo += valor;
        }
        public float GetSaldo()
        {
            return Saldo;
        }
        public void Sacar(float valor)
        {
            Saldo -= valor;
        }
    }
}