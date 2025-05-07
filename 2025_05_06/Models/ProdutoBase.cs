namespace Models
{
    public abstract class ProdutoBase{
        public int Id {get; set;}
        public string Nome {get; set;}
        public decimal Preco {get; set;}

        public ProdutoBase(int id, string nome, decimal preco){
            Id = id;
            Nome = nome;
            Preco = preco;
        }

        public abstract string GetDetails();
    }
}