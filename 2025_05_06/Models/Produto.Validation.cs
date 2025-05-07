namespace Models
{
    public partial class Produto{
        public bool AjustarPreco(decimal novoPreco){
            if (novoPreco <= 0) return false;

            Preco = novoPreco;

            return true;
        }

        public bool AtualizarNome(string novoNome){
            if (string.IsNullOrEmpty(novoNome)) return false;

            Nome = novoNome;

            return true;
        }
    }
}