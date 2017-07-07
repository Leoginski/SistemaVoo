using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            int numero;
            Lista lista = new Lista();
            do
            {
                Console.WriteLine("[ 1 ] Adicionar Inicio");
                Console.WriteLine("[ 2 ] Adicionar Fim");
                Console.WriteLine("[ 3 ] Buscar Por Item");
                Console.WriteLine("[ 4 ] Buscar Por Indice");
                Console.WriteLine("[ 5 ] Remover Por Item");
                Console.WriteLine("[ 6 ] Remover Por Indice");
                Console.WriteLine("[ 7 ] Exibe Itens");
                Console.WriteLine("[ 0 ] Sair do Programa");
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite uma opção: ");
                opcao = Int32.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite um item para inserir no inicio: ");
                        numero = Int32.Parse(Console.ReadLine());
                        lista.InsereInicio(numero);
                        break;
                    case 2:
                        Console.Write("Digite um item para inserir no final: ");
                        numero = Int32.Parse(Console.ReadLine());
                        lista.InsereFinal(numero);
                        break;
                    case 3:
                        Console.Write("Digite um item para busca: ");
                        numero = Int32.Parse(Console.ReadLine());
                        lista.Busca(numero);
                        break;
                    case 4:
                        Console.Write("Digite um indice para busca: ");
                        numero = Int32.Parse(Console.ReadLine());
                        lista.BuscaIndice(numero);
                        break;
                    case 5:
                        Console.Write("Digite um item para remocao: ");
                        numero = Int32.Parse(Console.ReadLine());
                        //lista.Remove(numero);
                        break;
                    case 6:
                        Console.Write("Digite um indice para remocao: ");
                        numero = Int32.Parse(Console.ReadLine());
                        //lista.RemoveIndice(numero);
                        break;
                    case 7:
                        lista.ImprimirLista();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Bye Bye, vc saiu do Programa. Clique qualquer tecla para sair...");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
            while (opcao != 0);
        }
    }
}
