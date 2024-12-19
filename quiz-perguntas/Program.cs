class Program
{
    static void Main()
    {
        Console.WriteLine("Qual a capital do Brasil?");
        Console.WriteLine("1. Rio de Janeiro");
        Console.WriteLine("2. Brasília");
        Console.WriteLine("3. São Paulo");

        int resposta = int.Parse(Console.ReadLine());

        if (resposta == 2)
        {
            Console.WriteLine("Resposta correta!");
        } else
        {
            Console.WriteLine("Errado! A resposta certa é Brasília.");
        }
    }
}