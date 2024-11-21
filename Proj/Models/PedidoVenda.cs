public class PedidoVenda
{
    public Cliente Cliente { get; private set; }
    private List<IProduto> itens;

    public PedidoVenda(Cliente cliente)
    {
        Cliente = cliente;
        itens = new List<IProduto>();
    }

    public void AdicionarProduto(IProduto produto)
    {
        itens.Add(produto);
    }

    public decimal CalcularTotal()
    {
        return itens.Sum(produto => produto.CalcularPreco());
    }

    public void ExibirResumo()
    {
        Console.WriteLine("Resumo do Pedido:");
        Cliente.ExibirDados();
        foreach (var item in itens)
        {
            Console.WriteLine($"- {item.Nome}: R$ {item.CalcularPreco():F2}");
        }
        Console.WriteLine($"Total: R$ {CalcularTotal():F2}");
    }
}
