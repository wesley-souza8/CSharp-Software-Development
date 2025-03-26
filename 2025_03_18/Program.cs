// See https://aka.ms/new-console-template for more information
//DateTime - simular login user
using System.Globalization;

string usuario = "fabio.silva";
DateTime ulitmoLogin = DateTime.Now;
Console.WriteLine($"Usuário: {usuario}");
Console.WriteLine($"Último login: {ulitmoLogin}");


//DateTime - permitido cadastro, se maior de 18 anos
Console.WriteLine("Digite sua data de nascimento");
string input = Console.ReadLine();
//converter para DateOnly
if (DateOnly.TryParseExact(
        input,"dd/MM/yyyy",
        CultureInfo.InvariantCulture,
        DateTimeStyles.None, 
        out DateOnly dataNascimento))
{
    Console.WriteLine($"Data de nascimento: {dataNascimento}");
    DateOnly hoje= DateOnly.FromDateTime(DateTime.Now);
    int idade = hoje.Year - dataNascimento.Year;

    if (hoje < dataNascimento.AddYears(idade))
    {
        idade--;
    }
    
    Console.WriteLine($"O usuário tem {idade} anos");
    Console.WriteLine(idade >= 18 ? "Cadastro permitido" : "Cadastro negado");
}
else
{
    Console.WriteLine("Data inválida!");
}

//TimeOnly - Horário de funcionamento
TimeOnly abertura = new TimeOnly(10, 30);
TimeOnly fechamento = new TimeOnly(21, 00);

Console.WriteLine($"Restaurante abre às: {abertura}");
Console.WriteLine($"Restaurante fecha às: {fechamento}");

//Simula um pedido
DateTime agora = DateTime.Now;
TimeOnly pedidoHora = TimeOnly.FromDateTime( agora );

bool aberto = (pedidoHora >= abertura) && (pedidoHora < fechamento);
Console.WriteLine($"O restaurante está aberto às {pedidoHora}? {aberto}");

//TimeSpan - Total de horas trabalhadas
TimeSpan duracaoTrabalho = new TimeSpan();
duracaoTrabalho = fechamento - abertura;
Console.WriteLine($"O restaurante fica aberto por {duracaoTrabalho} horas");

//DateOnly
//solicita data de nascimento
Console.Write("Digite sua data de nascimento (dd/mm/yyyy): ");
string entrada = Console.ReadLine();

if (DateOnly.TryParseExact(
        entrada, "dd/MM/yyyy",
        CultureInfo.InvariantCulture,
        DateTimeStyles.None,
        out DateOnly dateBirth))
{
    Console.WriteLine($"Data de nascimento registrada: {dateBirth}");
    DateOnly today = DateOnly.FromDateTime(DateTime.Now);

    Console.WriteLine(today);
}
else
{
    Console.WriteLine("Data inválida!");
}

//DateTimeOffset
DateTimeOffset dataPedido = DateTimeOffset.Now;
Console.WriteLine($"Horário do pedido (local): {dataPedido}");

//DateTimeOffset e TimeZoneInfo
TimeSpan deslocamento = dataPedido.Offset;

TimeZoneInfo fusoLocal = TimeZoneInfo.Local;
Console.WriteLine($"Fuso horário (UTC Offset): {deslocamento}");
Console.WriteLine($"Nome do fuso horário: {fusoLocal.StandardName}");