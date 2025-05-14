using Model;
using Model.Exception;

try{
    Funcionario func = new Funcionario();

    System.Console.Write("Nome: ");
    func.Nome = Console.ReadLine();

    System.Console.Write("Email: ");
    func.Email = Console.ReadLine();

}
catch (NomeNullException ex ){
    Console.WriteLine($"NomeNullException {ex.Message}");

}
catch (EmailNullException ex ){
    Console.WriteLine($"EmailNullException {ex.Message}");

}
catch (EmailInvalidoException ex ){
    Console.WriteLine($"EmailInvalidoException {ex.Message}");

}
catch (System.Exception ex ){
    Console.WriteLine($"Exception {ex.Message}");

}
finally{
    Console.WriteLine("Pressione qualquer tecla para continuar...");
}