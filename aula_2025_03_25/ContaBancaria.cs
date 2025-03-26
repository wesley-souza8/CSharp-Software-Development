using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class ContaBancaria
    {
        //campos
        private string titular;
        private decimal saldo;
        private const decimal tarifaSaque = 2.5m;

        //propriedades
        public string Titular
        {
            get { return titular; }
            set {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome não pode ser vazio!");
                }
                else
                {
                    titular = value;
                }                
            }
        }

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        //construtor
        public ContaBancaria(string titular, decimal saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        //método
        public void Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor} realizado com sucesso!");
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Titular: {Titular}\nSaldo: {Saldo}");
        }

        public void Sacar(decimal valor)
        {            
            decimal valorTotal = valor + tarifaSaque;
            if (valor <= 0)
            {
                Console.WriteLine("Saque inválido!");
            }
            else if (valorTotal > saldo)
            {
                Console.WriteLine($"Saldo insuficiente!\nPara realizar o saque, você precisaria ter em conta o valor minimo de {valorTotal}");
            }
            else
            {
                Saldo -= valorTotal;
            }
            
        }

    }
}
