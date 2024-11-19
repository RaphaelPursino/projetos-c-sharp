class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos números deseja adicionar?");
        int quantidade = int.Parse(Console.ReadLine());

        int[] numeros = new int[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Digite o número {i + 1}");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int maior = numeros[0];
        int menor = numeros[0];

        foreach (int numero in numeros)
        {
            if (maior > numero) maior = numero;
            if (menor < numero) menor = numero;
        }

        Console.WriteLine($"Maior: {maior}, Menor: {menor}");
    }
}