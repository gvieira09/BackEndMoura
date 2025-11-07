

namespace ClassesObjetos
{
    public class AgenciaBancaria
    {
        public string Titular = "";
        public float Saldo;

        public void Depositar(float _valorSaque)
        {
            if (_valorSaque <= 0)
            {
                Console.WriteLine($"O valor do saldo deve se maior do que R$ 0");
                return;
            }

            Saldo += _valorSaque;
            Console.WriteLine($"Depósito realizado com sucesso!. Novo saldo: {Saldo}");
        }
        
        public void Sacar(float _valorSaque)
        {

            if (_valorSaque <= 0 && _valorSaque < Saldo)
            {
                Console.WriteLine($"Saldo Atual: {Saldo}");
                Console.WriteLine($"Não é possível sacar este valor, verifique o saldo");
                return;
            }

            Saldo -= _valorSaque;

            Console.WriteLine($"Saque realizado. Novo Saldo: {Saldo}");

        }
    } 
}