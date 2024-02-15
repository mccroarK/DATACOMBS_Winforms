using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Datacombs
{
    public abstract class Action : IAction
    {
        /// <summary>
        /// ACTION:
        /// An action that a player can perform by typing into the input text box
        /// 
        /// PROPERTIES:
        /// Name:   The name of the action
        /// Desc:   The description of the action
        /// Alias:  The words used to call the action
        /// Type:   The type of effect an action has
        ///     ADD:    Adds to a keypair int/float             (EX: Move (North) adds 1 ROOMINDEX stat)
        ///     SET:    Changes a keypair int/float             ()
        ///     BOOL:   Changes a keypair boolean               ()
        ///     USE:    Interacts with an object type           (EX: Fight interacts with Enemy object)
        /// Key:    The key of the value affected by the type   (EX: "quit" changes Settings Option for "quit")
        /// Value:  The new keypair value added by the action   (EX: Quit changes Setting Option "quit" to false)
        /// 
        /// METHOD:
        /// Do: Method performed when the action is called
        /// Takes in the player that performed the action as well as their input.
        /// Each action can parse input differently.
        /// 
        /// INSTANTIATION:
        /// Action information is instantiated using a database table record.
        /// Action information is saved in a database table.
        /// </summary>

        #region Properties
        public string NAME { get; }             // Action Name
        public string DESC { get; }             // Action Description
        public List<string> ALIAS { get; }      // Action Aliases
        public ActionType TYPE { get; }         // Action Type
        public string KEY { get; }              // Action Type Key
        public dynamic VALUE { get; }           // Action Type Key Value
        #endregion

        #region Constructors
        public Action() { }                     // Default Constructor            
        public Action(string name, string desc, List<string> alias)
        {
            NAME = name;
            DESC = desc;
            ALIAS = alias;
        }
        #endregion

        public abstract void Do(Player player); // Action Do method
    }
}
