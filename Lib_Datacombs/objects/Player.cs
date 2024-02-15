using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Datacombs
{
    public class Player : Actor, IPlayer
    {
        #region Properties
        public string INPUT { get; set; }
        public List<Item> ITEMS { get; set; } = new List<Item>();
        public Image IMG { get; set; }
        public List<Action> CMDS { get; set; } = new List<Action>();
        #endregion

        #region Constructors
        public Player() : base()
        {
            IMG = Image.FromFile(@"..\..\..\Lib_Datacombs\player_images\placeholder.png");
        }
        public Player(int id, string name, string image_location) : base(id, name)
        {
            IMG = Image.FromFile(@"..\..\..\Lib_Datacombs\player_images\" + image_location + ".png");
        }
        #endregion

        #region

        #endregion
    }
}
