namespace Model.Exception{
    public class NomeNullException : System.Exception{
        public NomeNullException(string nome) : base("Preencha o nome"){
            
        }
    }
}