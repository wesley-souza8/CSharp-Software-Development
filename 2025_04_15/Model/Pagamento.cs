namespace Model
{
    public abstract class Pagamento{
        public decimal Valor {  get; set;   }
        public DateTime Data {  get; set;   }
        public Pagamento(decimal valor) {
            Valor = valor;
            Data = DateTime.Now;
        }
        public string EmitirRecibo(){
            return $"Recibo gerado em {Data:dd/MM/yyyy} no valor de R$ {Valor}";
        }
        public abstract string ProcessarPagamento();
    }
}