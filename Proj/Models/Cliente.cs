public class Cliente
{
    public string Nome { get; private set; }
    public string Email { get; private set; }

    public Cliente(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Cliente: {Nome}");
        Console.WriteLine($"Email: {Email}");
    }
}