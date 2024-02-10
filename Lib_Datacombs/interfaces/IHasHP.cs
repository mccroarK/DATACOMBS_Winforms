using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Datacombs
{
    public interface IHasHP : IThing
    {
        Stat HP { get; }

        void CheckHP();
    }
}
