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

        public int[] RollDice()
        {
            int[] rolled = new int[2];
            Random rand = new Random();
            rolled[0] = (rand.Next(1, 7));
            rolled[1] = (rand.Next(1, 7));
            return rolled;
        }
    }
}
