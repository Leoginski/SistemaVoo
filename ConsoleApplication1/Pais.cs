using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ListaEncadeada.Program;

namespace ConsoleApplication1
{
    class Pais
    {
        private String nome;
        private String capital;
        private Double dimensao;
        private Lista fronteiras = new Lista();

        public Pais(String nome, String capital, Double dimensao)
        {
            this.nome = nome;
            this.capital = capital;
            this.dimensao = dimensao;
        }
        public String Nome {
            get { return nome;}
            set { nome = value; }
        }
        public String Capital
        {
            get { return capital; }
            set { capital = value; }
        }
        public Double Dimensao
        {
            get { return dimensao; }
            set { dimensao = value; }
        }
        public Lista Fronteiras
        {
            get { return fronteiras; }
            set { fronteiras = value; }
        }

        public void AddFronteira(Pais pais)
        {
            this.fronteiras.InsereFinal(pais);
        }

        public override bool Equals(object obj)
        {
            var item = obj as Pais;

            if (item == null)
            {
                return false;
            }
            return this.nome == item.nome && this.capital == item.capital;
        }
        public bool VerificaFronteira(Pais pais)
        {
            return fronteiras.Busca(pais);
        }

        public Lista FronteirasComuns(Pais pais)
        {
            Lista paisesComuns = new Lista();
            Nos lista = this.fronteiras.Percorre();
            Nos lista2 = pais.fronteiras.Percorre();

            for (int i = 0; i < this.fronteiras.getTamanho() ; i++)
            {
                for (int j = 0; j < pais.fronteiras.getTamanho(); j++)
                {
                    if (lista[i] == lista2[j]) {
                        paisesComuns.InsereFinal(lista2[j]);
                    }
                }
            }

            return paisesComuns;
        }
    }
}
