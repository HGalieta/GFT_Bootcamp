using GFT_RPG.Entities;
using System;

namespace GFT_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 2);
            Mage jennica = new Mage("Jennica", 3);

            Console.WriteLine(arus.ToString());
            Console.WriteLine(arus.Attack());

            Console.WriteLine(jennica.ToString());
            Console.WriteLine(jennica.Attack());
            Console.ReadLine();
        }
    }
}
