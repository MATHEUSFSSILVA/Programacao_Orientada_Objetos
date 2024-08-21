using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programacao_Orientada_Objetos_C_.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConstrutor, decimal saldoConstrutor)
        {
            Numero = numeroConstrutor;
            Saldo = saldoConstrutor;
        }
        public int Numero { get; set; }
        private decimal Saldo;

        public void Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {    
                Saldo -= valor;
                Console.WriteLine($"Seu saldo após o saque de {valor:C} é de {Saldo:C}.");
            }
            else
            {
                Console.WriteLine($"Não foi possível sacar, seu saldo é de {Saldo:C}.");
            }
        }
    }
}