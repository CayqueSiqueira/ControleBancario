// See https://aka.ms/new-console-template for more information
using ControleInformacao.models;
using ControleInformação.models;

Pessoa pessoa1 = new Pessoa("Cayque");
Pessoa pessoa2 = new Pessoa("Ronald");

PessoaFisica pessoafisica1 = new PessoaFisica("14264273790", pessoa1.Nome);
PessoaJuridica pessoajuridica1 = new PessoaJuridica("111122221111", pessoa2.Nome);

ContaFisica ContaFisica1 = new ContaFisica("00000001", 1000, pessoafisica1);
ContaJuridica ContaJuridica1 = new ContaJuridica("000000000002", 5000, pessoajuridica1);

Cliente cliente1 = new Cliente(ContaFisica1);
Credor credor1 = new Credor(ContaJuridica1);

ControleFinanceiro Controle = new ControleFinanceiro(){};

Console.WriteLine($"Saldo do credor {credor1._conta._pessoaJuridica.Nome} : {credor1._conta.Saldo}");
Console.WriteLine($"Saldo do cliente {cliente1._conta._pessoaJuridica.Nome} : {cliente1._conta.Saldo}");

Controle.ContasAPagar(1000, credor1);
Controle.ContasAReceber(100, cliente1);