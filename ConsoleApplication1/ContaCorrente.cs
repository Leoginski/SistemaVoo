using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVoo
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int _numero, double _saldo, string _nomeCliente, string _senha) : base(_numero, _saldo, _nomeCliente, _senha)
        {
        }
    }
}
