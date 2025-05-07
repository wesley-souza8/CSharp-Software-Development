namespace Models
{
    public partial class Produto : ProdutoBase{
        public Produto(int id, string nome, decimal preco) : base(id, nome, preco) { 
            ObterMensagensCriacao();
        }
    }
}