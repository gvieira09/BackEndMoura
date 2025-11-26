namespace Exemplos
{
    public class Carro : IMotor
    {
        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;

        public Carro(string c, string m, string md, int a)
        {
            Cor = c;
            Marca = m;
            Modelo = md;
            Ano = a;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($@"Informações do Veiculo: 
            Marca : {Marca}
            Modelo : {Modelo}
            Ano : {Ano}
            Cor : {Cor}
            ");
             
        }

        public void Acelar()
        {
           Console.WriteLine($"Carro acelerando... Vrum Vrum");
        }


        public void Freiar()
        {
            Console.WriteLine($"Carro Freiando... irrrrh");
        }
    }
}