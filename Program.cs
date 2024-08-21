using Programacao_Orientada_Objetos_C_.Models;

Console.WriteLine("---------- CLASSE PESSOA ----------");
// Objeto do tipo pessoa, inseri um sufixo nas variáveis do construtor para fácil leitura.
Pessoa pessoa1 = new Pessoa(nomeConstrucao: "Matheus", idadeConstrucao: 29);
pessoa1.Apresentar();


Console.WriteLine("---------- SAQUE CONTA CORRENTE ----------");
ContaCorrente conta1 = new ContaCorrente(numeroConstrutor: 183699,saldoConstrutor: 2928.92M);
conta1.Sacar(2928.92M);
