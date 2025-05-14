namespace Model.Exception
{
    public class EmailInvalidoException : System.Exception{
        public EmailInvalidoException(string email) : base("Email Inválido"){

        }
    }
}