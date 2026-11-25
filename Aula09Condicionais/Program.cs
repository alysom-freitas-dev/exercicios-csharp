Console.WriteLine("Parte 1: Alerta de estoque ");
int estoqueMinimo = 50;

Console.Write("Digite o saldo do rótulo: ");
int saldo = int.Parse(Console.ReadLine());

if (saldo = 0)
{
    Console.WriteLine("Ruptura: sem estoque");
}
else if (saldo < estoqueMinimo)
{
    Console.WriteLine("Atenção: abaixo do mínimo");
}
else
{
    Console.WriteLine("Estoque Ok");
}

Console.WriteLine("Parte 2");
Console.Write("Digite um número");
int primeiro = int.Parse(Console.ReadLine());

Console.Write("Digite outro número");
int segundo = int.Parse(Console.ReadLine());

if (primeiro == segundo)
{
    Console.WriteLine("os dois são iguais");
}
else if (primeiro < segundo)
{
    Console.WriteLine($"O número {segundo} é maior que o número {primeiro}");
}
else
{
    Console.WriteLine($"O número {primeiro} é maior que o número {segundo}");
}