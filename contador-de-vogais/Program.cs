class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase: ");
        string frase = Console.ReadLine().ToLower();

        int contadorVogais = 0;

        foreach (char c in frase)
        {
            if ("aeiou".Contains(c))
            {
                contadorVogais++;
            }
        }

        Console.WriteLine($"Número de vogais: {contadorVogais}");
    }
}