using System;

namespace Obelisk.Agi.Commands
{
    /// <summary>
    /// Represents the level of verbosity.
    /// </summary>
    public enum VerboseLevel
    {
        Level1 = 1,
        Level2 = 2,
        Level3 = 3,
        Level4 = 4,
    }

    /// <summary>
    /// Represents a command for logging a message. 
    /// </summary>
    public class VerboseCommand : ObeliskCommand
    {
        /// <summary>
        /// Gets or sets the message to log. 
        /// </summary>
        public string Message
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        public VerboseLevel Level
        {
            get; 
            set;
        }

        /// <summary>
        /// Initialises a new instance of the VerboseCommand class.
        /// </summary>
        public VerboseCommand(string message, VerboseLevel level)
        {
            Message = message;
            Level = level;
        }

        /// <summary>
        /// Compiles the command.
        /// </summary>
        public override string Compile()
        {
            return String.Format("VERBOSE {0} {1}", EscapeAndQuote(Message), (int)Level);
        }
    }
}
