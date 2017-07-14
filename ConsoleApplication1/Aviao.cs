using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Aviao
    {
        private String modelo;
        private String prefixo;
        private String fabricante;
        private int assentos;
        private int assentosOcupados;  
                
        public Aviao(String prefixo)
        {
            this.prefixo = prefixo;
        }
        public Aviao(String modelo, String prefixo, String fabricante)
        {
            this.modelo = modelo;
            this.prefixo = prefixo;
            this.fabricante = fabricante;
        }
        public Aviao(String modelo, String prefixo, String fabricante, int assentos, int assentosOcupados)
        {
            this.modelo = modelo;
            this.prefixo = prefixo;
            this.fabricante = fabricante;
            this.assentos = assentos;
            this.assentosOcupados = assentosOcupados;
        }
        //public String Modelo { get; set; }
        //public String Prefixo { get; set; }
        //public String Fabricante { get; set; }
        //public int Assentos { get; set; }
        //public int AssentosOcupados { get; set; }

        public String getPrefixo()
        {
            return this.prefixo;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Aviao;
            if (item.prefixo == this.prefixo)
            {
                return true;
            }
            return false;
        }
    }
}
