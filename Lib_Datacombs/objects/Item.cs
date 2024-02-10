using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Datacombs
{
    public class Item : Thing, IInteractable
    {
        // Properties

        // Constructors
        public Item() { }

        // Methods
        public override string Info()
        {
            // Item info
            return "";
        }

        public void OnInteract(Player player)
        {
            // Item pick up
        }
    }
}
