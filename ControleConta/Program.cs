// See https://aka.ms/new-console-template for more information

using ControleConta.Models;

Cliente cliente1 = new Cliente("joao@gmail.com", 1990, "João", "12345678901");
Cliente cliente2 = new Cliente("cayquesm@gmail.com", 1985, "Cayque", "10987654321");
Conta conta1 = new Conta(123456, 1235.42, cliente1);
Conta conta2 = new Conta(654321, 2341.42, cliente2);
Conta conta3 = new Conta(121212, cliente1);
ContaEspecial contaEspecial1 = new ContaEspecial(1111, cliente1, 100);
ContaCaixinha contacaixinha1 = new ContaCaixinha(111122, cliente1);



Console.WriteLine("|========Testes controle bancario========|\n");
// Clientes e contas
Console.WriteLine($"Cliente: {cliente1.Nome}, CPF: {cliente1.CPF}, Data de Nascimento: {cliente1.Idade}");
Console.WriteLine($"Cliente: {cliente2.Nome}, CPF: {cliente2.CPF}, Data de Nascimento: {cliente2.Idade}\n");

Console.WriteLine($"Saldo inicial da conta {conta1.Numero} é : R${conta1.Saldo}");
Console.WriteLine($"Saldo inicial da conta {conta2.Numero} é : R${conta2.Saldo}\n");

// Cálculos iniciais
double saldoTotalinicial = conta1.Saldo + conta2.Saldo;
conta1.Transferir(conta2, 100);
conta1.Sacar(100);
double saldoTotalGeral = conta1.Saldo + conta2.Saldo;

// Identificação da conta com maior saldo
Conta contaMaiorSaldo = (conta1.Saldo > conta2.Saldo) ? conta1 : conta2;

// Exibição dos resultados
Console.WriteLine($"Saldo total inicial das duas contas: R${saldoTotalinicial}");
Console.WriteLine($"Número da conta com maior saldo: {contaMaiorSaldo.Numero}");
Console.WriteLine($"Saldo total geral das duas contas: R${saldoTotalGeral:C}");

// novas operações com a caixinha e conta especial
contaEspecial1.Sacar(50);
Console.WriteLine($"Saldo após sacar dentro do limite na conta especial {contaEspecial1.Saldo}\n");
/*contaEspecial1.Sacar(50);
Console.WriteLine($"Ultrapassando o limite{contaEspecial1.Saldo}");*/
Console.WriteLine($"Saldo inicial da caixinha {contacaixinha1.Saldo:C}");
contacaixinha1.Depositar(50);
contacaixinha1.Sacar(10);
Console.WriteLine($"Saldo da conta {conta3} é {conta3.Saldo:C}");



