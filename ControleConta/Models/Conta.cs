using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ControleConta.Models
{
    public class Conta
    {
        private long _numero;
        private double _saldo;
        private Cliente Titular { get; set; }

        public Conta(long numero,  Cliente titular)
        {
            _numero = numero;
            Titular = titular;
        }

        public Conta(long numero, double saldo, Cliente titular)
        {
            _numero = numero;
            _saldo = saldo;
            Titular = titular;
        }


        public long Numero
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

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
            }
            if (valor > 0)
            {
                _saldo += valor;
                Console.WriteLine($"Deposito realizado com sucesso. Saldo atual {_saldo}");
            }

        }

        public virtual bool Sacar(double valor)
        {   
            if(_saldo - (valor + 0.10) >= 0)
            {
                _saldo -= valor + 0.10;
                return true;
            }else
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo");
            }

        }

        public void Transferir(Conta conta, double valor)
        {
            if (_saldo - valor >= 0)
            {
                _saldo -= valor;
                conta.Depositar(valor);

                Console.WriteLine($"Transferência realizada com sucesso.");
                Console.WriteLine($"Saldo da conta destino: {conta.Saldo:C}");
                Console.WriteLine($"Saldo da conta atual: {_saldo:C}");
            }
            else
            {
                throw new ArgumentException("Saldo insuficiente para transferência");
            }
        }



    }
}
