using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Datacombs
{
    public interface IStat : IThing
    {
        int MAX { get; set; }
        int MIN { get; set; }
        int VAL { get; set; }

        string ToString();
    }
}
