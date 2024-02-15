using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Datacombs
{
    interface IPlayer : IActor
    {
        string INPUT { get; set; }
        List<Item> ITEMS { get; set; }
    }
}
