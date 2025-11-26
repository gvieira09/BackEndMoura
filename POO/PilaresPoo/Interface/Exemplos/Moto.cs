namespace Exemplos
{
    public class Moto : IMotor
    {
        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;

        public Moto(string c, string m, string md, int a)
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
           Console.WriteLine($"Moto acelerando... Breeeeeh");
        }


        public void Freiar()
        {
            Console.WriteLine($"Moto Freiando... irrrrrrrrrh");
        }
    }
}