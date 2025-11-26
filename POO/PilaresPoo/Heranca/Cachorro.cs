namespace Heranca
{
    public class Cachorro : Animal
    {
        public string Raca;

        public string Nome;

        public int Idade;

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}, Raça: {Raca} e Idade: {Idade}");
            
        }
        public void FazerSom()
        {
            Console.WriteLine($"AU AU AU AU");

        }
    }
}

