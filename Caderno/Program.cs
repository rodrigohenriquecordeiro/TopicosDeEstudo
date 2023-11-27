Console.WriteLine("Digite 10 números\n");

int numeroDigitado, numeroMaior;

Console.Write("Digite o 1º número: ");
numeroMaior = int.Parse(Console.ReadLine());

for (int i = 2; i <= 10; i++)
{
    Console.Write($"Digite o {i}º número: ");
    numeroDigitado = int.Parse(Console.ReadLine());

    if (numeroDigitado > numeroMaior)
        numeroMaior = numeroDigitado;
}

Console.WriteLine($"Número Maior: {numeroMaior}");