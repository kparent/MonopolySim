using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Simulator
{
    abstract class Property : Space
    {
        String  name;
        int     price;
        Boolean isOwned;
    }
}
