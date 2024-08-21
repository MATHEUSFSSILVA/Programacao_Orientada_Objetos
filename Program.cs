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
aluno1.Apresentar();