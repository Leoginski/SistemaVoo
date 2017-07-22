using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVoo
{
    public class TesteAeroporto
    {
        static void Main(string[] args)
        {
            Aeroporto aeroporto1 = new Aeroporto("123","aero1");
            Aeroporto aeroporto2 = new Aeroporto("123", "aero2");
            Aeroporto aeroporto3 = new Aeroporto("213", "aero3");

            Aviao aviao1 = new Aviao("modelo1", "pre1", "Gol", 10, 5);
            Aviao aviao2 = new Aviao("modelo2", "pre2", "Gol", 10, 5);
            Aviao aviao3 = new Aviao("modelo3", "pre3", "Gol", 10, 5);

            aeroporto1.AddAvioes(aviao1);
            aeroporto2.AddAvioes(aviao2);
            aeroporto3.AddAvioes(aviao3);

            aeroporto1.AddDestinos(aeroporto2);
            aeroporto2.AddDestinos(aeroporto3);

            Console.WriteLine(aeroporto1.Equals(aeroporto2));
            Console.WriteLine(aeroporto1.verificarAviaoPousado(aviao1.getPrefixo()));
            Console.WriteLine(aeroporto1.verificarAviaoPousado(aviao2.getPrefixo()));

            Console.WriteLine(aeroporto1.PossuiRota(aeroporto3));
            Console.WriteLine(aeroporto3.PossuiRota(aeroporto1));
        }
    }
}
