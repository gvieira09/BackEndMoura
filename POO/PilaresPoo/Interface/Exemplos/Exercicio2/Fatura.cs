
namespace Exercicio2
{
   public class Fatura : IImprimivel
    {   
        public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public int DiasAtrasados = 0;
        public float juros = 0.10f;

        public Fatura(string nomeDevedor, string nomeEmpresa, float valorFatura, int qtdDiasAtraso)
        {
            Devedor = nomeDevedor;
            Credor = nomeEmpresa;
            Valor = valorFatura;
            DiasAtrasados = qtdDiasAtraso;
        }

        public void CalcularValorDivida()
        {
            if (DiasAtrasados > 0)
            {
                Valor = Valor + DiasAtrasados * juros;
            }

            if (DiasAtrasados >= 5)
            {
                Console.WriteLine($"Divida encaminhada para o SERASA"); 
            }
        }
        public void Imprimir()
        {
            CalcularValorDivida();
            
            Console.WriteLine($@"
    Credor:{Credor}
    Devedor:{Devedor}
    DiasAtrasados:{DiasAtrasados}
    Juros:{juros * DiasAtrasados}
    Valor Total:{Valor}
            ");
        }
    }
}
