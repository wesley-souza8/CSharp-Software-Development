using Models;

namespace Interface
{
    public interface IProdutoRepository{
        void Add(Produto p);
        List<Produto> GetAll();
    }
}