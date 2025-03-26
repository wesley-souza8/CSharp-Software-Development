// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

/*
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
 */

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