// See https://aka.ms/new-console-template for more information

using SistemaFinanceiro.Models;

Cliente cliente1 = new Cliente("João", "12345678901", 1990);
Cliente cliente2 = new Cliente("Cayque", "10987654321", 1985);

Conta conta1 = new Conta(123456, 1235.42m, cliente1, agencia1);
Conta conta2 = new Conta(654321, 2341.42m, cliente2, agencia1);

Console.WriteLine("Trabalho POO\n");
Console.WriteLine($"Saldo total da conta 1 é : R${conta1.Saldo}");
Console.WriteLine($"Saldo total da conta 1 é : R${conta2.Saldo}");

// Cálculo do saldo total
decimal saldoTotal = conta1.Saldo + conta2.Saldo;

// Identificação da conta com maior saldo
Conta contaMaiorSaldo = (conta1.Saldo > conta2.Saldo) ? conta1 : conta2;

// Saldo inicial total geral
conta1.Transferencia(100m, conta2);
Console.WriteLine(conta1.Saldo);
conta1.Saque(100m);
Console.WriteLine(conta1.Saldo);

decimal saldoInicialTotalGeral = conta1.Saldo + conta2.Saldo;

// Exibição dos resultados
Console.WriteLine($"Saldo total das duas contas: R${saldoTotal}");
Console.WriteLine($"Número da conta com maior saldo: {contaMaiorSaldo.Numero}");
Console.WriteLine($"Saldo inicial total geral: R${saldoInicialTotalGeral:C}");

// Clientes
Console.WriteLine($"Cliente: {cliente1.Nome}, CPF: {cliente1.CPF}, Data de Nascimento: {cliente1.DataNascimento}");
Console.WriteLine($"Cliente: {cliente2.Nome}, CPF: {cliente2.CPF}, Data de Nascimento: {cliente2.DataNascimento}");

Console.WriteLine($"Idade em romano do cliente {cliente1.Nome} é {cliente1.ConverterParaRomano()}");



