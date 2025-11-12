   namespace Heranca
{
    public class Aviao : Veiculo
    {
        public int qtdAsas;

        public void Voar()
        {
            Console.WriteLine($"Aviao levantou voo!");
        }
        

          public void Acelerar()
        {
            Console.WriteLine($"Acelerando o aviao");
            
        }
    }
}