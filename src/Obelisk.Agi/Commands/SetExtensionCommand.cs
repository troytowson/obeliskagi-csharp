using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents a command for setting the extension of the channel.
    /// </summary>
    public class SetExtensionCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the extension of the channel.
        /// </summary>
        public string Extension
        {
            get; 
            set;
        }

        /// <summary>
        /// Initialises a new instance of the SetContextCommand class.
        /// </summary>
        public SetExtensionCommand(string extension)
        {
            Extension = extension;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("SET EXTENSION {0}", EscapeAndQuote(Extension));
        }
    }
}
