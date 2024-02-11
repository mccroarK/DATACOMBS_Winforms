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
        public Player PLAYER { get; set; }
        public Room ROOM { get; set; }
        public string DISPLAY { get; set; }
        public bool RUNNING { get; set; }

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
            // Booleans
            RUNNING = true;

            // Test list
            PLAYER = new Player(0, "Name", "hero");
            ROOM = new Room("placeholder");

            // Add starting commands
            PLAYER.CMDS.Add(new Quit());
        }
        #endregion

        #region Methods
        public void ReadInput(string input)
        {
            // Split input string by semicolons to get commands and parameters
            string[] commandlines = input.Split(';');

            // For every inputted command
            foreach (string line in commandlines)
            {
                // Split input string
                List<string> tokens = line.Split(' ').ToList();

                // If first token is an empty string and nothing is behind it
                if (tokens[0] == string.Empty && tokens.Count > 1)
                {
                    // Remove first element
                    tokens.RemoveAt(0);
                }

                // Get command from first token
                var comlist = from com in PLAYER.CMDS
                              where com.KEYS.Contains(tokens.ToArray()[0])
                              select com;

                // If command list is not empty
                if (comlist.Any())
                {
                    // Get first command typed and options
                    Command command = comlist.First();
                    string[] options = tokens.Skip(1).ToArray();

                    // Execute command from tokens after command
                    command.Execute(PLAYER, options);
                }
            }
        }
        #endregion


    }
}
