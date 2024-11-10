using kvira4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kvira4
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Samkutxedi samkutx = new Samkutxedi(3, 4, 5);
            Console.WriteLine($"perimetri: {samkutx.Perimetristvis()}");


            Kvadrati otxk = new Kvadrati(4);
            Console.WriteLine($"fartobi: {otxk.Fartobistvis()}");

            Console.ReadLine();
        }
    }
}
