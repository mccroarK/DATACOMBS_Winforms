using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lib_Datacombs
{
    public class Room
    {
        #region Properties
        public Image IMG { get; set; }
        #endregion

        #region Constructors
        public Room()
        {
            IMG = Image.FromFile(@"..\..\..\Lib_Datacombs\room_images\placeholder.png");
        }
        public Room(string image_location)
        {
            IMG = Image.FromFile(@"..\..\..\Lib_Datacombs\room_images\" + image_location + ".png");
        }
        #endregion

        #region Methods
        #endregion
    }
}
