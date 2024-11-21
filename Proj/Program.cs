
var cliente = new Cliente("Alex Silva", "alex.silva@email.com");

// Criando produtos
IProduto notebook = new ProdutoFisico("Notebook", 3500m, 2.5m, 20m);
IProduto manutencao = new Servico("Manutenção", 5, 150m);

// Criando pedido
var pedido = new PedidoVenda(cliente);
pedido.AdicionarProduto(notebook);
 pedido.AdicionarProduto(manutencao);

// Exibindo resumo
pedido.ExibirResumo();
