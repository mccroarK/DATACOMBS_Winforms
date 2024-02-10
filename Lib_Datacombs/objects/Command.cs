using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Datacombs
{
    public abstract class Command : ICommand
    {
        // Properties
        public string NAME { get; set; }
        public string[] KEYS { get; set; }

        // Methods
        public string Info()
        {
            // Info string of command
            return "";
        }

        public abstract void Execute(Player player, string[] options);
    }
}
