
namespace Exercicio2
{
    public class Relatorio : IImprimivel
    {
        public string NomeResponsavel;
        public string TextoRelatorio;


         public Relatorio(string NR, string TR)
        {
            NomeResponsavel = NR;
            TextoRelatorio = TR;
        }
        public void Imprimir()
        {
                Console.WriteLine($@"
    NomeResponsavel:{NomeResponsavel}
    TextoRelatorio:{TextoRelatorio}
            ");
        }

    }
}