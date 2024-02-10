using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Datacombs
{
    public class Player : Actor
    {
        #region Properties
        public Image Image { get; set; }
        #endregion

        #region Constructors
        public Player() : base()
        {
            Image = Image.FromFile(@"..\..\..\Lib_Datacombs\player_images\placeholder.png");
        }
        public Player(string name, string image_location) : base(name)
        {
            Image = Image.FromFile(@"..\..\..\Lib_Datacombs\player_images\" + image_location + ".png");
        }
        #endregion

        #region

        #endregion
    }
}
