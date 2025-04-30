using Model;

List<Product> produtoList = new List<Product>();

Console.Clear();

Console.Write("Quantos produtos você deseja cadastrar? ");
int numProdutos = int.Parse(Console.ReadLine());

for (int i = 0; i < numProdutos; i++){
    
    Console.WriteLine($"\nCadastro do Produto {i + 1}");
    Console.Write("Digite o nome do produto: ");
    string produtoNome = Console.ReadLine();

    Console.Write("Digite a quantidade do produto: ");
    int quantidade = int.Parse(Console.ReadLine());

    Console.Write("Digite o preco do produto: ");
    decimal precoProduto = decimal.Parse(Console.ReadLine());

    Console.Write("Digite a moeda (ex: USD, BRL, EUR...): ");
    string moeda = Console.ReadLine();

    Price price = new Price(precoProduto, moeda);
    Product produto = new Product(produtoNome, quantidade, price);
    
    produtoList.Add(produto);
}

Console.WriteLine("\nProdutos cadastrados:");

foreach (Product prod in produtoList)
    Console.WriteLine(prod.Display());