using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInformacao.models
{
    public class Pessoa
    {
        public string _nome;
        
        public Pessoa(string nome)
        {
            _nome = nome;
        }

        public string Nome
        {
            get => _nome;
            private set
            {
                _nome = value;
            }
        }
    }
}
