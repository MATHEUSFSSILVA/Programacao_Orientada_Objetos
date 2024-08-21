using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programacao_Orientada_Objetos_C_.Models
{
    public abstract class Conta
    {
        // Atributo Protected, diferente do private que só pode ser utilizado pela própria classe, pode ser utilizado também pelas filhas.
        protected decimal saldo;

        // Método obrigatório de implementação nas classes filhas.
        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é de {saldo}");
        }
    }
}