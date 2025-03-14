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