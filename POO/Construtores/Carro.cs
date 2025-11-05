

namespace Construtores
{
    public class Carro
    {
        public string Marca;
        public string Modelo;
        public int Ano;

        public Carro()
        {
            Console.WriteLine($"Objeto criado");
        } 
        
          public void ExibirDdados()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo:{Modelo}, Ano: {Ano}");
            
        }
    }
}