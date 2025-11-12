namespace Heranca
{
    public class Gato : Animal
    {
        public string Nome;

        public string Raca;

        public int Idade;


        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}, Raça: {Raca} e Idade: {Idade}");
            
        }
        public void FazerSom()
        {
            Console.WriteLine($"Miau Miau Miau");

        }
    }
}

