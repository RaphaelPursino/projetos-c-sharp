using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string senha;

        do
        {
            Console.Write("Crie uma senha: ");
            senha = Console.ReadLine();

            if (!ValidarSenha(senha))
            {
                Console.WriteLine("Senha inválida! A senha deve conter:\n- Pelo menos 8 caracteres\n- Pelo menos uma letra maiúscula\n- Pelo menos uma letra minúscula\n- Pelo menos um número");
            }
        }
        while (!ValidarSenha(senha));

        Console.WriteLine("Senha válida!");
    }

    static bool ValidarSenha(string senha)
    {
        if (senha.Length < 8)
            return false;

        if (!Regex.IsMatch(senha, @"[A-Z]"))
            return false;

        if (!Regex.IsMatch(senha, @"[a-z]"))
            return false;

        if (!Regex.IsMatch(senha, @"[0-9]"))
            return false;

        return true;
    }
}