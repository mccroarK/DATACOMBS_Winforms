using Lib_Datacombs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game manager
            GameManager gameManager = GameManager.Instance;

            // Start the form
            Application.Run(new GameWindow());
        }
    }
}
