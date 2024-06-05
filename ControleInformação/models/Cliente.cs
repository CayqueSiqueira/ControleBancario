using ControleInformação.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInformacao.models
{
    public class Cliente
    {
        public Conta _conta;
        public ContaFisica _contaFisica;
        public ContaJuridica _contaJuridica;

        public Cliente(Conta conta)
        {
            _conta = conta;
        }

        public Cliente(ContaFisica conta)
        {
            _contaFisica = conta;
        }

        public Cliente(ContaJuridica conta)
        {
            _contaJuridica = conta;
        }




    }
}
