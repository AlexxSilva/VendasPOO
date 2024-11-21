public class Servico : IProduto
{
    public string Nome { get; private set; }
    public int HorasTrabalhadas { get; private set; }
    public decimal ValorPorHora { get; private set; }

    public Servico(string nome, int horasTrabalhadas, decimal valorPorHora)
    {
        Nome = nome;
        HorasTrabalhadas = horasTrabalhadas;
        ValorPorHora = valorPorHora;
    }

    public decimal CalcularPreco()
    {
        return HorasTrabalhadas * ValorPorHora;
    }
}