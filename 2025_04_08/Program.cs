using Model;
using System.Globalization;

Console.Write("Digite o nome: ");
string nome = Console.ReadLine();

Console.Write("Digite o email: ");
string email = Console.ReadLine();

Console.Write("Digite o CPF: ");
string cpf = Console.ReadLine();

ClientePF cliente = new ClientePF();
cliente.Nome = nome;
cliente.Email = email;
cliente.CPF = cpf;

if (cliente.ValidarCadastro()){
    cliente.ExibirInformações();
} else{
    Console.WriteLine("CPF inválido");
}

