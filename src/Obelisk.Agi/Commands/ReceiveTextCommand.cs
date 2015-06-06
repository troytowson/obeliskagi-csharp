using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for receiving text.
    /// </summary>
    public class ReceiveTextCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the timeout.
        /// </summary>
        public int Timeout
        {
            get; 
            set;
        }

        /// <summary>
        /// Initialises a new instance of the ReceiveTextCommand class.
        /// </summary>
        public ReceiveTextCommand(int timeout)
        {
            Timeout = timeout;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("RECEIVE TEXT {0}", Timeout);
        } 
    }
}
