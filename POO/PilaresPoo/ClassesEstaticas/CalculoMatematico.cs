namespace ClassesEstaticas
{
    public static class CalculoMatematico
    {
        public static double PI = 3.14;

        public static float Somar(float x, float y)
        {
         return x + y;
            
        }

        public static float Subtrair(float x, float y)
        {
         return x - y;
            
        }

        public static float Multiplicar(float x, float y)
        {
         return x * y;
            
        }

        public static float Dividir(float x, float y)
        {
            if (y == x)
            {
                Console.WriteLine($"Divisão Invalida");
                
            }
         return x / y;
            
        }
    }
}