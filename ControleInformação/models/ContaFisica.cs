using ControleInformacao.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInformação.models
{
    public class ContaFisica : Conta
    {
        public ContaFisica(string numero, double saldo, PessoaFisica titular): base(numero, saldo)
        {
            _pessoaFisica = titular;
        }
    }
}
