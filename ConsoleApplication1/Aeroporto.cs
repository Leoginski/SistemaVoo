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
        private Lista<Pais> destinos = new Lista<Pais>();
        private Lista<Aviao> avioesPatio = new Lista<Aviao>();

        // a) Um construtor que inicialize o código do aeroporto e seu nome.
        public Aeroporto(String codigo, String nome)
        {
            Codigo = codigo;
            Nome = nome;
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
        // existe alguma forma de se chegar nele.Para isto, o aeroporto deve verificar se ele
        // possui voo partindo para o aeroporto desejado, e caso não saia, se existe alguma forma de chegar nele à partir dos aeroportos de onde sai.
        // Assinatura do método: public bool PossuiRota(Aeroporto aeroporto)
        public bool PossuiRota(Aeroporto aeroporto)
        {
            for (int i = 0; i < this.destinos.Tamanho; i++)
            {
                
            }
            return true;
        }

    }
}
