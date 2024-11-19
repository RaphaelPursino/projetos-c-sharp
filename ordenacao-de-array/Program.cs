class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos números deseja inserir?");
        int n = int.Parse(Console.ReadLine());

        int[] numeros = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Digite um número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numeros);

        Console.WriteLine("Número em ordem crescente: ");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero + " ");
        }
    }
}