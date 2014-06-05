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


        /// <summary>
        /// Simulate a random roll
        /// of two dice
        /// </summary>
        /// <returns>Array of 2 integers containing dice rolls</returns>
        public int[] RollDice()
        {
            int[] rolled = new int[2];
            Random rand = new Random();
            rolled[0] = (rand.Next(1, 7));
            rolled[1] = (rand.Next(1, 7));
            return rolled;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="opponent">Player to which money is owed</param>
        public void MustPay(Player opponent, int amt)
        {
            if (this.wealth > amt)
            {
                this.wealth -= amt;
                opponent.wealth += amt;
            }
            else
            {
                // Attempt to sell houses or
                // mortgage houses to pay debt
                // Will require AI decision making
            }
        }

        /// <summary>
        /// Player can decide whether to purchase
        /// property or auction it
        /// </summary>
        /// <param name="property"></param>
        public void MayBuy(Property property)
        {
            if (this.wealth < property.price)
            {
                
            }
            // Will require AI decision making
        }
    }
}
