using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programacao_Orientada_Objetos_C_.Models
{
    public class Poupanca : Conta
    {
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        }
    }
}