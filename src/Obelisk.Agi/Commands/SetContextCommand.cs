using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for setting the context of the channel.
    /// </summary>
    public class SetContextCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the Context of the channel.
        /// </summary>
        public string Context
        {
            get; 
            set;
        }

        /// <summary>
        /// Initialises a new instance of the SetContextCommand class.
        /// </summary>
        public SetContextCommand(string context)
        {
            Context = context;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("SET CONTEXT {0}", EscapeAndQuote(Context));
        }
    }
}
