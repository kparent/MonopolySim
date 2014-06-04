using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player kyle = new Player();
            Console.WriteLine(kyle.RollDice());
        }
    }
}
