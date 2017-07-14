namespace ListaEncadeada
{
    partial class Program
    {
        public class No<T>
        {
            public T valor;
            public No<T> prox;

            public No(T valor, No<T>prox)
            {
                this.valor = valor;
                this.prox = prox;
            }

            public No(T valor)
            {
                this.valor = valor;
                this.prox = null;
            }
        }
    }
}
