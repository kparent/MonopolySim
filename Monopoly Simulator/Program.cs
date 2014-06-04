using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Monopoly_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player kyle = new Player();
            while (true)
            {
                int first = kyle.RollDice()[0];
                int second = kyle.RollDice()[1];
                Console.WriteLine(first + " " + second);
                Thread.Sleep(90);
            }
            Console.ReadLine();
        }
    }
}
