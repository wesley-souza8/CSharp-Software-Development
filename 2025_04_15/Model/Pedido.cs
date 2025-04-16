namespace Model
{
    public class Pedido
    {
        public int Id { get; set; }
        public Pagamento FormaDePagamento { get; set; }

        public Pedido(int id, Pagamento formaDePagamento)
        {
            Id = id;
            FormaDePagamento = formaDePagamento;
        }

        public List<string> FinalizarPedido()
        {
            List<string> mensagens = new List<string>();

            mensagens.Add($"Finalizando pedido #{Id}");
            mensagens.Add(FormaDePagamento.ProcessarPagamento());
            mensagens.Add(FormaDePagamento.EmitirRecibo());

            return mensagens;
        }
    }
}