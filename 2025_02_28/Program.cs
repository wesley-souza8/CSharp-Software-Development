// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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
numero = Convert.ToInt32(Console.ReadLine()); // Removi a redeclaração da variável

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} * {i} = {i * numero}");
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
int numeroDoWhile;
do
{
    Console.WriteLine("Digite um número positivo");
    numeroDoWhile = Convert.ToInt32(Console.ReadLine());

    if (numeroDoWhile < 0)
    {
        Console.WriteLine("Número inválido, tente novamente");
    }
} while (numeroDoWhile < 0);
Console.WriteLine($"Número válido inserido: {numeroDoWhile}");

// lista
List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
Console.WriteLine("Números da Lista: ");
foreach (int item in numbers)
    Console.WriteLine(item);

//tabuada2
Console.Write("Tabuada do 1 ao 5:");

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Tabuada do: {i}");

    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
} // Esta chave estava faltando

int Soma(int num1, int num2)
{
    return num1 + num2;
}

void ExibirMensagem(string mensagem)
{
    Console.WriteLine(mensagem);
}

Console.WriteLine(Soma(5, 6));
ExibirMensagem("Teste");