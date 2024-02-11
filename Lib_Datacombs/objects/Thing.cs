using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Datacombs
{
    public abstract class Thing : IThing
    {
        // Properties
        public int ID { get; }
        public string NAME { get; }

        // Constructors
        public Thing()
        {
            ID = 0;
            NAME = string.Empty;
        }

        public Thing(int id, string name)
        {
            ID = id;
            NAME = name;
        }

    }
}
