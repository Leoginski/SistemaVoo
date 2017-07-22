using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVoo
{
    public class Conta
    {
        private int numero;
        private double saldo;
        private string nomeCliente;
        private string senha;


        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public string NomeCliente
        {
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }


        public Conta(int _numero, double _saldo, string _nomeCliente, string _senha)
        {
            Numero = _numero;
            Saldo = _saldo;
            NomeCliente = _nomeCliente;
            Senha = _senha;
        }

        public virtual void Depositar(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
            }
        }

        public virtual void Sacar(double valor)
        {
            if (valor < this.Saldo)
            {
                this.Saldo -= valor;
            }
        }


    }
}
