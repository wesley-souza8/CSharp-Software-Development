using Interface;

namespace Model
{
    public class PagamentoBoleto : Pagamento, IPagavel
    {
        public string CodigoBarras {get; set;}

        public PagamentoBoleto(decimal valor, string CodigoBarras) : base(valor)
        {
            CodigoBarras = CodigoBarras;
        }

        public override string ProcessarPagamento()
        {
            return $"Processando pagamento via boleto: {CodigoBarras}";
        }
    }
}