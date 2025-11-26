

public class Retangulo : IForma
    {
        float r1;
        float r2;
        double resultado;

        public void Perguntas()
        {
            Console.WriteLine($"Digite a Largura do Retangulo");
            r1 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a Altura do Retangulo");
            r2 = float.Parse(Console.ReadLine());
        }

        public void CalcularArea()
        {
            resultado = r1 * r2;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Largura do Retangulo: {r1}");
            Console.WriteLine($"Altura do Retangulo: {r2}");
            Console.WriteLine($"Area Calculada: {resultado}");
        }
    }
