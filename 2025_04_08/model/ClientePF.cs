namespace Model{
    public class ClientePF : Cliente{
        private string _cpf;
        public string CPF{
            get {return _cpf;}
            set {_cpf = value;}
        }

        public override bool ValidarCadastro(){
            return !string.IsNullOrEmpty(_cpf) && CPF.Length == 11;
        }

        public override void ExibirInformações(){
            base.ExibirInformações();
            Console.WriteLine($"CPF: {CPF}");
        }
    }
}