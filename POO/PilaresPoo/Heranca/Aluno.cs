namespace Heranca
{
    public class Aluno : Pessoa
    {
        public string curso;


        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Curso: {curso}");
        }
    }
}