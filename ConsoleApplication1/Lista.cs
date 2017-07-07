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
            private No No;

            public void InsereInicio(object info)
            {
                if (No == null)
                    No = new No(info);
                else
                    No = new No(info, No);
            }


            public No RemoveInicio()
            {
                No no = null;
                if (No != null)
                {
                    no = No;
                    No = No.Next;
                }
                return no;
            }


            public void InsereFinal(T info)
            {
                if (No == null)
                    No = new No(info);
                else
                {
                    No noAux = No;
                    while (noAux.Next != null)
                    {
                        noAux = noAux.Next;
                    }
                    noAux.Next = new No(info);
                }
            }



            public No RemoveFinal()
            {
                No no = null;
                No noAux;
                No noAux2 = new No(null);
                if (No != null)
                {
                    noAux = No;
                    while (noAux.Next != null)
                    {
                        noAux2 = noAux;
                        noAux = noAux.Next;
                    }

                    no = noAux;
                    noAux = null;
                    noAux2.Next = null;
                }
                return no;
            }



            public Nos Percorre()
            {
                No noAux = No;
                Nos nos = new Nos();
                while (noAux != null)
                {
                    nos.Add(noAux);
                    noAux = noAux.Next;
                    Console.WriteLine(noAux.Info);
                }
                return nos;
            }


            public int getTamanho()
            {
                int i = 0;
                No noAux = No;
                Nos nos = new Nos();
                while (noAux != null)
                {
                    nos.Add(noAux);
                    noAux = noAux.Next;
                    Console.WriteLine(noAux.Info);
                    i++;
                }
                return i;
            }

            public void ImprimirLista()
            {
                if (No.Info == null)
                    Console.WriteLine("  Lista vazia");
                else
                {
                    No atual = No;
                    while (atual != null)
                    {
                        Console.WriteLine("  {0}", atual.Info);

                        atual = atual.Next;
                    }
                }
            }

            public bool Busca(object info)
            {
                bool exists = false;
                if (No != null)
                {
                    No noAux = No;
                    while (noAux != null)
                    {
                        if (noAux.Info == info)
                        {
                            exists = true;
                            break;
                        }
                        noAux = noAux.Next;
                    }
                }
                return exists;
            }

            public bool BuscaIndice(object info)
            {
                bool exists = false;
                if (No != null)
                {
                    No noAux = No;
                    while (noAux != null)
                    {
                        if (noAux.Info == info)
                        {
                            exists = true;
                            break;
                        }
                        noAux = noAux.Next;
                    }
                }
                return exists;
            }

            public void Clear()
            {
                No = null;
            }

        }
    }
}
