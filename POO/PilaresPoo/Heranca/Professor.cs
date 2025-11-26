namespace Heranca
{
    public class Professor : Pessoa
    {
        public string disciplina;


        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Disciplina: {disciplina}");
        }
    }
}