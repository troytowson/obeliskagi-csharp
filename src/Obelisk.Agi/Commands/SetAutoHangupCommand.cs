using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for setting an auto hangup.
    /// </summary>
    public class SetAutoHangupCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        public int Time
        {
            get;
            set;
        }
        
        /// <summary>
        /// Initialises a new instance of the SetAutoHangupCommand class.
        /// </summary>
        public SetAutoHangupCommand(int time)
        {
            Time = time;
        }
        
        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("SET AUTOHANGUP {0}", Time);
        } 
    }
}
