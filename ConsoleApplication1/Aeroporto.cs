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
        private Lista<Aeroporto> destinos = new Lista<Aeroporto>();
        private Lista<Aviao> avioesPatio = new Lista<Aviao>();

        // a) Um construtor que inicialize o código do aeroporto e seu nome.
        public Aeroporto(String codigo, String nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public Lista<Aviao> AvioesPatio
        {
            get { return avioesPatio; }
            set { avioesPatio = value; }
        }

        public Lista<Aeroporto> Destinos
        {
            get { return destinos; }
            set { destinos = value; }
        }

        // b) Propriedades que manipulem os atributos que não são listas;
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

        // c) Sobrescreva o método Equals da classe Object para verificar se um aeroporto é igual a ele(aeroportos são iguais se possuírem o mesmo código).
        public override bool Equals(object obj)
        {
            var item = obj as Aeroporto;

            if (item == null)
            {
                return false;
            }
            return (this.Codigo == item.Codigo);
        }

        // d) Um método que receba um prefixo de avião como parâmetro e informe se a aeronave está pousada nele.
        public bool verificarAviaoPousado(String prefixo)
        {
            Aviao target = new Aviao(prefixo);
            No<Aviao> no = new No<Aviao>(target);

            if (this.avioesPatio.BuscaNo(no) != null)
            {
                return true;
            }
            return false;
        }

        // e) Um método que receba um outro aeroporto como parâmetro e verifique se
        // existe alguma forma de se chegar nele. Para isto, o aeroporto deve verificar se ele
        // possui voo partindo para o aeroporto desejado, e caso não saia, se existe alguma forma de chegar nele à partir dos aeroportos de onde sai.
        // Assinatura do método: public bool PossuiRota(Aeroporto aeroporto)
        //public bool PossuiRota(Aeroporto aeroporto)
        //{
        //    for (int i = 0; i < this.destinos.Tamanho; i++)
        //    {
        //        if (this.destinos.BuscaIndice(i).valor.Equals(aeroporto))
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            No<Aeroporto> no = new No<Aeroporto>(aeroporto);
        //            if (this.destinos.BuscaIndice(i).valor.destinos.BuscaNo(no) != 0)
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}

        public bool PossuiRota(Aeroporto aeroporto)
        {

            Lista<Aeroporto> nosVisitados = new Lista<Aeroporto>();
            No<Aeroporto> no = new No<Aeroporto>(aeroporto);

            if (this.destinos.BuscaNo(no) > 0)
            {
                return true;
            }
            else
            {
                return this.PossuiRota(aeroporto, nosVisitados);
            }
        }

        public bool PossuiRota(Aeroporto aeroporto, Lista<Aeroporto> nosVisitados)
        {

            No<Aeroporto> noVisitado = new No<Aeroporto>(this);
            nosVisitados.InsereInicio(noVisitado);

            if (this.destinos.Cabeca != null)
            {
                for (int i = 0; i < this.destinos.Tamanho; i++)
                {
                    if (!(nosVisitados.BuscaNo(this.destinos.BuscaIndice(i)) > 0))
                    {
                        this.destinos.BuscaIndice(i).valor.PossuiRota(aeroporto, nosVisitados);
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }

        }

        public void AddAvioes(Aviao aviao)
        {
            No<Aviao> no = new No<Aviao>(aviao);
            this.AvioesPatio.InsereFinal(no);
        }

        public void AddDestinos(Aeroporto aeroporto)
        {
            No<Aeroporto> no = new No<Aeroporto>(aeroporto);
            this.destinos.InsereFinal(no);
        }

    }
}
