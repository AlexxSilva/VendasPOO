public class ProdutoFisico : IProduto
{
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }
    public decimal Peso { get; private set; }
    public decimal TaxaFrete { get; private set; }

    public ProdutoFisico(string nome, decimal preco, decimal peso, decimal taxaFrete)
    {
        Nome = nome;
        Preco = preco;
        Peso = peso;
        TaxaFrete = taxaFrete;
    }

    public decimal CalcularPreco()
    {
        return Preco + (Peso * TaxaFrete);
    }
}