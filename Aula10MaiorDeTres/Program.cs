Console.WriteLine("Maior de Três");

//Entrada(Digitar os Três números)
Console.Write("Digite o primeiro número: ");
int primeiro = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int segundo = int.Parse(Console.ReadLine());

Console.Write("Digite o terceiro número: ");
int terceiro = int.Parse(Console.ReadLine());

if (primeiro == segundo && primeiro == terceiro)
{
    Console.WriteLine("Todos são iguais.");
}
else if (primeiro == segundo && primeiro > terceiro || primeiro == terceiro && primeiro > segundo || terceiro == segundo && terceiro > primeiro)
{
    Console.WriteLine("Empate entre os dois maiores.");
}
else if (primeiro > segundo && primeiro > terceiro)
{
    Console.WriteLine($"{primeiro} O maior é o primeiro");
}
else if (segundo > primeiro && segundo > terceiro)
{
    Console.WriteLine($"{segundo} O maior é o segundo");
}
else
{
    Console.WriteLine($"{terceiro} O maior é o terceiro");
}
