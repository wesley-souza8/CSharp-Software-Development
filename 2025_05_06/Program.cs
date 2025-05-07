using Models;
using Repository;
using Utils;

ProdutoRepository repo = new ProdutoRepository();
byte opc;

do
{
    Menu.Show();
    opc = Menu.GetOption();

    switch (opc){
        case 1:
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preco: ");
            decimal preco = decimal.Parse(Console.ReadLine());

            Produto produto = new Produto(id, nome, preco);
            repo.Add(produto);

            Console.WriteLine(produto.ObterMensagensCriacao());
            break;
        
        case 2:
            List<Produto> todos = repo.GetAll();
            if (todos.Count == 0)
            {
                Console.WriteLine("Nenhum produto encontado");
            } else{
                Console.WriteLine("===== Produtos Cadastrados: =====");

                foreach (Produto pr in todos)
                    Console.WriteLine(pr);
            }
            break;
        
        case 3:
            Console.Write("ID do produto: ");
            int busca = int.Parse(Console.ReadLine());
            Produto prod = null;
            foreach (Produto x in repo.GetAll()){
                if (x.Id == busca)
                    prod = x;
            }

            if (prod == null){
                Console.WriteLine("Produto não encontrado");
                break;
            }

            Console.Write("Novo Preço: ");
            decimal novoPreco = decimal.Parse(Console.ReadLine());

            if (prod.AjustarPreco(novoPreco)){
                Console.WriteLine(prod.ObterMensagensPrecoAlterado(novoPreco));
            }else{
                Console.WriteLine("Falha na atualização!");
            }
            break;

        case 4:
            Console.WriteLine("Encerrando....");
            break;

        default:
            Console.WriteLine("Opção Inválida!");
            break;
    }

} while (opc != 4);