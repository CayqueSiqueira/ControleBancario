using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInformacao.models
{
    public class Conta
    {
        private string _numero;
        private double _saldo;
        public PessoaFisica _pessoaFisica { get; set; }
        public PessoaJuridica _pessoaJuridica { get; set; }

        public Conta(string numero, double saldo)
        {
            _numero = numero;
            _saldo = saldo;
        }

        public string Numero
        {
            get => _numero;
            private set
            {
                _numero = value;
            }
        }

        public double Saldo
        {
            get => _saldo;
            protected set
            {
                _saldo = value;
            }
        }

        public void entrada(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
            }
            if (valor > 0)
            {
                _saldo += valor;
                Console.WriteLine($"Deposito realizado com sucesso. Saldo atual {_saldo:C}");
            }
        }

        public void saida(double valor)
        {
            if (_saldo - (valor + 0.10) >= 0)
            {
                _saldo -= valor + 0.10;
                Console.WriteLine($"Pagamento efetuado. Saldo atual {_saldo:C}");
            }
            else
            {
                throw new ArgumentException("Saldo insuficiente");
            }
        }
    }
}
