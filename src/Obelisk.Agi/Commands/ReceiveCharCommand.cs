using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for receiveing a char.
    /// </summary>
    public class ReceiveCharCommand : ObeliskCommand
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
        /// Initialises a new instance of the ReceiveCharCommand class.
        /// </summary>
        public ReceiveCharCommand(int timeout)
        {
            Timeout = timeout;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("RECEIVE CHAR {0}", Timeout);
        } 
    }
}
