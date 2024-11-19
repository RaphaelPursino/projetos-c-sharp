class Program
{
    static void Main(string[] args)
    {
        int number1 = 10;
        int number2 = 20;

        bool saoIguais = VerificarSeIguais(number1, number2);

        if (saoIguais)
        {
            Console.WriteLine("Os números são iguais.");
        }
        else
        {
            Console.WriteLine("Os números são diferentes.");
        }
    }

    static bool VerificarSeIguais(int number1, int number2)
    {
        return number1 == number2;
    }
}