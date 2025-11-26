public class Circulo : IForma
    {
        float r1;
        double resultado;

        public void Perguntas()
        {
            Console.WriteLine($"Digite o Raio do Circulo");
            r1 = float.Parse(Console.ReadLine());
        }

        public void CalcularArea()
        {
            resultado = Math.PI * Math.Pow(r1, 2);
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Raio do Circulo: {r1}");
            Console.WriteLine($"Area Calculada: {resultado}");
        }
    }