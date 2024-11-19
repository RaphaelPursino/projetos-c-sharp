class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 5, 10, 15, 20 };
        Console.WriteLine("Qual número você deseja buscar: ");
        int busca = int.Parse(Console.ReadLine());

        int indice = Array.IndexOf(numeros, busca);
        if (indice >= 0)
        {
            Console.WriteLine($"Número encontrado na posição: {indice + 1}");
        }
        else
        {
            Console.WriteLine("Número não encontrado.");
        }
    }
}