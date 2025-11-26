namespace Exercicio2
{
     public class Contrato : IImprimivel
    {
        public string Nome;
        public string TextoClausulas;

         public Contrato (string N, string TC)
        {
            Nome = N;
            TextoClausulas = TC;
        }
        public void Imprimir()
        {
            Console.WriteLine($@"
    Nome:{Nome}
    TextoClausula:{TextoClausulas}
            ");
            
        }

    }
}