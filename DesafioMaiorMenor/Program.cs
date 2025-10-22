//Pedir para o usuário digitar dois números
//Em seguida verificar e exibir qual é o maior e o menor

int numero1;
int numero2;


Console.WriteLine("Qual é o primeiro numero?");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é o segundo numero?");
numero2 = int.Parse(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine($"O primeiro número é o maior: {numero1}");
}
else if (numero2 > numero1)
{
    Console.WriteLine($"O segundo número é o maior: {numero2}");
}
else
{
    Console.WriteLine($"Os dois numeros são iguais: {numero1} = {numero2}");
}




