using Model;
using System.Globalization;

Console.Write("Digite o nome: ");
string nome = Console.ReadLine();

Console.Write("Digite o CPF: ");
string cpf = Console.ReadLine();

Console.Write("Digite o celular: ");
string celular = Console.ReadLine();

Console.Write("Digite a data da última compra (dd/mm/yyyy): ");
string inputData = Console.ReadLine();

if (DateOnly.TryParseExact(
        inputData,"dd/MM/yyyy",
        CultureInfo.InvariantCulture,
        DateTimeStyles.None, 
        out DateOnly dataUltCompra))
{
    Cliente cliente = new Cliente();
    cliente.Cadastar(nome, cpf, celular, dataUltCompra);
    Console.WriteLine(cliente.ExibirInformacoes());
}
else
{
    Console.WriteLine("Data inválida!");
}
