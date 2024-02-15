using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Datacombs
{
    public enum ActionType
    {
        ADD,
        SET,
    }

    interface IAction
    {
        string NAME { get; }
        string DESC { get; }
        List<string> ALIAS { get; }
        ActionType TYPE { get; }
        string KEY { get; }


        void Do(Player player);
    }
}
