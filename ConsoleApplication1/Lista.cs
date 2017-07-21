using ConsoleApplication1;
using System;
using System.Collections.Generic;

namespace ListaEncadeada
{
    partial class Program
    {
        //Simple List
        public class Lista<T>
        {
            private No<T> cabeca;
            private int tamanho = 0;

            public No<T> Cabeca
            {
                get { return cabeca; }
                set { cabeca = value; }
            }


            public int Tamanho
            {
                get { return tamanho; }
                set { tamanho = value; }
            }


            public Lista(No<T> cabeca)
            {
                this.cabeca = cabeca;
                this.tamanho++;
            }

            public Lista()
            {
                this.cabeca = null;
            }

            public void InsereInicio(No<T> no)
            {
                if (this.cabeca == null)
                {
                    this.cabeca = no;
                }
                else
                {

                    no.prox = this.cabeca;
                    this.cabeca = no;
                }
                this.tamanho++;
            }

            public void RemoveInicio()
            {
                if (this.cabeca != null)
                {
                    this.cabeca = null;
                    this.tamanho--;
                }
            }

            public void InsereFinal(No<T> no)
            {
                if (this.cabeca == null)
                {
                    this.cabeca = no;
                }
                else
                {
                    No<T> aux = this.cabeca;
                    while (aux.prox != null)
                    {
                        aux = aux.prox;
                    }
                    aux.prox = no;
                }
                this.tamanho++;
            }

            public void RemoveFinal()
            {
                if (cabeca.prox != null)
                {
                    No<T> aux = this.cabeca;
                    while (aux.prox != null)
                    {
                        aux = aux.prox;
                    }
                    aux = null;
                }
                else
                {
                    cabeca.prox = null;
                }
                this.tamanho--;
            }

            public No<T> BuscaIndice(int indice)
            {
                No<T> aux = this.cabeca;
                for (int i = 0; i<indice; i++)
                {
                    aux = aux.prox;
                }
                return aux;
            }

            public void RemoveIndice(int indice)
            {
                No<T> aux = this.BuscaIndice(indice);
                No<T> anterior  = this.buscaAnterior(aux);
                anterior.prox = aux.prox;
                aux = null;
                this.tamanho--;
            }

            public No<T> buscaAnterior(No<T> no)
            {
                No<T> aux = this.cabeca;
                while (aux.prox != no)
                {
                    aux = aux.prox;
                }
                return aux;
            }

            public int BuscaNo(No<T> no)
            {
                int i = 0;
                No<T> aux = this.cabeca;
                while (!aux.Equals(no))
                {
                    aux = aux.prox;
                    i++;
                }
                return i;
            }

            public void removeNo(No<T> no)
            {
                int indice = this.BuscaNo(no);
                No<T> atual = this.BuscaIndice(indice);
                No<T> anterior = this.buscaAnterior(no);
                anterior.prox = no.prox;
                no = null;
                this.tamanho--;
            }

            public void ImprimirLista()
            {
                if (cabeca == null)
                {
                    Console.WriteLine("  Lista vazia");
                }
                else
                {
                    No<T> aux = this.cabeca;
                    while (aux.prox != null)
                    {
                        Console.WriteLine("  {0}", aux.valor);
                        aux = aux.prox;
                    }
                }
            }
        }
    }
}




