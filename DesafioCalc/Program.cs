//Pedir para o usuário digitar dois números e exibir a soma desses dois números

float numero1;
float numero2;
float soma;

Console.WriteLine("Qual é o primeiro numero?");
numero1 = float.Parse(Console.ReadLine());

Console.WriteLine("Qual é o segundo numero?");
numero2 = float.Parse(Console.ReadLine());

soma = numero1 + numero2;

Console.WriteLine($"A soma de {numero1} + {numero2} + é {soma}");
