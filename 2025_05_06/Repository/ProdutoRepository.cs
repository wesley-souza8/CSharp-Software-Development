using Models;
using Interface;

namespace Repository
{
    public class ProdutoRepository : IProdutoRepository{
        private List<Produto> _produtos = new List<Produto>();

        public void Add(Produto p){
            _produtos.Add(p);
        }

        public List<Produto> GetAll(){
            return _produtos;
        }
    }
}