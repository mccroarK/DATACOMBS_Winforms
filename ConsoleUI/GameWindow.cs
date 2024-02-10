using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_Datacombs;

namespace ConsoleUI
{
    public partial class GameWindow : Form
    {
        GameManager gameManager;

        public GameWindow()
        {
            InitializeComponent();
        }

        private void enterBTN_Click(object sender, EventArgs e)
        {
            // Check game manager properties
            gameManager.ReadInput(inputTB.Text.ToLower());

            // Update game
            UpdateGame();

            // Clear player input
            inputTB.Clear();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            // Create game manager reference
            gameManager = GameManager.Instance;

            // Check game manager properties
            UpdateGame();
        }

        private void UpdateGame()
        {
            // If the player quits the game
            if (!gameManager.RUNNING)
            {
                // Close the app
                Close();
            }

            // Update display
            displayLBL.Text = gameManager.DISPLAY;

            // Player panel
            heroPB.Image = gameManager.PLAYER.Image;
            nameLBL.Text = gameManager.PLAYER.Name;

            // Room panel
            roomPB.Image = gameManager.ROOM.Image;
        }
    }
}
