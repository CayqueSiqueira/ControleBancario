using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInformacao.models
{
    public class PessoaFisica : Pessoa
    {
        public string _cpf;

        public PessoaFisica(string cpf, string nome) : base(nome)
        {
            _cpf = cpf;
        }

        public string Cpf
        {
            get => _cpf;
            private set
            {
                _cpf = value;
            }
        }
    }
}
