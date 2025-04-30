using Interface;

namespace Model
{
    public class Product : IDisplay{
        public string Nome { get; set; }	
        public int Quantidade { get; set; }
        public Price ProdutoPreco{ get; set; }

        public Product(string nome, int quantidade, Price produtoPreco){
            Nome = nome;
            Quantidade = quantidade;
            ProdutoPreco = produtoPreco;
        }

        public string Display(){
            return $"Produto: {Nome} Quantidade: {Quantidade} {ProdutoPreco.Display()}";
        }
    }
}