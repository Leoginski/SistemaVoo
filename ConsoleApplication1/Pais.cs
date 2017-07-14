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
        private Lista<Pais> fronteiras = new Lista<Pais>();

        // a) Construtor que inicialize o nome, a capital e a dimensão do país;
        public Pais(String nome, String capital, Double dimensao)
        {
            this.nome = nome;
            this.capital = capital;
            this.dimensao = dimensao;
        }

        // b) Propriedades para acesso aos atributos;
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
        public Lista<Pais> Fronteiras
        {
            get { return fronteiras; }
            set { fronteiras = value; }
        }

        // c) Um método que permita verificar se dois países são iguais. Dois países são iguaisse tiverem o mesmo nome e a mesma capital.
        // (sobrescreva o método Equals da classe Object);
        public override bool Equals(object obj)
        {
            var item = obj as Pais;

            if (item == null)
            {
                return false;
            }
            return this.nome == item.nome && this.capital == item.capital;
        }

        // d) Um método que informe se um outro país é seu limítrofe (faz fronteira);
        public bool VerificaFronteira(Pais pais)
        {
            No<Pais> no = new No<Pais>(pais);
            return this.fronteiras.BuscaNo(no) != null ? true : false;
        }

        // e) Um método que receba um outro país como parâmetro e retorne uma lista de vizinhos comuns aos dois países.
        public Lista<Pais> FronteirasComuns(Pais pais)
        {
            Lista<Pais> fronteirasComuns = new Lista<Pais>();
            for (int i = 0; i < this.fronteiras.Tamanho ; i++)
            {
                for (int j = 0; j < pais.fronteiras.Tamanho; j++)
                {
                    if (this.fronteiras.BuscaIndice(i).Equals(pais.fronteiras.BuscaIndice(j))) {
                        fronteirasComuns.InsereFinal(pais.fronteiras.BuscaIndice(j));
                    }
                }
            }
            return fronteirasComuns;
        }

        public void AddFronteira(Pais pais)
        {
            No<Pais> no = new No<Pais>(pais);
            this.fronteiras.InsereFinal(no);
        }
    }
}
