using System.Collections;

namespace ListaEncadeada
{
    partial class Program
    {
        public class Nos : CollectionBase
        {
            public No this[int item]
            { get { return this.GetNo(item); } }

            public void Add(No no)
            {
                List.Add(no);
            }

            public bool Remove(int index)
            {
                return true;
            }

            private No GetNo(int Index)
            {
                return (No)List[Index];
            }

        }
    }
}
