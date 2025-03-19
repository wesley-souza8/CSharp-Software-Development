// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
/*
AULA - 14/02/2025

int num1 = 2;
int num2 = 5;

string nome1 = "1";
string nome2 = "1";

Console.WriteLine(num1 + num2);
Console.WriteLine(nome1 + nome2);
Console.WriteLine("Digite o seu nome");
string nome = Console.ReadLine();
Console.WriteLine("Olá " + nome + "!");

Console.WriteLine("Soma. Entre com dois valores inteiros: ");
int val1 = Int32.Parse(Console.ReadLine());
int val2 = Int32.Parse(Console.ReadLine());
Console.WriteLine(val1 + val2);
Console.WriteLine("Digite sua idade:");
int idade = int.Parse(Console.ReadLine());
if (idade < 18)
{
    Console.WriteLine("Menor de idade");
}
else
{
    Console.WriteLine("Maior de idade");
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
string[] nomes = { "Ana", "Pedro", "Maria" };
for (int i = 0; i < nomes.Length; i++)
{
   Console.WriteLine(nomes[i]);
};
int contador = 1;
while (contador <= 10)
{
    Console.WriteLine(contador);
    contador++;
}
Console.WriteLine("Digite o dia da semana (1-7):");
int diaSemana = Convert.ToInt32(Console.ReadLine());
switch (diaSemana)
{
    case 1:
        Console.WriteLine("Domingo");
        break;
    case 2:
        Console.WriteLine("Segunda");
        break;
    case 3:
        Console.WriteLine("Terça");
        break;
    case 4:
        Console.WriteLine("Quarta");
        break;  
    case 5:
        Console.WriteLine("Quinta");
        break;  
    case 6:
        Console.WriteLine("Sexta");
        break;
    case 7:
        Console.WriteLine("Sábado");
        break;    
    default:
        Console.WriteLine("Dia inválido");
        break;
}

Console.ReadKey();
*/

/*
====================================AULA 14-02==========================================
 const double PI = 3.141592;
 const string nomeAplicacao = "Nome da Aplicação";
 Console.WriteLine(PI);
 Console.WriteLine(nomeAplicacao);
 ==========================================================================================
 int numero = 10;
 Console.WriteLine("Valor inicial: " + numero);
 numero += 5;
 Console.WriteLine("Valor após += 5: " + numero);
 ==========================================================================================
 int numero1 = 10;
 int numero2 = 20;
 Console.WriteLine("Número 1: " + numero1);
 Console.WriteLine("Número 2: " + numero2);
 Console.WriteLine("Número 1 > Número 2 ? " + (numero1 > numero2));
 ==========================================================================================
 bool isAdult = true;
 bool hasPermission = false;
 bool isMember = true;
 if (isAdult && hasPermission) {
     Console.WriteLine("Acesso concedido! Você é adulto e tem permissão.");
 } else {
     Console.WriteLine("Você não atende os requisitos.");
 }
 ==========================================================================================

bool wannaContinue = true;
while (wannaContinue) {
    Console.Clear();

    Console.Write("\nDigite o primeiro número: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    double num2 = double.Parse(Console.ReadLine());

    Console.Write("Digite o tipo de operação que você deseja fazer | + | - | * | / |: ");
    char choice = Console.ReadKey().KeyChar;

    switch (choice) {
        case '+':
            Console.WriteLine("\nA somatória dos números informados é: " + (num1 + num2));
            break;
        case '-':
            Console.WriteLine("\nA subtração dos números informados é: " + (num1 - num2));
            break;
        case '*':
            Console.WriteLine("\nA multiplicação dos números informados é: " + (num1 * num2));
            break;
        case '/':
            if (num2 != 0){
                Console.WriteLine("\nA divisão dos números informados é: " + (num1 / num2));
            } else {
                Console.WriteLine("Erro: Divisão por zero não é permitido!");
            }
            break;
        default:
            Console.WriteLine("\nOpcão inválida!");
            break;
    }

    Console.Write("\nVocê deseja realizar mais uma operação (S/N) ? ");
    char answer = Console.ReadKey().KeyChar;

    wannaContinue = (answer == 's' || answer == 'S');
}
==========================================================================================
*/


/*
AULA - 28/02/2025

Console.WriteLine("Digite um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é PAR");
}
else
{
    Console.WriteLine($"O número {numero} é IMPAR");
}


//Tabuada
Console.WriteLine("Digite um número para ver a tabuada");
int numero = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i<= 10; i++)
{
    Console.WriteLine($"{numero} * {i} = {i*numero}");
}


//Array
int[] numeros = { 10, 20, 30, 40, 50 };
int soma = 0;

foreach (int item in numeros)
{
    Console.WriteLine(item);
    soma += item;
}

Console.WriteLine($"A soma dos números é {soma}");


string[] frutas = { "Maça", "Banana", "Uva", "melancia", "laranja" };
Console.WriteLine("Lista de frutas");

foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}


//Dicionario
Dictionary<string, int> idadePessoas = new Dictionary<string, int>()
{
    {"João", 25 },
    {"Maria", 30 },
    {"Pedro", 22 },
    {"Fabio", 47 }
};
Console.WriteLine("Idade Pessoas:");

foreach (var pessoa in idadePessoas)
{
    Console.WriteLine($"{pessoa.Key} tem {pessoa.Value} anos.");
}


//do-while
int numero;
do
{
    Console.WriteLine("Digite um número positivo");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero < 0)
    {
        Console.WriteLine("Número inválido, tente novamente");
    }
} while (numero >= 0);
Console.WriteLine($"Número válido inserido: {numero}");


// lista
List<int> numbers = new List<int> {10, 20, 30, 40, 50};
Console.WriteLine("Números da Lista: ");
foreach (int item in numbers)
    Console.WriteLine(item);


//tabuada2
Console.Write("Tabuada do 1 ao 5:");

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Tabuada do: {i}");

    for (int j = 1; j <= 10; j++)
        Console.WriteLine($"{i} x {j} = {i * j}");



int Soma(int num1, int num2)
{
    return num1 + num2;
}

void ExibirMensagem(string mensagem)
{
    Console.WriteLine(mensagem);
}

Console.WriteLine(Soma(5,6));
ExibirMensagem("Teste");
*/

/*

==================================== CheckPoint 1 ==========================================
Checkpoint 1 - Desenvolver uma calculadora em aplicação console
 
O programa deve permitir ao usuário realizar operações básicas como adição, subtração, multiplicação e divisão. 
Utilizem estruturas de controle e fluxo, como if/else, switch, for, while e do-while.
 
Requisitos do Trabalho:
1-O programa deve apresentar o título "Calculadora (Adição / Subtração / Multiplicação / Divisão)", logo abaixo, deve apresentar menu com 
as seguintes opções:
 

Escolha uma opçãp:
1-Adição
2-Subtração
3-Multiplicação
4-Divisão
5-Sair
 
2-O usuário deve escolher uma operação digitando o número correspondente.
3-Após escolher a operação, o programa deve solicitar dois números ao usuário.
4-O programa deve realizar a operação escolhida e exibir o resultado.
5-O programa deve continuar executando até que o usuário escolha a opção de sair.
6-O programa deve tratar erros, como divisão por zero.
 
Entrega:
O código-fonte deve ser entregue na plataforma da FIAP, onde vou copiar e colar em uma aplicação Console 'vazia' e executá-lo!
Envie também um print do seu código e tela com as opções da calculadora carregada (1-Adição, 2-Subtração, etc).
O prazo de entrega é até 18/03 ás 23:55h.
 
Critérios de Avaliação:
Uso correto de if/else	2 pts
Uso correto de switch/case	2 pts
Uso de for, while ou do-while	2 pts
Tipos de Dados das variáveis que foram utilizadas	2 pts
Boas práticas: Nomes das variáveis e organização do cógigo	2 pts
Total	10 pts
 
static (double, double) Numeros()
{
    double num1, num2;
    
    while (true)
    {
        Console.Write("\nDigite o primeiro número: ");
        if (double.TryParse(Console.ReadLine(), out num1)) break;
        Console.WriteLine("Entrada inválida. Digite um número válido.");
    }

    while (true)
    {
        Console.Write("\nDigite o segundo número: ");
        if (double.TryParse(Console.ReadLine(), out num2)) break;
        Console.WriteLine("Entrada inválida. Digite um número válido.");
    }

    return (num1, num2);
}


bool continuar = true;

while (continuar) {   

    Console.WriteLine("\nCalculadora (Adição / Subtração / Multiplicação / Divisão)");
    Console.WriteLine();
    Console.WriteLine("Escolha uma opção:\n1-Adição\n2-Subtração\n3-Multiplicação\n4-Divisão\n5-Sair");
    Console.Write("\nResposta: ");

    char escolha = Console.ReadKey().KeyChar;

    double num1 = 0;
    double num2 = 0;

    switch (escolha){
        case '1':
            (num1, num2) = Numeros();
            Console.WriteLine($"\nA adição do número {num1} e {num2} é igual a {(num1 + num2):F2}");
            break;
        case '2':
            (num1, num2) = Numeros();
            Console.WriteLine($"\nA subtração do número {num1} e {num2} é igual a {(num1 - num2):F2}");
            break;
        case '3':
            (num1, num2) = Numeros();
            Console.WriteLine($"\nA multiplicação do número {num1} e {num2} é igual a {(num1 * num2):F2}");
            break;
        case '4':
            (num1, num2) = Numeros();
            if (num2 != 0) {
                Console.WriteLine($"\nA divisão do número {num1} e {num2} é igual a {(num1 / num2):F2}");
            } else {
                Console.WriteLine($"\nErro: Divisão por zero não é permitido");
            }
            break;
        case '5':
            Console.WriteLine("Você escolheu sair.\nMuito obrigado!");
            continuar = false;
            break; 
        default:
            Console.WriteLine($"\nOpção {escolha} inválida, por favor escolha um número válido");
            break;
    }
}
*/

==================================== AULA 18/03/2025 ==========================================
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