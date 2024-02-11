using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Datacombs
{
    interface IActor : IThing
    {
        void Update();
        void Turn();
    }
}
