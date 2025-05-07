namespace Models
{
    public partial class Produto{
        public string ObterMensagensCriacao(){
            return $"[EVENTO] Produto criado: {Nome} (ID{Id} - Preço: {Preco:C})";
        }

        public string ObterMensagensPrecoAlterado(decimal novoPreco){
            return $"[EVENTO] Preço do produto #{Id} alterado para {novoPreco:C}";
        }

        public override string GetDetails(){
            return $"ID {Id}, Nome: {Nome}, Preço: {Preco:C}";
        }

        public override string ToString(){
            return GetDetails();
        }
    }
}