class Program
{
    static void Main(string[] args)
    {
        Random aleatorio = new Random();
        int numeroSecreto = aleatorio.Next(1, 101);

        int palpite;

        do
        {
            Console.WriteLine("Adivinhe o número de 1 a 100");
            palpite = int.Parse(Console.ReadLine());

            if (palpite < numeroSecreto) Console.WriteLine("Muito baixo!");
            else if (palpite > numeroSecreto) Console.WriteLine("Muito alto!");
        }
        while (palpite != numeroSecreto);

        Console.WriteLine("Parabéns, você acertou!");
    }
}