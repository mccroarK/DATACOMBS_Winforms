using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Datacombs
{
    public class Quit : Command
    {
        public Quit()
        {
            NAME = "Quit";
            KEYS = new string[] { "quit", "exit" };
        }

        public override void Execute(Player player, string[] options)
        {
            // Quit the game
            GameManager gameManager = GameManager.Instance;
            gameManager.RUNNING = false;
        }
    }
}
