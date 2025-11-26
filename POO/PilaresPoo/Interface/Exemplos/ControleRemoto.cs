namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int VolumeMaximo = 0;
        public int NivelVolume = 100;
    

        public void Ligar()
        {
           Console.WriteLine($"TV ligando..");
        }


        public void Desligar()
        {
            Console.WriteLine($"TV desligando..");
        }  

         public void AumentarVolume()
        {
            if (NivelVolume == VolumeMaximo)
            {
                Console.WriteLine($"Volume Maximo Atingido {NivelVolume}");
                return;
            }
            NivelVolume++;
            Console.WriteLine($"Volume:{NivelVolume}");
        } 

         public void DiminuirVolume()
        {
            if (NivelVolume == 0)
            {
                Console.WriteLine($"Volume minimo atingido {NivelVolume}");
                
            }
            NivelVolume--;
            Console.WriteLine($"Volume:{NivelVolume}");
        } 
    }
}