using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure Problems");
            Console.WriteLine("Press 6 for Primenumber Problem");
            int option = Convert.ToInt32(Console.ReadLine());

            PrimeNumber1 pnum = new Primeumber1();
            pnum.Prime();
        }
    }
}