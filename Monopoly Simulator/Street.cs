using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Simulator
{
    class Street : Property
    {
        int costOfHouse;
        Houses numberHouses;
        Color colorSet;

        /// <summary>
        /// Number of houses on property
        /// </summary>
        enum Houses
        {
            None,
            One,
            Two,
            Three,
            Four,
            Hotel
        }

        /// <summary>
        /// Colors to identify each set of
        /// streets on the board 
        /// </summary>
        enum Color
        {
            Purple,
            LightBlue,
            Pink,
            Orange,
            Red,
            Yellow,
            Green,
            Blue
        }

        // Constructor 
        public Street(String _name, int _price, int _rent)
        {
            this.name = _name;
            this.price = _price;
            this.isOwned = false;
            this.owner = null;
            this.rent = _rent;
        }


    }
}
