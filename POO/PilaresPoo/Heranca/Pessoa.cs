namespace Heranca
{
    public class Pessoa
    {
        public string nome;
        public int idade;


        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
        }
    }
}