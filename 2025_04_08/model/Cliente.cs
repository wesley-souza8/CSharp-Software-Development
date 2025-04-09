namespace Model
{
    public abstract class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        /*private string _nome;
        private string _email;

        public string Nome 
        {
            get { return _nome;}
            set { _nome = value;}
        }

        public string Email 
        {
            get { return _email;}
            set { _email = value;}
        }*/

        //Método abstrado que froça subclasses a implementar a validação
        public abstract bool ValidarCadastro();

        public virtual void ExibirInformações(){
            Console.WriteLine($"Nome: {Nome}\nEmail: {Email}");
        }
    }
}