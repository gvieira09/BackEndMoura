

namespace Exemplos
{
    public class Pessoa : Animal
    {
         public string  nome;
         public int idade;

         public void Dormir()
        {
       
         Console.WriteLine($"ZZZZZZZZZ");
        }
        public override void FazerSom()
        {
       
         Console.WriteLine($"Bruglin");
        }

        public override void Mover()
        {
       
         Console.WriteLine($"Clac Clac");
        }

        public void Exibir()
        {
       
         Console.WriteLine($"Nome: {nome}");
         Console.WriteLine($"Idade: {idade}");
        }
    }
}