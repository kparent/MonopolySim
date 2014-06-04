using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Simulator
{
    abstract class Space
    {
        String name;

        public abstract void IsLandedOnBy(Player player); 
    }
}
