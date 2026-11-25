Console.WriteLine("Parte 1");
Console.Write("Digite o código do rótulo: ");
string produto = Console.ReadLine();

Console.Write("Saldo inicial: ");
int saldoInicial = int.Parse(Console.ReadLine());

Console.Write("Digite as entradas: ");
int entradas = int.Parse(Console.ReadLine());

Console.Write("Digite as saídas: ");
int saidas = int.Parse(Console.ReadLine());

int saldoFinal = saldoInicial + entradas - saidas;
Console.WriteLine($"Produto: {produto} | Saldo final: {saldoFinal}"); 


