using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Datacombs
{
    interface IPlayer : IActor
    {
        List<Item> ITEMS { get; set; }
    }
}
