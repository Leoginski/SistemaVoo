namespace ListaEncadeada
{
    partial class Program
    {
        public class No<T>
        {
            public No(object info, No next)
            {
                this.Info = info;
                this.Next = next;
            }

            public No(object info)
            {
                Info = info;
                Next = null;
            }

            public T Info = null;
            public No Next = null;
        }
    }
}
