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
        public string Name { get; set; }
        #endregion

        #region Constructors
        public Actor()
        {
            Name = string.Empty;
        }

        public Actor(string name)
        {
            Name = name;
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
