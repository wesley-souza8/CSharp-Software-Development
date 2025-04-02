namespace Model
{
    public class Pessoa
    {
        //atributos (encapsulamento)
        private string nome;
        private string cpf;
        private string celular;

        //propriedades
        private string Nome
        {
            get {return nome;}
            set {nome = value;}
        }
        private string CPF
        {
            get {return cpf;}
            set {cpf = value;}
        }
        private string Celular
        {
            get {return celular;}
            set {celular = value;}
        }

        //Método
        public virtual void Cadastar(string nome, string cpf, string celular, DateOnly? dataUltCompra = null)
        {
            Nome = nome;
            CPF = cpf;
            Celular = celular;
        }
        public virtual string ExibirInformacoes()
        {
            string infoFormatada = PessoaInfoFormat.FormatarInformacoes(Nome, CPF, Celular);
            return infoFormatada;
        }

        private static class PessoaInfoFormat
        {
            public static string FormatarInformacoes(string nome, string cpf, string celular)
            {
                return $"Nome: {nome} CPF: {cpf} Celular: {celular}";
            }
        }
    }
    
}