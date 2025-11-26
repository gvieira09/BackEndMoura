namespace Exemplos
{
    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
         Console.WriteLine($"AuAu");
        }
          public override void Mover()
        {
         Console.WriteLine($"Tec Tec");
        }
    }
}