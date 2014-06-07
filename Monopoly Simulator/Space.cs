using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Simulator
{
    abstract class Space
    {
        public String name;

        /// <summary>
        /// Action when a space on the board
        /// is landed on
        /// </summary>
        /// <param name="player">Player who lands on the board</param>
        public abstract void IsLandedOnBy(Player player); 
    }
}
