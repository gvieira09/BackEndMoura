using System.Net.WebSockets;
using ClassesEstaticas;
// Console.WriteLine($"Número de PI: {CalculoMatematico.PI} ");

// Console.WriteLine($"Digite o primeiro número: ");
// float n1 = float.Parse(Console.ReadLine());
// Console.WriteLine($"Digite o segundo número: ");
// float n2 = float.Parse(Console.ReadLine());

// Console.WriteLine($"Resultados: ");
// Console.WriteLine($"Soma: {CalculoMatematico.Somar(n1, n2)}");
// Console.WriteLine($"Subtração: {CalculoMatematico.Subtrair(n1, n2)}");
// Console.WriteLine($"Multiplicação: {CalculoMatematico.Multiplicar(n1, n2)}");
// Console.WriteLine($"Divisão: {CalculoMatematico.Dividir(n1, n2)}");

Console.Clear();

Console.WriteLine($"Digite o primeiro numero:");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo numero:");
float n2 = float.Parse(Console.ReadLine());

float maior = Math.Max(n1 , n2);
float menor = Math.Min(n1, n2);

Console.WriteLine($"=======RESULTADOS=======");
Console.WriteLine($"Numero maior eh{maior}");
Console.WriteLine($"Numero menor eh{menor}");






