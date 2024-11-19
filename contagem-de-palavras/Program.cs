class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase: ");
        string frase = Console.ReadLine();

        Dictionary<string, int> contagemPalavras = new Dictionary<string, int>();

        string[] palavras = frase.Split(' ');

        foreach (string palavra in palavras)
        {
            if (contagemPalavras.ContainsKey(palavra))
            {
                contagemPalavras[palavra]++;
            }
            else
            {
                contagemPalavras[palavra] = 1;
            }
        }

        foreach (var par in contagemPalavras)
        {
            Console.WriteLine($"{par.Key}: {par.Value}");
        }
    }
}