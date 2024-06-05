using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleConta.Models
{
    public class ContaCaixinha : Conta
    {
        public ContaCaixinha(long numero, Cliente titular): base(numero, titular)
        {
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
            }
            if (valor > 0)
            {
                Saldo += valor + 1;
                Console.WriteLine($"Deposito realizado com sucesso. Saldo atual {Saldo}");
            }

        }

        public virtual bool Sacar(double valor)
        {
            if (Saldo - (valor + 5) >= 0)
            {
                Saldo -= valor + 5;
                return true;
            }
            else
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo");
            }

        }
    }
}
