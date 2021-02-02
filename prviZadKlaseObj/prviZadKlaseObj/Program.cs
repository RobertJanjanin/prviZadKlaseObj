using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prviZadKlaseObj
{
    class Program
    {
        static void Main(string[] args)
        {

            Bijelogoricno Hrast = new Bijelogoricno(true);
            Crnogoricno Bor = new Crnogoricno(false);
            Console.WriteLine("Hrast: " + Hrast.OpadajuListovi());
            Console.WriteLine("Bor: " + Bor.OpadajuListovi());
            Console.ReadKey();
        }
        }
    }

