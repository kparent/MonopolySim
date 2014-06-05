using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Simulator
{
    abstract class Property : Space
    {
        public String  name;
        public int     price; 
        public Boolean isOwned;
        public Player  owner;
        public int     rent;

        /// <summary>
        /// Auction property to players 
        /// if lander doesn't buy it
        /// </summary>
        public void Auction()
        {
            // Property will be auctioned off
            // to highest bidder
        }

        /// <summary>
        /// Action taken when a player lands on 
        /// this property
        /// </summary>
        /// <param name="player"></param>
        public override void IsLandedOnBy(Player player)
        {
            // Pay owner rent if owned
            if (this.isOwned)
            {
                player.MustPay(this.owner, this.rent);
            }
            // Otherwise lander can buy
            else
            {
                player.MayBuy(this);
            }
        }
    }
}
