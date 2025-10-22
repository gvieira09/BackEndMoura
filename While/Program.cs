int contador = 1;//4

Console.WriteLine($"Qantas vezes voce quer rodar o while:");

int qtdVezes = int.Parse(Console.ReadLine());

while (contador <= qtdVezes)
{
    Console.WriteLine($"contador é: {contador}");
    contador++;
}

