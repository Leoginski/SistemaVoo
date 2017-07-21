using SistemaVoo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using pais;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pais p1 = new Pais("Brasil", "Brasilia", 1000.12);
            Pais p2 = new Pais("EUA", "Woshiton", 1000.12);
            Pais p3 = new Pais("Colombia", "Woshito", 1000.12);
            Pais p4 = new Pais("México", "Woshitonn", 1000.12);
            Pais p5 = new Pais("Peru", "Woshitoito", 1000.12);
            Pais p6 = new Pais("Argentina", "Woshitito", 1000.12);

            ContaCorrente cc = new ContaPoupanca(1, 1000, "asdasd", "asdasd", 0.1);
            ContaCorrente ce = new ContaEspecial(1, 1000, "asdasd", "asdasd", 1000);
            cc.Sacar(100);
            ce.Sacar(1500);
            ce.Depositar(400);
            ce.Sacar(1000);
            Console.WriteLine(ce.Saldo);


            //p1.AddFronteira(p2);
            //p1.AddFronteira(p3);
            //p1.AddFronteira(p4);

            //p2.AddFronteira(p1);
            //p2.AddFronteira(p3);
            //p2.AddFronteira(p5);

            //var fronteirasp1p2 = p1.FronteirasComuns(p2);

            //fronteirasp1p2.ImprimirLista();
        }
    }
}
