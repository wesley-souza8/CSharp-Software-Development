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