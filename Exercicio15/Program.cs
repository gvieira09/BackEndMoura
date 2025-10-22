float nota1, nota2, nota3, nota4, media;

Console.WriteLine("Digite o primeiro numero");
nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro numero");
nota3 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o quarto numero");
nota4 = float.Parse(Console.ReadLine());

media = (nota1, nota2, nota3, nota4) / 4

Console.WriteLine($"Média: {media}");

if (media >= 7)
{
    Console.WriteLine("Aprovado");
}
else if (media >= 5)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}





