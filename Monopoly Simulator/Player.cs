using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Simulator
{
    enum Piece
    {
        Hat,
        Car,
        Dog,
        Thimble,
        Iron,
        Wheelbarrow,
        Ship,
        Shoe
    };

    class Player
    {
        Piece   piece;
        int     wealth;

        List<Property> properitesOwned;

        public int RollDice()
        {
            Random rand = new Random(Int32.Parse(DateTime.Now.ToString("HHmm")));
            return (rand.Next() % 6) + 1;
        }
    }
}
