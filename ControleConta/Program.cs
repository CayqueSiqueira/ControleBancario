// See https://aka.ms/new-console-template for more information

using ControleConta.Models;

Cliente cliente1 = new Cliente("joao@gmail.com", 1990,"João", "12345678901");
Cliente cliente2 = new Cliente("cayquesm@gmail.com", 1985, "Cayque", "10987654321");

Conta conta1 = new Conta(123456, 1235.42, cliente1);
Conta conta2 = new Conta(654321, 2341.42, cliente2);
ContaEspecial contaEspecial1 = new ContaEspecial(1111, cliente1, 100);
contaEspecial1.Sacar(50);
Console.WriteLine(contaEspecial1.Saldo);

ContaCaixinha contacaixinha1 = new ContaCaixinha(111122, cliente1);
contacaixinha1.Depositar(50);
Console.WriteLine($"{contacaixinha1.Saldo}");


Console.WriteLine("Trabalho POO\n");
Console.WriteLine($"Saldo total da conta 1 é : R${conta1.Saldo}");
Console.WriteLine($"Saldo total da conta 1 é : R${conta2.Saldo}");

// Cálculo do saldo total
double saldoTotal = conta1.Saldo + conta2.Saldo;

// Identificação da conta com maior saldo
Conta contaMaiorSaldo = (conta1.Saldo > conta2.Saldo) ? conta1 : conta2;

// Saldo inicial total geral
conta1.Transferir(conta2, 100);
Console.WriteLine(conta1.Saldo);
conta1.Sacar(100);

Console.WriteLine(contaEspecial1.Saldo);


double saldoInicialTotalGeral = conta1.Saldo + conta2.Saldo;

// Exibição dos resultados
Console.WriteLine($"Saldo total das duas contas: R${saldoTotal}");
Console.WriteLine($"Número da conta com maior saldo: {contaMaiorSaldo.Numero}");
Console.WriteLine($"Saldo inicial total geral: R${saldoInicialTotalGeral:C}");

// Clientes
Console.WriteLine($"Cliente: {cliente1.Nome}, CPF: {cliente1.CPF}, Data de Nascimento: {cliente1.Idade}");
Console.WriteLine($"Cliente: {cliente2.Nome}, CPF: {cliente2.CPF}, Data de Nascimento: {cliente2.Idade}");




