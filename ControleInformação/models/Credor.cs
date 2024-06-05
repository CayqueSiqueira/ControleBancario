using ControleInformação.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInformacao.models
{
    public class Credor
    {
        public Conta _conta;
        public ContaFisica _contaFisica;
        public ContaJuridica _contaJuridica;

        public Credor(Conta conta)
        {
            _conta = conta;
        }

        public Credor(ContaFisica conta)
        {
            _contaFisica = conta;
        }

        public Credor(ContaJuridica conta)
        {
            _contaJuridica = conta;
        }
    }
}
