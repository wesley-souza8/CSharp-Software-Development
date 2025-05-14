namespace Model.Exception
{
    public class EmailNullException : System.Exception{
        public EmailNullException(string email) : base("Preencha o email!"){

        }
    }
}