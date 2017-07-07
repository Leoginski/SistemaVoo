using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ListaEncadeada.Program;

namespace ConsoleApplication1
{
    class Aeroporto
    {
        private String codigo;
        private String nome;
        private bool status;
        private Lista destinos = new Lista();
        private Lista avioesPatio = new Lista();

        public List<Aviao> AvioesPatio
        {
            get { return avioesPatio; }
            set { avioesPatio = value; }
        }
        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public Aeroporto(String codigo, String nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Aeroporto;

            if (item == null)
            {
                return false;
            }
            return (this.Codigo == item.Codigo);
        }

        public bool verificarAviaoPousado(String prefixo)
        {
            
        }



    }
}
