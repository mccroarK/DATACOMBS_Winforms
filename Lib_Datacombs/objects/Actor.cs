using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Datacombs
{
    public class Actor : IActor
    {
        #region Properties
        public int ID { get; set; }
        public string NAME { get; set; }
        #endregion

        #region Constructors
        public Actor()
        {
            ID = 0;
            NAME = string.Empty;
        }

        public Actor(int id, string name)
        {
            ID = id;
            NAME = name;
        }
        #endregion

        #region Methods
        public void Update()
        {

        }

        public void Turn()
        {

        }
        #endregion
    }
}
