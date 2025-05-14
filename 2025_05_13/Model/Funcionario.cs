using Model.Exception;

namespace Model
{
    public class Funcionario{
        // public string Nome { get; set; }

        private string _nome;
        public string Nome{
            get => _nome;
            set {
                if (string.IsNullOrWhiteSpace(value))
                    throw new NomeNullException(value);

                _nome = value;
            }
        }
        
        private string _email;
        public string Email{
            get => _email;
            set {
                if (string.IsNullOrWhiteSpace(value))
                    throw new EmailNullException(value);

                if (!value.Contains("@") || !value.Contains("."))
                    throw new EmailInvalidoException(value);

                _email = value;
            }
        }

        public override string ToString(){
            return $"Nome: {Nome} - E-mail: {Email}";
        }
        
    }
}