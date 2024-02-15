using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Datacombs
{
    public sealed class GameManager
    {
        #region Properties
        // Public
        public Dictionary<string, dynamic> SETTINGS { get; set; } = new Dictionary<string, dynamic>()
        {
            { "quit", false }   // Quit game
        };
        public Player PLAYER { get; set; }
        public Room ROOM { get; set; }
        public string DISPLAY { get; set; }

        // Private
        private static GameManager instance = null;
        public static GameManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameManager();
                }
                return instance;
            }
        }
        #endregion

        #region Constructors
        private GameManager()
        {
            // Test list
            PLAYER = new Player(0, "Name", "hero");
            ROOM = new Room("placeholder");

            // Add starting commands
        }
        #endregion

        #region Methods
        public void ReadInput(string input)
        {
            PLAYER.INPUT = input.ToLower();
        }
        #endregion


    }
}
