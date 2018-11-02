using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TreinandoThreads
{
    class Program
    {
        static void escreveralgo() {
            Thread.Sleep(5000);
            Console.WriteLine("Inicia thread após 5 secs...");
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(escreveralgo);
            t.Start();

            Console.WriteLine("Apareci..");

            Console.ReadKey();
        }
    }
}
