using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVoo
{
    public class ContaEspecial : ContaCorrente
    {
        private double limiteExtra;

        public double LimiteExtra
        {
            get { return limiteExtra; }
            set { limiteExtra = value; }
        }

        private double limiteUsado;

        public ContaEspecial(int _numero, double _saldo, string _nomeCliente, string _senha, double _limiteExtra) : base(_numero, _saldo, _nomeCliente, _senha)
        {
            LimiteExtra = _limiteExtra;
            LimiteUsado = _limiteExtra;
        }

        public double LimiteUsado
        {
            get { return limiteUsado; }
            set { limiteUsado = value; }
        }


        public override void Depositar(double valor)
        {
            if (valor > 0)
            {
                if (LimiteUsado < LimiteExtra)
                {
                    var limiteRecuperavel = LimiteExtra - LimiteUsado;
                    if (valor <= limiteRecuperavel)
                    {
                        LimiteUsado += valor;
                        Saldo += valor;
                    }
                    else
                    {
                        LimiteUsado += limiteRecuperavel;
                        this.Saldo += valor - limiteRecuperavel;
                    }
                }
                else
                {
                    this.Saldo += valor;
                }
            }
        }

        public override void Sacar(double valor)
        {
            if (valor > 0)
            {
                if (valor > this.Saldo)
                {
                    var valorDesejavel = valor - this.Saldo;
                    if (valorDesejavel < this.LimiteUsado)
                    {
                        this.LimiteUsado -= valorDesejavel;
                        this.Saldo -= valor;
                    }
                }
                else
                {
                    this.Saldo -= valor;
                }
            }
        }

    }
}
