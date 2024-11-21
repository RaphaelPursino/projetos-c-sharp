class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        string palavraInvertida = InverterString(palavra);
        Console.WriteLine("Palavra invertida: " + palavraInvertida);
    }

    static string InverterString(string palavra)
    {
        char[] array = palavra.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
}