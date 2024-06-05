using ControleInformacao.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInformação.models
{
    public class ContaJuridica : Conta
    {
        public ContaJuridica(string numero, double saldo, PessoaJuridica titular): base(numero, saldo)
        {
            _pessoaJuridica = titular;
        }
    }
}
