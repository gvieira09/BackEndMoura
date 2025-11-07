namespace PrimeiraClasse
{
    public class Pessoa
    {
        //atributos
        public string nome;
        public int idade = 0;
        public int altura;

        // métodos
        public void Acordar()
        {
            Console.WriteLine($"uhaaaaaaa...");

        }

        public void Jogar()
        {
            Console.WriteLine($"BORAAAAAAAA, MAIS UMA!");
        }
        
        public void Envelhecer(int _id = 0 )
        {
            if (_id > 0)
            {
                idade+= _id;
            }
            else
            {
                idade++;
            }
           
        }
    }
}