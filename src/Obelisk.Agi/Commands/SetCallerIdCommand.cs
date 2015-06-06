using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for setting the Id of the caller.
    /// </summary>
    public class SetCallerIdCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the Id of the caller.
        /// </summary>
        public string CallerId
        {
            get; 
            set;
        }

        /// <summary>
        /// Initialises a new instance of the SetCallerIdCommand class.
        /// </summary>
        public SetCallerIdCommand(string callerId)
        {
            CallerId = callerId;
        }
        
        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("SET CALLERID {0}", EscapeAndQuote(CallerId));
        }
    }
}
