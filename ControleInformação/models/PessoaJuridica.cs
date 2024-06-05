using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInformacao.models
{
    public class PessoaJuridica : Pessoa
    {
        public string _cpf;

        public PessoaJuridica(string cpf, string nome): base(nome)
        {
            _cpf = cpf;
        }

        public string cpf
        {
            get => _cpf;
            private set
            {
                _cpf = value;
            }
        }
    }
}
