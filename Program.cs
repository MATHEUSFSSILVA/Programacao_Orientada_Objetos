using Programacao_Orientada_Objetos_C_.Interfaces;
using Programacao_Orientada_Objetos_C_.Models;
// Pilares da POO, Abstração, Encapsulamento, Herança e Polimorfismo.

Console.WriteLine("---------- CLASSE PESSOA ----------");
// Objeto do tipo pessoa, inseri um sufixo nas variáveis do construtor para fácil leitura.
Pessoa pessoa1 = new Pessoa(nomeConstrucao: "Matheus", idadeConstrucao: 29);
pessoa1.Apresentar();

// Explicação de encapsulamento na classe ContaCorrente.
Console.WriteLine("---------- SAQUE CONTA CORRENTE ----------");
ContaCorrente conta1 = new ContaCorrente(numeroConstrutor: 183699,saldoConstrutor: 2928.92M);
conta1.Sacar(2928.92M);

// HERANÇA - Classe aluno e professor compartilham nome e idade, podemos criar uma classe para aluno e para professor e fazer herdar as propriedades da classe Pessoa.
Console.WriteLine("---------- HERANÇA ----------");
Aluno aluno1 = new Aluno(nomeConstrutor: "Matheus", idadeConstrutor: 29, notaConstrutor: 9.5);
// Método Apresentar herdado da classe pessoa.
aluno1.Apresentar();
aluno1.MostrarNota();

// POLIMORFISMO - Sobrescrever o método da classe mãe na classe filha, exemplo, classe mãe Pessoa tem o método Apresentar, posso sobrescrever no aluno com comportamento diferente.
Console.WriteLine("---------- POLIMORFISMO ----------");
aluno1.Apresentar();

// CLASSES ABSTRATAS - São classes que são obrigatoriamente herdadas, não pode ser instanciada. Classe conta com mais detalhes.
Console.WriteLine("---------- CLASSE ABSTRATA ----------");
Poupanca poupanca1 = new Poupanca();
poupanca1.Creditar(10);
poupanca1.ExibirSaldo();

// CLASSE SELADA - São classes que não permite ser herdadas e métodos selados não podem ser sobrescritos.
Console.WriteLine("---------- CLASSE SELADA ----------");
// public sealed class Conta

// Todas as classes herdam da classe System.Object.
Console.WriteLine("---------- CLASSE OBJECT ----------");

// Assim como numa classe abstrata uma interface não pode ser instanciada.
// A interface é um contrato! Se implementar uma interface, deve-se implementar todos os métodos da interface.
// Métodos que não tem corpo nas interfaces são obrigatórios a implementação, métodos que tem corpo são opcionais.
Console.WriteLine("---------- INTERFACES ----------");

// Duas maneiras de instanciar.
Calculadora calculadora1 = new Calculadora();
Console.WriteLine($"Modo de instanciar 1 : {calculadora1.Somar(2, 2)}");

ICalculadora calculadora2 = new Calculadora();
Console.WriteLine($"Modo de instanciar 2 : {calculadora2.Somar(2, 2)}");