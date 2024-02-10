using System;

namespace Lib_Datacombs
{
    public class View : Command
    {
        public View()
        {
            NAME = "View";
            KEYS = new string[] { "view", "stats", "menu", "list" };
        }

        public override void Execute(Player player, string[] options)
        {
            // View the current enemy
        }
    }
}
