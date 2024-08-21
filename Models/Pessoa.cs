using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Uma classe nada mais é do que a representação de um objeto da vida real.
namespace Programacao_Orientada_Objetos_C_.Models
{
    public class Pessoa
    {
        // Construtor
        public Pessoa(string nomeConstrucao, int idadeConstrucao)
        {
            Nome = nomeConstrucao;
            Idade = idadeConstrucao;
        }

        // Propriedade
        public string Nome { get; set; }
        public int Idade { get; set;}

        // Método
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}