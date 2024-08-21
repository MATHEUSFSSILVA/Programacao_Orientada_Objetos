using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programacao_Orientada_Objetos_C_.Models
{
    // Sintaxe correta para fazer com que a classe em si herde propriedades e métodos de outras classes.
    public class Aluno : Pessoa
    {
        // ': base' inserido porque deixamos como obrigatório a inserção de nome e idade para a classe mãe. Herança de construtor.
        public Aluno(string nomeConstrutor, int idadeConstrutor, double notaConstrutor) : base(nomeConstrutor, idadeConstrutor)
        {
            Nota = notaConstrutor;
        }
    
        public double Nota { get; set; }

        public void MostrarNota()
        {
            Console.WriteLine($"Nota: {Nota}.");
        }

        // Exemplo de polimorfismo, sobrescrevendo o método Apresentar da classe mãe Pessoa. Detalhe na palavra override.
        public override void Apresentar()    
        {
            Console.WriteLine($"Olá, meu nome é {Nome} tenho {Idade} anos e sou aluno.");
        }
    }
}