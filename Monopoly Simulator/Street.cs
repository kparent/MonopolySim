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
    }
}
