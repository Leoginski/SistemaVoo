using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVoo
{
    public class ContaPoupanca : ContaCorrente
    {
        private double taxaRendimento;

        public ContaPoupanca(int _numero, double _saldo, string _nomeCliente, string _senha, double _taxaRendimento) : base(_numero, _saldo, _nomeCliente, _senha)
        {
            TaxaRendimento = _taxaRendimento;
        }

        public double TaxaRendimento
        {
            get { return taxaRendimento; }
            set { taxaRendimento = value; }
        }

        public void AtualizaSaldo()
        {
            this.Saldo = this.Saldo * this.TaxaRendimento;
        }

    }
}
