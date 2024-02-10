using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Datacombs
{
    public class Help : Command
    {
        public Help()
        {
            NAME = "Help";
            KEYS = new string[] { "help" };
        }

        public override void Execute(Player player, string[] options)
        {
            // Display all command info strings
        }
    }
}
