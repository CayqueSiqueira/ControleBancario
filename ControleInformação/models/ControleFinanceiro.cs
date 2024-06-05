using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInformacao.models
{

    public class ControleFinanceiro
    {
        public Cliente Cliente { get; set; }
        public Credor Credor { get; set; }

        public ControleFinanceiro()
        {

        }
        public void ContasAPagar(double valor, Credor credor)
        {
            credor._conta.entrada(valor);
            if (credor._conta._pessoaFisica != null)
            {
                Console.WriteLine($"o novo saldo do credor {credor._conta._pessoaFisica.Nome} é {credor._conta.Saldo}");
            }else
            {
                Console.WriteLine($"o novo saldo do credor {credor._conta._pessoaJuridica.Nome} é {credor._conta.Saldo}");
            }
        }

        public void ContasAReceber(double valor, Cliente cliente)
        {
            Cliente._conta.saida(valor);
            if (Cliente._conta._pessoaFisica != null)
            {
                Console.WriteLine($"o novo saldo do credor {Cliente._conta._pessoaFisica.Nome} é {Cliente._conta.Saldo}");
            }
            else
            {
                Console.WriteLine($"o novo saldo do credor {Cliente._conta._pessoaJuridica.Nome} é {Cliente._conta.Saldo}");
            }
        }
    }
}
